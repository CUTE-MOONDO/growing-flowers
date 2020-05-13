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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           panel1.Hide();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            
            Form2 showForm2 = new Form2();
            showForm2.ShowDialog();
            

            /*
            Event2_1 ss = new Event2_1();
            ss.ShowDialog();
            */


        }

        private void how(object sender, EventArgs e)
        {
            panel1.Show();
        }
        private void dhow(object sender, EventArgs e)
        {
           panel1.Hide();
        }
    }
}
