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
    public partial class Event2 : Form
    {
        Form3 frm3;
        Random r = new Random();
        int a = 0;
        int b = 0;
        string aa, bb;
        int count = 0;
        public Event2()
        {
            InitializeComponent();
        }
        public Event2(Form3 _form)
        {
            InitializeComponent();
            frm3 = _form;
        }

        private void Event2_Load(object sender, EventArgs e)
        {
            label2.Text = "LOVE = " + frm3.love;
            pictureBox1_1.Hide();
            pictureBox2_1.Hide();
            a = r.Next(1, 16);
            while (true)
            {
                b = r.Next(1, 15);
                if (b != a)
                {   
                    aa = pic(a);
                    bb = pic(b);
                    break;
                }
                
            }

            pictureBox1.Load(@"C:\Users\두루미\Event2\꽃" + a + ".jpg");
            pictureBox2.Load(@"C:\Users\두루미\Event2\꽃" + b + ".jpg");
            this.ActiveControl = textBox1;
        }

        private string pic(int x)
        {
            switch (x)
            {
                case 1: return "해바라기";
                case 2: return "나팔꽃";
                case 3: return "무궁화";
                case 4: return "민들레";
                case 5: return "수국";
                case 6: return "장미";
                case 7: return "튤립";
                case 8: return "카네이션";
                case 9: return "동백꽃";
                case 10: return "백합";
                case 11: return "국화";
                case 12: return "코스모스";
                case 13: return "라일락";
                case 14: return "안개꽃";
                case 15: return "연꽃";
                default: return "";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == aa)
            {
                pictureBox1_1.Show();
                pictureBox1_1.Load(@"C:\Users\두루미\Event2\O.png");
                pictureBox1_1.BackgroundImage = pictureBox1.Image;
                textBox1.Enabled = false;
                pictureBox3.Enabled = false;
                frm3.love += 50;
                count++;
                if (count == 2) endd();
            }
            else
            {
                pictureBox1_1.Show();
                pictureBox1_1.Load(@"C:\Users\두루미\Event2\X.png");
                pictureBox1_1.BackgroundImage = pictureBox1.Image;
                textBox1.Text = aa;
                textBox1.Enabled = false;
                pictureBox3.Enabled = false;
                frm3.love -= 15;
                count++;
                if (count == 2) endd();
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == bb)
            {
                pictureBox2_1.Show();
                pictureBox2_1.Load(@"C:\Users\두루미\Event2\O.png");
                pictureBox2_1.BackgroundImage = pictureBox2.Image;
                textBox2.Enabled = false;
                pictureBox4.Enabled = false;
                frm3.love += 50;
                label2.Text = "LOVE = " + frm3.love;
                count++;
                if (count == 2) endd();
            }
            else
            {
                pictureBox2_1.Show();
                pictureBox2_1.Load(@"C:\Users\두루미\Event2\X.png");
                pictureBox2_1.BackgroundImage = pictureBox2.Image;
                textBox2.Text = bb;
                textBox2.Enabled = false;
                pictureBox4.Enabled = false;
                frm3.love -= 15;
                label2.Text = "LOVE = " + frm3.love; 
                count++;
                if (count == 2) endd();
            }
        }

        private void endd()
        {
            MessageBox.Show("문제풀기를 완료했습니다 ! \n 현재 LOVE = " + frm3.love,"이벤트 완료");
            frm3.Opacity = 100;
            frm3.lolo.Text = Convert.ToString(frm3.love);
            this.Visible = false;

            Event2 form = new Event2();
            form.Close();
            form.Dispose();
            form = null;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Control me = sender as Control;
            me.Hide();
        }
    }
}
