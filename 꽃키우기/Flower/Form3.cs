using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flower
{
    public partial class Form3 : Form
    {
        public static string eat;
        public int love = 100;
        public int suncount = 0;//  능력치 변수
        public int raincount =0;
        public int nutrientcount = 0;
        public int musiccount = 0;
        public int day = 19;
        public bool count = true;
        

        public Form3()
        {
            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            baby.Image = Form2.baby;
            lolo.Parent = pictureBox1;
            lolo.Text = Convert.ToString(love);
            bname.Parent = pictureBox3;
            bname.Text = Form2.bname;
            d_day.Text = " D - "+day;
            now.Text = "내 이름은 \n" + Form2.bname + " !\n반가워♥";
            //obj: 이벤트를 통보한 개체 , e: 이벤트 처리에 필요한 인자
        }


        private void button1_Click(object sender, EventArgs e)//관리자용
        {           
            /*Event3 showEvent= new Event3(this);
            showEvent.ShowDialog();*/
        }

        private void heart_Click(object sender, EventArgs e)
        {
            love = love + 8; lolo.Text = Convert.ToString(love);
            day--;//////////잠깐 바꾼것
            d_day.Text = " D - " + day;
            ifif(day);
            upgrade(day);
        }

        private void sun_Click(object sender, EventArgs e)
        {
            suncount++;
            eat = "sun";
            day--;
            d_day.Text = " D - " + day;
            goEat();
        }

        private void rain_Click(object sender, EventArgs e)
        {
            raincount++;
            eat = "rain";
            day--;
            d_day.Text = " D - " + day;
            goEat();
        }

        private void pou_Click(object sender, EventArgs e)
        {
            nutrientcount++;
            eat = "pou";
            day--;
            d_day.Text = " D - " + day;
            goEat();

        }

        private void music_Click(object sender, EventArgs e)
        {
            
            musiccount++;
            eat = "music";
            day--;
            d_day.Text = " D - " + day;
            goEat();


        }

        private void goEat(){
            Eat showEat = new Eat();
            showEat.ShowDialog();
            now.Text = "광합성 횟수 : " + suncount + "\n물 먹은 횟수 : " + raincount + "\n비료 먹은 횟수 : "
                          + nutrientcount + "\n음악 들은 횟수 : " + musiccount;
            love = love + 5; lolo.Text = Convert.ToString(love);
            ifif(day);
            upgrade(day);
        }

        private void upgrade(int d)
        {
            switch (d) {
                case 12: baby.Load(@"C:\Users\두루미\폼3\새싹.png");
                          break;

                case 6: baby.Load(@"C:\Users\두루미\폼3\봉우리.png");
                          break;
          }
        }

        private void ifif(int d)
        {
            if (d == 12 || d == 6 || d == 0){
                Form3 form = new Form3();
                form.Visible = false;
                switch(d){
                    case 12 : form.Hide();
                              this.Opacity = 0;
                              Event1 showEvent = new Event1(this);
                              showEvent.ShowDialog();
                              break;
                    case 6: form.Hide();
                            this.Opacity = 0;
                            Event2_1 showEvent2_1 = new Event2_1(this);
                            showEvent2_1.ShowDialog();
                            break;
                    case 0: form.Hide();
                            this.Opacity = 0;
                            EventLast showLast = new EventLast(this);
                            showLast.ShowDialog();
                            break;
                } 
            }  
        }

    }

}