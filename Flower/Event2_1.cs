using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flower
{
    public partial class Event2_1 : Form
    {
        Form3 frm3;//진행중인 게임을 다시 열기위해서 ~~
        int q = 0; // 진행된 퀴즈의 총 갯수
        int count = 0; // 맞춘 퀴즈 갯수 저장
        int[] array = new int[5];
        String A;
        Boolean answer;
        public Event2_1()
        {
            InitializeComponent();
        }
        public Event2_1(Form3 _form)
        {
            InitializeComponent();
            frm3 = _form;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Control here = sender as Control; // 설명창이 here가 됨
            here.Hide();
            Random r = new Random();
            Boolean ok = true;
            int i = 0;
            while (i < 5) // 배열 array에 문제번호 할당
            {
                int temp = r.Next(10) + 1;
                for (int j = 0; j <= i; j++)
                {
                    ok = true;
                    if (array[j] == temp)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok == true)
                {
                    array[i] = temp;
                    i++;
                }
            }
            StartoxGame();
        }

        public void StartoxGame()
        {

            
            switch (array[q]) {
                   
                case 1:
                    label1.Text = "이 이곳은 고구려대학교이다.";
                    answer = false;
                    A = "이곳은 신라대학교 입니다 ! ";
                    break;

                case 2:
                    label1.Text = "학부 이름은 \n'컴퓨터하드웨어공학부'이다.";
                    answer = false;
                    A = "컴퓨터소프트웨어공학부 입니다 ! ";
                    break;

                case 3:
                    label1.Text = "꽃키우기 프로그램은 \nC#언어로 만든 것이다.";
                    A = "이 꽃키우기 프로그램은 C#으로 만들어진 프로그램입니다 ! ";
                    answer = true;
                    break;

                case 4:
                    label1.Text = "겨울에 피는 꽃은 없다.";
                    A = "겨울에도 꽃은 핍니다 ! 예) 동백꽃 ";
                    answer = false;
                    break;

                case 5:
                    label1.Text = "식물은 사람이 하는 말을 \n알아듣는다.";
                    A = "식물은 사람이 하는 말을 알아들을 수 없습니다 ! ";
                    answer = false;
                    break;
                case 6:
                    label1.Text = "식물을 키울 때 조명이 있다면 \n햇빛은 없어도 된다.";
                    answer = false;
                    A = "식물은 햇빝을 이용하여 광합성을 해야합니다 ! ";
                    break;
                case 7:
                    label1.Text = "우리나라를 상징하는 꽃은 벚꽃이다";
                    A = "우리나라를 상징하는 꽃은 무궁화 입니다 ! ";
                    answer = false;
                    break;
                case 8:
                    label1.Text = "카네이션, 무궁화, 해바라기는 \n모두 여름에 피는 꽃이다.";
                    A = "카네이션, 무궁화, 해바라기는 모두 여름에 피는 꽃 입니다 !";
                    answer = true;
                    break;
                case 9:
                    label1.Text = "라일락의 꽃말은 첫사랑이다.";
                    A = "라일락의 꽃말은 첫사랑, 젊은날의 추억 등 여러가지가 있습니다 ! ";
                    answer = true;
                    break;
                case 10:
                    label1.Text = "교수님 성함은 \n'김광백'교수님이다.";
                    answer = true;
                    A = "오늘 강의를 맡으신 교수님은 김광백 교수님 입니다 ! ";
                    break;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) // O 그림을 눌렀을 때 실행
        {
            OXresult(true);
            
        }

        private void pictureBox2_Click(object sender, EventArgs e) // X 그림을 눌렀을 때 실행
        {
            OXresult(false);
        }

        public void OXresult(Boolean good)
        {
            if(answer == good)
            {
                count++;
                MessageBox.Show(A, "정답 ♥ !");
            }
            else
            {
                MessageBox.Show(A, "오답 .. !");
            }

            q++;

            if (q == 5)
            {
                //이벤트2_1종료하는 것 적기
                MessageBox.Show("OX 퀴즈가 종료되었습니다 !\n5문제중 "+count+"개 정답 !", "퀴즈종료");

                
                frm3.Opacity = 100;
                frm3.lolo.Text = Convert.ToString(frm3.love);

                this.Visible = false;
                Event2_1 event2_1 = new Event2_1();
                event2_1.Close();
                event2_1.Dispose();
                event2_1 = null;
                
            }
            else
            {
                StartoxGame(); //다시 OX퀴즈 시작
            }
        }

        private void Event2_1_Load(object sender, EventArgs e)
        {

        }
    }
}


