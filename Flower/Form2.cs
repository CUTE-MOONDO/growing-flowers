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
    
    public partial class Form2 : Form
    {
        public static string bname;
        public static Image baby;
        public static string flowerName;
        public Form2()
        {
            InitializeComponent();

        }

        
        private void seed_Click(object sender, EventArgs e)
        {
            Control name = sender as Control;
            select.Load(@"C:\Users\두루미\폼2\캐씨앗\"+name.Name+".png");
            flowerName = Convert.ToString(name.Name);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (select.Image != null && (nameBox.Text != "이름" && nameBox.Text != null))
            {
                bname = nameBox.Text;
                baby = select.Image;
                this.Visible = false;

                Form2 form = new Form2();
                form.Close();
                form.Dispose();
                form = null;

                Form3 showForm3 = new Form3();
                showForm3.ShowDialog();
            }
            else
            {
                MessageBox.Show("씨앗 고르기와 닉네임 정하기를 완료해주세요 ! ", "앗 안돼요 !");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
