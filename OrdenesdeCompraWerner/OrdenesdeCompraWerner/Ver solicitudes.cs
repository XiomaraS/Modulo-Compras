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
namespace OrdenesdeCompraWerner
{
    public partial class Ver_solicitudes : Form
    {
        string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ";

        public Ver_solicitudes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ver_solicitudes_Load(object sender, EventArgs e)
        {

            try
            {

                //Display query  
                string Query = "select * from hotelsancarlosv2.ordenesdecompra";
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globales2.oc = Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            Globales2.proveedor = Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value);
            Globales2.departamento = Convert.ToString(dataGridView1[4, dataGridView1.CurrentRow.Index].Value);
            
            try
            {

                //Display query  
                string Query = "select idcontroldevolucion FROM hotelsancarlosv2.controldevolucion ";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Globales2.nodevo = Convert.ToInt32(dTable.Rows.Count);
                Globales2.nodevo++;// MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string descripcion = "devolucion al proveedor: ";
            descripcion += Globales2.proveedor;
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into hotelsancarlosv2.controldevolucion(`idcontroldevolucion`,`id_oc`,`devoluacion_autorizada`,`descripcion`) values('" + Globales2.nodevo + "','" + Globales2.oc + "','1','" + descripcion + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                OdbcDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("DATOS GUARDADOS");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            devolucion F4 = new devolucion();
            F4.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            string Query = "select * from hotelsancarlosv2.ordenesdecompra WHERE id_oc  LIKE  '" + this.textBox1.Text + "'";


            OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
            OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
            //  MyConn2.Open();  
            //For offline connection we weill use  MySqlDataAdapter class.  
            OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }
    }
}
