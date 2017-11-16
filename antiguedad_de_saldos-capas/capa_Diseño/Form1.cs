using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_Diseño
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void antiguedadDeSaldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientes cl = new clientes();
            cl.Show();
        }

        private void antiguedadDeSaldosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            proveedores pr = new proveedores();
            pr.Show();
        }

        private void porProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
