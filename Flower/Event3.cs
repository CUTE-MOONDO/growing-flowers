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
    public partial class Event3 : Form
    {
        Form3 frm3;
        Image image;
        Bitmap clear, original;
        Random r = new Random();
        int X, Y,count = 0;
        
        public Event3()
        {
            InitializeComponent();
        }
        public Event3(Form3 _form)
        {
            InitializeComponent();
            frm3 = _form;
        }

        private void Event3_Load(object sender, EventArgs e)//로드
        {   
            int x = pictureBox1.Width;
            int y = pictureBox1.Height;
            string here = @"C:\Users\문다솔\Desktop\두루미\폼4\" + Form2.flowerName + ".png";
            image =Image.FromFile(here);
            original = new Bitmap(image, x, y);
            pictureBox1.Image=original;
            X = x / 3;
            Y = y / 3;
            mp();

          //실사꽃 퍼즐맞추기
            
        }

        private void mp()
        {
            Point[] p = new Point[9];


            for (int i = 0; i < p.Length; i++)
            {
                int xx = r.Next(508, 904); //나눈것 분산시킬위치 생성
                int yy = r.Next(291, 420);
                p[i] = new Point(xx, yy);
            }
            int a = 0, b = 0;
            for(int i = 0; i<3; i++){                           //적용
                for (int j = 0; j < 3; j++)
                {
                    Rectangle one = new Rectangle(a, b, X, Y);
                    PictureBox pic = new PictureBox();

                    pic.Location = p[count];
                    pic.Width = X;
                    pic.Height = Y;
                    pic.Image = cropAtRect(original, one);
                    a = a + X;
                }
                count++;
                 b = b + Y;
            }
        }

        public static Bitmap cropAtRect(this Bitmap b, Rectangle r)
        {
            Bitmap nb = new Bitmap(r.Width, r.Height);
            Graphics g = Graphics.FromImage(nb);
            g.DrawImage(b, -r.X, -r.Y);
            return nb;
        }
     }  
}
