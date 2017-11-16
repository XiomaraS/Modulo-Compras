using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Proveedores1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingreso newMDIChild = new ingreso();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovProveedores newMDIChild = new MovProveedores();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TranProveedores newMDIChild = new TranProveedores();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void reporteMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporte rpt = new reporte();
            rpt.Show();
        }

        private void reporteTransaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportTran rpt = new ReportTran();
            rpt.Show();
        }
    }
}
