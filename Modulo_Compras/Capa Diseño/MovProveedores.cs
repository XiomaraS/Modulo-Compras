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
using CrystalDecisions.CrystalReports.Engine;
namespace Proveedores1
{
    public partial class MovProveedores : Form
    {
        public int idApp = 6201;
        public int id;
        public string id2;
        public MovProveedores()
        {
            InitializeComponent();
        }

        private void MovProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                //string MyConnection2 = "server=localhost;user id=root;database=hotelsancarlosv2";
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=hotelsancarlos; Database=hotelSanCarlos;";
                string Query = "select * from movimientos_proveedor ;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);

                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Dgv_movProv.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movimientos mov = new movimientos();
            mov.Show();
            this.Close();
        }

        private void Dgv_movProv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            movimientos mov = new movimientos();
            string id2, id;
            mov.id =Dgv_movProv.CurrentRow.Cells[0].Value.ToString();
            mov.Txt_saldo.Text = Dgv_movProv.CurrentRow.Cells[4].Value.ToString();
            mov.Txt_pago.Text = Dgv_movProv.CurrentRow.Cells[3].Value.ToString();
            id2 = Dgv_movProv.CurrentRow.Cells[2].Value.ToString();
           id = Dgv_movProv.CurrentRow.Cells[1].Value.ToString();
            mov.Txt_saldo.Enabled = false;
            mov.Show();

            try
            {
                //string MyConnection2 = "server=localhost;user id=root;database=hotelsancarlosv2";
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver};Dsn=hotelsancarlos; Database=hotelSanCarlos;";
                string Query = "select * from proveedores where idProveedores ='"+Convert.ToInt32( id2)+"' ;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);

                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                mov.Cmb_prov.DataSource = dTable;
                mov.Cmb_prov.ValueMember = "idProveedores";
                mov.Cmb_nomprov.DataSource = dTable;
                mov.Cmb_nomprov.ValueMember = "nombreProveedor";
                mov.Cmb_nomprov.Enabled = false;
                mov.Cmb_prov.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                //string MyConnection2 = "server=localhost;user id=root;database=hotelsancarlosv2";
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=bd_hotel; UID=root; PWD=;";
                string Query = "select * from transacciones_proveedores where id_tranproveedor ='" + Convert.ToInt32(id) + "' ;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);

                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                mov.Cmb_codTran.DataSource = dTable;
                mov.Cmb_codTran.ValueMember = "id_tranproveedor";
                mov.Cmb_nom.DataSource = dTable;
                mov.Cmb_nom.ValueMember = "descripcion";
                mov.Cmb_codTran.Enabled = false;
                mov.Cmb_nom.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Dgv_movProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          /*  reporte rpt = new reporte();
            rpt.Show();*/
        }
    }
}
