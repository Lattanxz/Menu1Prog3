using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmVisualizar : Form
    {
        public frmVisualizar()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible)
            {
                textBox1.Visible = false;
                btnvisualizar.Text = "Visualizar";
            }
            else
            {
                textBox1.Visible = true;
                btnvisualizar.Text = "Desvisualizar";

            }

        }
    }
}
