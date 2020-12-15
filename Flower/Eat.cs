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
    public partial class Eat : Form
    {
        string bname = Form2.bname;
        public bool count = true;
        string eat = Form3.eat;
        public Eat()
        {
            InitializeComponent();
        }

        private void Eat_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            timer_Tick(sender, e);
            timer.Interval = 1500; //스케쥴 간격을 5초로 준 것이다. // 개발 기간만 1.5초로 조정
            timer.Start(); //타이머를 발동시킨다.


            int nan = r.Next(0, 13);
            pictureBox1.Load(@"C:\Users\두루미\움짤\" + eat + nan + ".gif");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (count == true)
            {
                count = false;
            }
            else
            {
                timer.Stop();
                this.Visible = false;
                Eat form = new Eat();
                form.Close();
                form.Dispose();
                form = null;
            }

        }
        
    }
}
