using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proveedores1;
using prototipoEnlace;
using OrdenesdeCompraWerner;
using Movimientos_clientes;
using capa_Diseño;
using CapaDiseño;
using CapaLogica;
using CapaDatos;
using capa_Datos;
using capa_logica;


namespace Modulo_Compras
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
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

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TranProveedores newMDIChild = new TranProveedores();
            // Set the Parent Form of the Child window.
            //newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void transaccionesClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vision_trans trans = new Vision_trans();
            //trans.MdiParent = this;
            trans.Show();
        }

        private void movimientoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vision_movs vision = new Vision_movs();
           // vision.MdiParent = this;
            vision.Show();
        }

       /* private void reporteDeSaldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Saldos RS = new Reporte_Saldos();
            RS.Show();
        }

        private void reporteDeTransaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Transacciones_C trans_report = new Reporte_Transacciones_C();
            trans_report.Show();
        }*/

        private void generarOrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarOC F1 = new GenerarOC();
            F1.Show();
        }

        private void almacenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlmacenarOCRealizadas f6 = new AlmacenarOCRealizadas();
            f6.Show();
        }

        private void verOrdenesDeComprasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ver_solicitudes f2 = new Ver_solicitudes();
            f2.Show();
        }

        private void controlDeDemorasDeOrdenesDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlDemora f5 = new ControlDemora();
            f5.Show();
        }

        private void trasladoDeMovimientoClienteAPolizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movProvPoliza mp = new movProvPoliza();
            mp.Show();
        }

        private void trasladoDeMovimientoProveedoresAPolizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movProvPoliza mpp = new movProvPoliza();
            mpp.Show();
        }

        private void antiguedadDeSaldosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clientes cl = new clientes();
            cl.Show();
        }

        private void antiguedadDeSaldosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            proveedores pr = new proveedores();
            pr.Show();
        }

        private void condensadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
