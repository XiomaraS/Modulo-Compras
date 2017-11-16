using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Drawing.Imaging;

namespace OrdenesdeCompraWerner
{
    public partial class CapturaOrden : Form
    {
        public CapturaOrden()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void CapturaOrden_Load(object sender, EventArgs e)
        {
           


           
            try
            {
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ";
                //Display query  
                int idoc = Globales.oc ;
                //MessageBox.Show(Convert.ToString(idoc));
                string Query = "SELECT productos.descripcion, productos.precio, ordenesdecompra.cantidad FROM ordenesdecompra, productos WHERE productos.idProducto= ordenesdecompra.idProducto  and ordenesdecompra.id_oc='" + idoc + "';";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                 // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            double sumatoria = 0;
            double sumatoria2 = 0;
           
            //Método con el que recorreremos todas las filas de nuestro Datagridview
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //Aquí seleccionaremos la columna que contiene los datos numericos.
                sumatoria += Convert.ToDouble(row.Cells["Cantidad"].Value);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //Aquí seleccionaremos la columna que contiene los datos numericos.
                sumatoria2 += Convert.ToDouble(row.Cells["precio"].Value);
            }
            //Por ultimo asignamos el resultado a el texto de nuestro Label

           label15.Text = Convert.ToString(sumatoria*sumatoria2);
            label2.Text = Globales.proveedor;
            label3.Text = Globales.direccion;
            label5.Text = Globales.representante;
            label9.Text = Globales.departamento;
            DateTime Hoy = DateTime.Today;
            string fecha_actual = Hoy.ToString("yyyy-MM-dd");
            label16.Text = fecha_actual;
            label17.Text = Convert.ToString(Globales.oc);

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            Image bmp = null;
                Size sz = this.Size;
                bmp = new Bitmap(sz.Width, sz.Height-50, PixelFormat.Format32bppRgb);
                
                Graphics memoryGraphics = Graphics.FromImage(bmp);
                memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, sz,
                                              CopyPixelOperation.SourceCopy);

                bmp.Save("ORDEN DE COMPRA.bmp", ImageFormat.Bmp);

            this.Hide();
        }
    }
}
