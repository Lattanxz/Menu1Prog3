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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ssssToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuHabilitar_Click(object sender, EventArgs e)
        {
            frmHabilitar frm = new frmHabilitar();
            frm.Show();
        }

        private void mnuVisualizar_Click(object sender, EventArgs e)
        {
             frmVisualizar frm = new frmVisualizar();
            frm.Show();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
