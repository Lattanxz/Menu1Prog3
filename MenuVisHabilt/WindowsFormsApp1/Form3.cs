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
    public partial class frmHabilitar : Form
    {
        public frmHabilitar()
        {
            InitializeComponent();
        }

        private void frmHabilitar_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Enabled)
            {
                textBox1.Enabled= false;
                btnHabilitar.Text = "Deshabilitar";
            }
            else
            {
                textBox1.Enabled = true;
                btnHabilitar.Text = "Habilitar";
            }

        }
    }
}
