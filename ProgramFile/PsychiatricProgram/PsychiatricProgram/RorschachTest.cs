using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PsychiatricProgram
{
    public partial class RorschachTest : Form
    {
        MainForm mf;
        int imgCount = 0, testCount = 1;
        string[] userAnser1, userAnser2, userAnser3;
        Image[] images;
        public RorschachTest(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            init();
        }

        void init()
        { 
            //아이콘을 resources에 담아둔 icon파일로 설정한다.
            this.Icon = Properties.Resources.MainIcon;

            //string배열 사이즈 설정
            userAnser1 = new string[10];
            userAnser2 = new string[10];
            userAnser3 = new string[10];

            //이미지 배열에 잉크그림 넣어두기
            images = new Image[10] {Properties.Resources.Rorschach_01, Properties.Resources.Rorschach_02, Properties.Resources.Rorschach_03,
                                    Properties.Resources.Rorschach_04,Properties.Resources.Rorschach_05, Properties.Resources.Rorschach_06,
                                    Properties.Resources.Rorschach_07, Properties.Resources.Rorschach_08, Properties.Resources.Rorschach_09,
                                    Properties.Resources.Rorschach_10};
        }

        private void RorschachTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            mf.Form_OnClose();
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        

        private void Button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //과거 이력 저장
            mf.user.setUserpast(when_textBox.Text, content_textBox.Text);

            //패널 숨기기
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)//확인 버튼을 누름
        {
            //입력된 사용자 응답을 테스트 숫자별 배열에 넣기
            switch (imgCount)
            {
                case 1: userAnser1[imgCount] = userAnser_textbox.Text;
                        break;
                case 2: userAnser2[imgCount] = userAnser_textbox.Text;
                        break;
                case 3: userAnser3[imgCount] = userAnser_textbox.Text;
                        break;
            }

            //이미지 순서가 10번이 되면 테스트 횟수를 증가시킴
            if (imgCount == 9)
            {
                if(testCount == 3)
                {
                    sendResult_btn.Visible = true;
                    panel3.Visible = false;

                }
                else
                {
                    testCount++;
                    imgCount = 0;
                    pictureBox1.Image = images[0];
                }
            }
            else
            {
                imgCount++;

                //다음 이미지로 변경
                pictureBox1.Image = images[imgCount];
            }

            userAnser_textbox.Text = "";
        }
        
        private void sendResult_btn_Click(object sender, EventArgs e)
        {
            //결과를 user클래스로 전송
            mf.user.setUserAnser1(userAnser1);
            mf.user.setUserAnser2(userAnser2);
            mf.user.setUserAnser3(userAnser3);
        }
    }
}
