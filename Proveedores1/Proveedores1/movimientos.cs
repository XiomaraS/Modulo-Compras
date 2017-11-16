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
    public partial class movimientos : Form
    {
        public string id, id2;
        public int idApp = 6202;
        public movimientos()
        {
            InitializeComponent();
        }

        private void movimientos_Load(object sender, EventArgs e)
        {
         
            try
            {
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=bd_hotel; UID=root; PWD=;";
               // string MyConnection2 = "server=localhost;user id=root;database=hotelsancarlosv2";
                string Query = "select * from proveedores;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);

                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Cmb_prov.DataSource = dTable;
                Cmb_prov.ValueMember = "idProveedores";
                Cmb_nomprov.DataSource = dTable;
                Cmb_nomprov.ValueMember = "nombreProveedor";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=bd_hotel; UID=root; PWD=;";
                //string MyConnection2 = "server=localhost;user id=root;database=hotelsancarlosv2";
                string Query = "select * from transacciones_proveedores;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);

                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Cmb_codTran.DataSource = dTable;
                Cmb_codTran.ValueMember = "id_tranproveedor";
                Cmb_nom.DataSource = dTable;
                Cmb_nom.ValueMember = "descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        string action;
        double total;
        double dato_accion;
        double total_resta;
        double total_suma;

        private void button1_Click(object sender, EventArgs e)
        {
            string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=bd_hotel; UID=root; PWD=;";
            int codigo = Convert.ToInt32(Cmb_codTran.Text.ToString());
            total = Convert.ToDouble(Txt_saldo.Text);
            dato_accion = Convert.ToDouble(Txt_pago.Text);

            string formateddate = fecha_ingreso.Value.ToString("yyyyMMdd");
            string formateddate2 = fecha_venc.Value.ToString("yyyyMMdd");
            OdbcConnection MyConn2; OdbcCommand MyCommand2; OdbcDataReader MyReader2;
            string Query3 = "select accion from transacciones_proveedores where id_tranproveedor =" + codigo + ";";
            OdbcConnection MyConn3 = new OdbcConnection(MyConnection2);
            OdbcCommand MyCommand3 = new OdbcCommand(Query3, MyConn3);
            MyConn3.Open();
            OdbcDataReader reader = MyCommand3.ExecuteReader();

            if (reader.Read())
            {
                action = (string)reader["accion"];
            }

            reader.Close();

            MyConn3.Close();

            if (action == "suma")
            {
                total_suma = total + dato_accion;
                string Query1 = "insert into movimientos_proveedor (cod_transaccion,id_proveedor,total_pago,saldo,saldo_actual,fecha,fecha_vencimiento)values('" + Cmb_codTran.SelectedValue + "','" + Cmb_prov.SelectedValue + "','" + Convert.ToInt32(Txt_pago.Text) + "','" + Convert.ToInt32(Txt_saldo.Text) + "','"+total_suma+"','" + formateddate + "','" + formateddate2 + "')";
                MyConn2 = new OdbcConnection(MyConnection2);
                MyCommand2 = new OdbcCommand(Query1, MyConn2);
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Datos Ingresados Exitosamente");
             
            }
            else if (action == "resta")
            {
                if (dato_accion > total)
                {
                    MessageBox.Show("Ingresar una cantidad menor al saldo");
                }
                else
                {
                    total_resta = total - dato_accion;
                    string Query2 = "insert into movimientos_proveedor (cod_transaccion,id_proveedor,total_pago,saldo,saldo_actual,fecha,fecha_vencimiento)values('" + Cmb_codTran.SelectedValue + "','" + Cmb_prov.SelectedValue + "','" + Convert.ToInt32(Txt_pago.Text) + "','" + Convert.ToInt32(Txt_saldo.Text) + "','"+total_resta+"','" + formateddate + "','" + formateddate2 + "')";
                    MyConn2 = new OdbcConnection(MyConnection2);
                    MyCommand2 = new OdbcCommand(Query2, MyConn2);
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Datos Ingresados Exitosamente");
                 
                }
            }
            else
            {
                MessageBox.Show("La accion de la transaccion es incorrecto.");
            }
        }

        private void navegador1_InsertReceive(object sender, EventArgs e)
        {
            string formateddate = fecha_ingreso.Value.ToString("yyyyMMdd");
            string formateddate2= fecha_venc.Value.ToString("yyyyMMdd");
            try
            {
                string Query = "insert into movimientos_proveedor (cod_transaccion,id_proveedor,total_pago,saldo,saldo_actual,fecha,fecha_vencimiento)values('" + Cmb_codTran.SelectedValue + "','" + Cmb_prov.SelectedValue + "','" + Convert.ToInt32(Txt_pago.Text) + "','" + Convert.ToInt32(Txt_saldo.Text) + "',0,'" + formateddate + "','" + formateddate2 + "')";
                //string MyConnection2 = "server=localhost;user id=root;database=hotelsancarlosv2";
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=bd_hotel; UID=root; PWD=;";

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

        private void navegador1_UpdateReceive(object sender, EventArgs e)
        {
            int id2 = Convert.ToInt32(id);
            string date = fecha_ingreso.Value.ToString("yyyyMMdd");
            try
            {
                string Query = "UPDATE movimientos_proveedor SET cod_transaccion = '" + Cmb_codTran.SelectedValue + "', id_proveedor ='" + Cmb_prov.SelectedValue + "',total_pago ='" + Convert.ToInt32(Txt_pago.Text) + "', saldo = '" + Convert.ToInt32(Txt_saldo.Text) + "',fecha ='" + date + "' WHERE Id_mov_proveedor = '" + id + "'";
                //string MyConnection2 = "server=localhost;user id=root;database=hotelsancarlosv2";
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=bd_hotel; UID=root; PWD=;";

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

        private void button2_Click(object sender, EventArgs e)
        {
           int id2 = Convert.ToInt32(id);
            string date = fecha_ingreso.Value.ToString("yyyyMMdd");
            try
            {
                string Query = "UPDATE movimientos_proveedor SET Transacciones_cod_transacciones = '" + Cmb_codTran.SelectedValue + "', proveedores_idProveedores ='" + Cmb_prov.SelectedValue + "',total_pago ='" + Convert.ToInt32(Txt_pago.Text) + "', saldo = '" + Convert.ToInt32(Txt_saldo.Text) + "',fecha ='" + date + "' WHERE Id_mov_proveedor = '" + id + "'";
                //string MyConnection2 = "server=localhost;user id=root;database=hotelsancarlosv2";
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=bd_hotel; UID=root; PWD=;";

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
