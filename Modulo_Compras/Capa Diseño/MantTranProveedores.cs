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
    public partial class MantTranProveedores : Form
    {
        public string id;
        public int idApp = 6204;
        public MantTranProveedores()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void MantTranProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                //  string MyConnection2 = "server=localhost;user id=root;database=hotelsancarlosv2";
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver};Dsn=hotelsancarlos; Database=hotelSanCarlos;";
                string Query = "select * from cuentacontabilidad;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
      
                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Cmb_cuenta.DataSource = dTable;
                Cmb_cuenta.ValueMember = "nomenclatura";               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "insert into transacciones_proveedores (id_tranproveedor, descripcion,accion,cod_nomenclatura) values('" + Txt_cod.Text + "','" + Txt_decrip.Text + "','" + Cmb_accion.SelectedItem + "','" + Cmb_cuenta.SelectedValue + "')";
                // string MyConnection2 = "server=localhost;user id=root;database=hotelsancarlosv2";
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver};Dsn=hotelsancarlos; Database=hotelSanCarlos;";

                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                OdbcDataReader myreader1;
                MyConn2.Open();
                myreader1 = MyCommand2.ExecuteReader();
                MessageBox.Show("Save Data");
            }
            catch {
                MessageBox.Show("error de ingreso");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id2 = Convert.ToInt32(id);
            try
            {
                string Query = "UPDATE transacciones_proveedores SET descripcion = '" + Txt_decrip.Text + "', accion ='" + Cmb_accion.SelectedItem + "',cod_nomenclatura ='" + Cmb_cuenta.SelectedValue + "' WHERE id_tranproveedor = '" + id + "'";
              string MyConnection2 = "Dsn=hotelsancarlos; Database=hotelSanCarlos;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader myreader1;
                MyConn2.Open();
                myreader1 = MyCommand2.ExecuteReader();
                MessageBox.Show("Save Data");
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
                string Query = "insert into transacciones_proveedores (id_tranproveedor, descripcion,accion,cod_nomenclatura) values('" + Txt_cod.Text + "','" + Txt_decrip.Text + "','" + Cmb_accion.SelectedItem + "','" + Cmb_cuenta.SelectedValue + "')";
                //  string MyConnection2 = "server=localhost;user id=root;database=hotelsancarlosv2";
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver};Dsn=hotelsancarlos; Database=hotelSanCarlos;;";

                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                OdbcDataReader myreader1;
                MyConn2.Open();
                myreader1 = MyCommand2.ExecuteReader();
                MessageBox.Show("Save Data");
            }
            catch
            {
                MessageBox.Show("error de ingreso");
            }
        }

        private void navegador1_UpdateReceive(object sender, EventArgs e)
        {
            int id2 = Convert.ToInt32(id);
            try
            {
                string Query = "UPDATE transacciones_proveedores SET descripcion = '" + Txt_decrip.Text + "', accion ='" + Cmb_accion.SelectedItem + "',cod_nomenclatura ='" + Cmb_cuenta.SelectedValue + "' WHERE id_tranproveedor = '" + id + "'";
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
