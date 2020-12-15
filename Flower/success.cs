using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flower
{
    public partial class success : Form
    {
        Form3 frm3;
        public success()
        {
            InitializeComponent();
        }
        public success(Form3 _form)
        {
            InitializeComponent();
            frm3 = _form;
        }

        private void success_Load(object sender, EventArgs e)
        {
            now.Text = frm3.now.Text;
            lolo.Text = Convert.ToString(frm3.love);
            re.Parent = pictureBox1;
            chap.Parent = pictureBox1;
            nnow.Parent = pictureBox1;
            ff.Parent = pictureBox1;
            panel2.Parent = pictureBox1;
            pictureBox2.Load(@"C:\Users\두루미\성공\pop\" + Form2.flowerName + ".png");
            pictureBox2.Hide();

            ff.Load(@"C:\Users\두루미\성공\" + Form2.flowerName + ".png");
        }

        private void more(object sender, EventArgs e)
        {
            pictureBox2.Show();
        }
        private void dmore(object sender, EventArgs e)
        {
            pictureBox2.Hide();
        }

        private void chap_Click(object sender, EventArgs e)
        {
            ScreenCopy.Copy("game.png");
        }
        public class ScreenCopy
        {
            public static void Copy(string outputFilename)
            {
                // 주화면의 크기 정보 읽기
                Rectangle rect = Screen.PrimaryScreen.Bounds;

                // 픽셀 포맷 정보 얻기 (Optional)
                int bitsPerPixel = Screen.PrimaryScreen.BitsPerPixel;
                PixelFormat pixelFormat = PixelFormat.Format32bppArgb;
                if (bitsPerPixel <= 16)
                {
                    pixelFormat = PixelFormat.Format16bppRgb565;
                }
                if (bitsPerPixel == 24)
                {
                    pixelFormat = PixelFormat.Format24bppRgb;
                }

                // 화면 크기만큼의 Bitmap 생성
                Bitmap bmp = new Bitmap(rect.Width, rect.Height, pixelFormat);

                // Bitmap 이미지 변경을 위해 Graphics 객체 생성
                using (Graphics gr = Graphics.FromImage(bmp))
                {
                    // 화면을 그대로 복사해서 Bitmap 메모리에 저장
                    gr.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size);
                }
                // Bitmap 을 파일로 저장
                bmp.Save(outputFilename);
                bmp.Dispose();
                MessageBox.Show("프로그램 폴더에 저장되었습니다 ! ", "♥저장 완료♥");
            }
        }

        private void re_Click(object sender, EventArgs e)
        {
            frm3.Visible = false;
            frm3.Close();
            frm3.Dispose();
            frm3 = null;

            success form = new success();
            this.Visible = false;

            form.Close();
            form.Dispose();
            form = null;


        }

        private void success_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm3.Visible = false;
            frm3.Close();
            frm3.Dispose();
            frm3 = null;

            success form = new success();
            this.Visible = false;

            form.Close();
            form.Dispose();
            form = null;
        }
    }
}