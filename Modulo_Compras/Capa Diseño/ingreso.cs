using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllconnectionDatabase;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace Proveedores1
{
    public partial class ingreso : Form
    {
        public int idApp = 6200;
        public ingreso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      //      string hola = "holi";
            string Query = "insert into proveedores (nombreProveedor,direccion,representante,nit_proveedor) values('" + TxtNombre.Text + "','" + TxtCalle.Text + "','" + TxtRepre.Text + "','" + TxtNit.Text + "')";
//     string Query = "insert into proveedores (idProveedores,nombreProveedor) values(3,'"+TxtNombre.Text+"')";

            string MyConnection2 = "Dsn=hotelsancarlos; Database=hotelSanCarlos;";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader myreader1;
            MyConn2.Open();
            myreader1 = MyCommand2.ExecuteReader();


        }

        private void ingreso_Load(object sender, EventArgs e)
        {
            try
            {
                //string MyConnection2 = "server=localhost;user id=root;database=hotelsancarlosv2";
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver};Dsn=hotelsancarlos; Database=hotelSanCarlos;";
                string Query = "select * from proveedores ;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);

                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Dgv_Prov.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navegador1_InsertReceive(object sender, EventArgs e)
        {
            try
            {
                string Query = "insert into proveedores (nombreProveedor,direccion,representante,nit_proveedor) values('" + TxtNombre.Text + "','" + TxtCalle.Text + "','" + TxtRepre.Text + "','" + TxtNit.Text + "')";
                //     string Query = "insert into proveedores (idProveedores,nombreProveedor) values(3,'"+TxtNombre.Text+"')";
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=hotelsancarlos; Database=hotelSanCarlos;";
                //    string MyConnection2 = "server=localhost;user id=root;database=hotelsancarlosv2";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                OdbcDataReader myreader1;
                MyConn2.Open();
                myreader1 = MyCommand2.ExecuteReader();
                MessageBox.Show("Save Data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            String stringpad = "Dsn=hotelsancarlos; Database=hotelSanCarlos;";
            dllconnectionDatabase.dllconnectionDatabase connection = new dllconnectionDatabase.dllconnectionDatabase(stringpad);
            connection.OpenConnection();
            Dgv_Prov.DataSource = connection.llenarDataGridView("select * from proveedores");

            connection.CloseConnection();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Dgv_Prov_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Dgv_Prov_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtNombre.Text = Dgv_Prov.CurrentRow.Cells[1].Value.ToString();
            TxtCalle.Text = Dgv_Prov.CurrentRow.Cells[2].Value.ToString();
            TxtRepre.Text = Dgv_Prov.CurrentRow.Cells[3].Value.ToString();
            TxtNit.Text = Dgv_Prov.CurrentRow.Cells[4].Value.ToString();

        }

        private void navegador1_UpdateReceive(object sender, EventArgs e)
        {
            string id = Dgv_Prov.CurrentRow.Cells[0].Value.ToString();
           try
            {
                string Query = "UPDATE proveedores SET nombreProveedor = '" + TxtNombre.Text+ "', direccion ='" + TxtCalle.Text + "',representante ='" + TxtRepre.Text + "', nit = '" + TxtNit.Text + "' WHERE idProveedores = '" +Convert.ToInt32(id) + "'";
                //string MyConnection2 = "server=localhost;user id=root;database=hotelsancarlosv2";
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=hotelsancarlos; Database=hotelSanCarlos;";

                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                OdbcDataReader myreader1;
                MyConn2.Open();
                myreader1 = MyCommand2.ExecuteReader();
                MessageBox.Show("Save Data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
