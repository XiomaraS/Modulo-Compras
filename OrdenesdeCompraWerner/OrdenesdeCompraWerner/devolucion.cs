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
    public partial class devolucion : Form
    {
        public devolucion()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void devolucion_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ";
                //Display query  
               
                //MessageBox.Show(Convert.ToString(idoc));
                string Query = "SELECT productos.descripcion, productos.precio, ordenesdecompra.cantidad FROM ordenesdecompra, productos WHERE productos.idProducto= ordenesdecompra.idProducto  and ordenesdecompra.id_oc='" + Globales2.oc + "';";
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
            string sql = @"SELECT nombreProveedor FROM proveedores WHERE idProveedores =  '" + Globales2.proveedor + "'";
            string sql2 = @"SELECT direccion FROM proveedores WHERE idProveedores =  '" + Globales2.proveedor + "'";
            string sql3 = @"SELECT representante FROM proveedores WHERE idProveedores =  '" + Globales2.proveedor + "'";
            
            OdbcConnection conector = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ");
            conector.Open();




            OdbcCommand cmd5 = new OdbcCommand(sql, conector);
            OdbcCommand cmd1 = new OdbcCommand(sql2, conector);
            OdbcCommand cmd2 = new OdbcCommand(sql3, conector);
           

            label15.Text = Convert.ToString(sumatoria * sumatoria2);
            label2.Text = Convert.ToString(cmd5.ExecuteScalar());
            label3.Text = Convert.ToString(cmd1.ExecuteScalar());
            label5.Text = Convert.ToString(cmd2.ExecuteScalar());
            label9.Text = Globales2.departamento;
            label17.Text = Convert.ToString(Globales2.nodevo);
            DateTime Hoy = DateTime.Today;
            string fecha_actual = Hoy.ToString("yyyy-MM-dd");
            label16.Text = fecha_actual;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image bmp = null;
            Size sz = this.Size;
            bmp = new Bitmap(sz.Width, sz.Height - 50, PixelFormat.Format32bppRgb);

            Graphics memoryGraphics = Graphics.FromImage(bmp);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, sz,
                                          CopyPixelOperation.SourceCopy);

            bmp.Save("DEVOLUCION.bmp", ImageFormat.Bmp);

            this.Hide();
        }
    }
}
