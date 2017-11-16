using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;


namespace capa_Datos
{
    //CONEXION A LA BASE DE DATOS
    public class cls_conexion
    {
        OdbcConnection con = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; Database=hotelSanCarlos;  ");
        OdbcCommand cmd;
        OdbcDataReader dr;
        OdbcDataAdapter da;
      
        public void conexion()
        {
            try
            {
                con.Open();
                MessageBox.Show("conectado");
            }
            catch (OdbcException ex) {

                MessageBox.Show("No se pudo crear la conexión a la base de datos" + ex.ToString());
            }
        }
        /*public bool comprobacionConexion()
        {
            try
            {
                conexion();

                return true;
            }
            catch (OdbcException ex)
            {
                return false;
            }
        }*/

        //LLENADO DE DATAGRIDVIEW CLIENTES
        public void llenarDGV(String sql, DataGridView dgvclientes)
        {
            //abrir conexion 
            con.Open();
            try
            {
                cmd = new OdbcCommand(sql, con);
                da = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvclientes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar el Datagridview" + ex.ToString());
            }
            //cerrar conexion
            con.Close();
        }

        //LLENAR DATAGRIVIEW PROVEEDORES
        public void llenarDGV1(String sqlp,DataGridView dgvproveedores)
        {
            //abrir conexion 
            con.Open();
            try
            {
                cmd = new OdbcCommand(sqlp, con);
                da = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvproveedores.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar el Datagridview" + ex.ToString());
            }
            //cerrar conexion
            con.Close();
        }
        //public void agregarcol()
        //{
        //    DataGridView dgvclientes = new DataGridView();
        //   // this.Controls.Add(dgvclientes);

        //}
    }
}
