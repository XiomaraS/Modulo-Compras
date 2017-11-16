using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antiguedad_de_saldos
{
    public partial class saldos : Form
    {
        public saldos()
        {
            InitializeComponent();
        }

        private void antiguedadDeSaldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientes cl = new clientes();
            cl.MdiParent = this;
            cl.Show();
        }

        private void antiguedadDeSaldosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            proveedores pr = new proveedores();
            pr.MdiParent = this;
            pr.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void porClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opciones op = new opciones();
            op.MdiParent = this;
            op.Show();
        }
    }
}
