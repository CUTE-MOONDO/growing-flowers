using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flower
{
    public partial class Event1 : Form
    {
        Form3 frm3;
        Random r = new Random();
        int cl = 0;
        string num;
        bool count = true;
        public Event1()
        {
            InitializeComponent();
        }
        public Event1(Form3 _form)
        {
            InitializeComponent();
            frm3 = _form;
        }
        private void Event_Load(object sender, EventArgs e)
        {
            int love = frm3.love;
            bugBox.Text = "여 러"; // 텍스트박스에 미리 보여질 글자를 넣어놓는다
            label1.Text = "LOVE = " + love; // 현재 LOVE 값을 보여준다.
        }

        public void Bug() // 벌레와 관련된 함수
        {
            int size = r.Next(8, 20); //벌레 갯수 생성
            Point[] p = new Point[size]; //벌레의 자리값을 저장하는 배열
            num = Convert.ToString(size);
            for (int i = 0; i < p.Length; i++)//벌레 위치 생성하는 for문
            {
                int xx = r.Next(3, 700); //가로 위치 지정
                int yy = r.Next(3, 300);//세로 위치 지정
                p[i] = new Point(xx, yy); // 정해진 위치를 p배열안에 넣어주기 
            }

            PictureBox[] pb = new PictureBox[size];
            for (int i = 0; i < size; i++) //벌레 픽쳐박스 생성
            {
                pb[i] = new PictureBox
                {
                    BackColor = Color.Transparent
                };
                pb[i].Location = p[i]; //pb[i]의 location을 p[i]에 저장해두었던 값으로 지정해줌
                pb[i].Width = r.Next(30, 100);
                pb[i].Height = r.Next(30, 100);

                pb[i].Load(@"C:\Users\두루미\Event1\bug" + r.Next(1, 4) + ".png"); //벌레 이미지를 정한다
                pb[i].SizeMode = PictureBoxSizeMode.StretchImage;//picuterBox의 이미지 넣는 방식을 정한다. 여기서 StretchImage는 pictuerBox의 크기에 따라 이미지를 변화시킴
                pb[i].Click += Pic_Click; //클릭했을 때의 상황에 이벤트를 넣어주는 것 여기서는 +=방식으로 이벤트를 추가하고 -=로 이벤트를 제거한다
                
                this.panel1.Controls.Add(pb[i]);//panel에다가 pb[i]를 추가한다

            }
        }
        private void Pic_Click(object sender, EventArgs e)//클릭이벤트 정의
        {
            Control me = sender as Control; //이벤트를 불러온 객체를 me라고 함. 여기서는 애벌레 하나하나가 me가 됨
            me.Hide();//클릭했을 때 애벌레를 숨김
            cl++;//벌레의 갯수를 카운트함
            bugBox.Text = Convert.ToString(cl);//애벌레를 누를 때 마다 textBox의 글씨에 cl(클릭한 벌레의 숫자)값을 보여준다
        }

        private void PictureBox1_Click(object sender, EventArgs e) //이벤트 결과 (비행기모양을 눌러 애벌레 갯수 맞추기를 실행했을 때)
        {
            if (bugBox.Text == num) // TextBox 안의 값과 애벌레의 갯수가 같을 때 (정답)
            {
                frm3.love += 50; 
                MessageBox.Show("잘했어요!  love + 50 \n현재 LOVE = " + frm3.love, "정답이예요 !!");//메세지 박스를 띄워 love값과 정담임을 알려줌
                
                frm3.lolo.Text =Convert.ToString(frm3.love); // form3의 love값을 수정해준다
                frm3.Opacity = 100; // Opacity 값을 0으로 해서 보이지않도록 해놨던 form3을 보이게 한다

                this.Visible = false;// Event1 창을 닫기 위한 과정
                Event1 form = new Event1(); 
                form.Close();
                form.Dispose();
                form = null;//과정끝남
            }
            else // TextBox 안의 값과 애벌레의 갯수가 같지 않을 때 (오답)
            {
                MessageBox.Show("다시 생각해 봐요 ! love - 15\n현재 LOVE = " + frm3.love, "틀렸어요 ㅠㅠ");//메세지 박스를 띄워 love값과 오답임을 알려줌
                frm3.love -= 15;//form3의 love값을 수정해준다
                label1.Text = "LOVE = " + frm3.love; //현재 창의 love값도 수정해준다
                if (frm3.love< 60)//만약 많이 틀려서 현재의 love값이 60 미만이 된다면 
                {
                    MessageBox.Show("키우기 화면으로 돌아갑니다. \n 현재 LOVE = " + frm3.love, "복귀");//메세지 박스를 띄워 love값과 form3으로 돌아간다고 알려줌
                    frm3.lolo.Text = Convert.ToString(frm3.love);//love값을 보여준다
                    frm3.Opacity = 100; // Opacity 값을 0으로 해서 보이지않도록 해놨던 form3을 보이게 한다

                    this.Visible = false;// Event1 창을 닫기 위한 과정
                    Event1 form = new Event1();
                    form.Close();
                    form.Dispose();
                    form = null;//과정끝남
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e) //애벌레를 처음에 몇 초만 보여주기 위해서 Timer를 사용한다
        {
            if (count == true)
            {
                count = false;
            }
            else
            {
                panel1.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) //설명 pictuerBox를 클릭하면 실행되는 이벤트
        {
            Control name = sender as Control; // pictureBox2가 name이 됨
            name.Hide();//설명 pictureBox를 숨김
            Bug(); //벌레관련 메소드를 실행함
            Timer_Tick(sender, e); // 타이머를 발동시킴 
            timer.Interval = 15000; //스케쥴 간격을 5초로 준 것이다. // 개발 기간만 15초로 조정
            timer.Start(); //타이머를 발동시킨다.
        }
    }


}/////////////////////////////타이머 부분 다시 볼것