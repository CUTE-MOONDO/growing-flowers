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
    public partial class Bye : Form
    {
        Form3 frm3;
        public Bye()
        {
            InitializeComponent();
        }

        public Bye(Form3 _form)
        {
            InitializeComponent();
            frm3 = _form;
        }

        private void Bye_Load(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm3.Visible = false;
            frm3.Close();
            frm3.Dispose();
            frm3 = null;

            Bye form = new Bye();
            this.Visible = false;

            form.Close();
            form.Dispose();
            form = null;
        }
    }
}
