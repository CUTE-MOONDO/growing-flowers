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
    public partial class EventLast : Form
    {
        Image image;
        Form3 frm3;
        public EventLast()
        {
            InitializeComponent();
        }
        public EventLast(Form3 _form)
        {
            InitializeComponent();
            frm3 = _form;
        }

        private void EventLast_Load(object sender, EventArgs e)
        {
            image=Image.FromFile(@"C:\Users\두루미\성공\"+Form2.flowerName+".png");
            pictureBox2.BackgroundImage = image;
            label1.Text = Form2.bname + "의";
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            pictureBox4.Parent = pictureBox1;
            label3.Hide();
            
        }

        private void hint(object sender, EventArgs e)
        {
            label3.Show();
        }
        private void dhint(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == Form2.flowerName)
            {
                if (frm3.love >= 100 && frm3.suncount >= 2 && frm3.raincount >= 2 && frm3.nutrientcount >= 2 && frm3.musiccount >= 2)
                {
                    MessageBox.Show("이제 꽃을 만나러 가 볼까요 ??", "잘했어요 !! ");

                    this.Visible = false;
                    EventLast form = new EventLast();
                    form.Close();
                    form.Dispose();
                    form = null;

                    success showsuccess = new success(frm3);
                    showsuccess.ShowDialog();
                }
                else
                {
                    MessageBox.Show("이럴수가 .. 꽃이 떠났어요 ㅠㅠ", "맙소사  ");
                    this.Visible = false;
                    EventLast form = new EventLast();
                    form.Close();
                    form.Dispose();
                    form = null;

                    Bye bye = new Bye(frm3);
                    bye.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("다시 한번 생각 해 볼까요 ?", "아쉬워요 !!");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Control me = sender as Control;
            me.Hide();
        }
    }
}
