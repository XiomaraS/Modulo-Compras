using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conex;
using MySql.Data.MySqlClient;
using System.Data.Odbc;



//Scarlet Menchú elias
//0901-11-4-11608

namespace prototipoEnlace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        //CODIGO DE APLICACION
        string cod_app = "6300";



        //Variables Globales
        string fi, ff, actual, concepto;
        int respuesta;
        int debe, haber;
        int poliza;
        int partida;
   

        private void label4_Click(object sender, EventArgs e)
        {

        }


        //Prueba de Conexion a BD
        private void button1_Click(object sender, EventArgs e)
        {


            fi = dtp_inicial.Value.ToString("yyyy-MM-dd");
            ff = dtp_final.Value.ToString("yyyy-MM-dd");
            actual = dtp_actual.Value.ToString("yyyy-MM-dd");
            concepto = txt_codigo.Text;

            getDebe();
            getHaber();

            if (cmb_estado.Text == "Batch")
            {
                IB();
                MessageBox.Show("Se ha añadido los Datos");
                cleanAll();
                getPoliza();
            }
            else {

                IL();
                MessageBox.Show("Se ha añadido los Datos");
                cleanAll();
                getPoliza();
            }



        }



        //Mostrar Movimiento de Proveedores
        private void button2_Click(object sender, EventArgs e)
        {
            movProvPoliza pr = new movProvPoliza();
            this.Hide();
            pr.Show();
        }


        //Funcion que toma la fecha del dataTimePicker 1 (fecha inicial)
        public void getfi()
        {
            fi = dtp_inicial.Value.ToString("yyyy-MM-dd");
        }


        //Funcion que toma la fecha del dataTimePicker 2 (fecha final)
        public void getff()
        {
            ff = dtp_final.Value.ToString("yyyy-MM-dd");
        }

        public void consultarf()
        {
            string pal = "hola";
            Conex.Conex con = new Conex.Conex(pal);

            try
            {

                //string sql = "select Id_mov_cliente from movimientos_cliente where fecha between '" + fi + "' and '" + ff + "'; ";
                String sql = "select Id_mov_cliente from movimientos_cliente where fecha = '2017-01-15'";
                con.OpenConnection();
                respuesta = con.prueba(sql);

                MessageBox.Show("Estas son los id" + respuesta);


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.CloseConnection();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getPoliza();
            txt_codigo.Text = cod_app;
        }

        public void getPoliza() {
            string pal = "hola";
            Conex.Conex con = new Conex.Conex(pal);

            con.OpenConnection();
            string sql = "select MAX(idPartida) as id from Partida;";
            MySqlCommand com = new MySqlCommand(sql, con.conn);


            MySqlDataReader Reader = com.ExecuteReader();

            if (Reader.Read())
            {
                poliza = Convert.ToInt32(Reader["id"]);

            }
            con.CloseConnection();

            poliza = poliza + 1;

            txt_poliza.Text = Convert.ToString(poliza);


        }


        public void getDetPartida() {
            string pal = "hola";
            Conex.Conex con = new Conex.Conex(pal);

            con.OpenConnection();
            string sql = "select MAX(numeroDetallePartida) as id from detallepartida;";
            MySqlCommand com = new MySqlCommand(sql, con.conn);


            MySqlDataReader Reader = com.ExecuteReader();

            if (Reader.Read())
            {

                if (Convert.IsDBNull(Reader["id"]))
                {
                    partida = 1;
                }
                else {

                    partida = Convert.ToInt32(Reader["id"]);
                }

            }
            con.CloseConnection();

            partida = partida + 1;

        }



        //Aqui se hace
        public void getDebe() {


            string pal = "hola";
            Conex.Conex con = new Conex.Conex(pal);
            string sql = "select SUM(C.saldo) as total from movimientos_cliente C, transacciones T where T.accion = '+' and C.cod_transaccion = T.cod_transacciones and fecha between '" + fi + "' and  '" + ff + "'; ";


            con.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con.conn);

            MySqlDataReader Reader = cmd.ExecuteReader();

            if (Reader.Read())
            {
                if (Convert.IsDBNull(Reader["total"]))
                {
                    debe = 0;
                }
                else
                {

                    debe = Convert.ToInt32(Reader["total"]);

                }

            }

            con.CloseConnection();

        }


        public void getHaber()
        {
            bool veri;
            string pal = "hola";
            Conex.Conex con = new Conex.Conex(pal);
            string sql = "select SUM(C.saldo) as total from movimientos_cliente C, transacciones T where T.accion = '-' and C.cod_transaccion = T.cod_transacciones and fecha between '" + fi + "' and  '" + ff + "'; ";


            con.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con.conn);

            MySqlDataReader Reader = cmd.ExecuteReader();

            if (Reader.Read())
            {

                if (Convert.IsDBNull(Reader["total"]))
                {
                    haber = 0;
                }
                else {
                    
                    haber = Convert.ToInt32(Reader["total"]);

                }
            }

            con.CloseConnection();

        }


        // Se ingresaran los datos solo si esta en batch
        public void IB() {

            string pal = "hola";
            Conex.Conex con = new Conex.Conex(pal);

            con.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("insert into partida(idPartida,numeroPartida,definicionPartida,total,fecha,estado) values('"+poliza+"',002,'"+txt_concepto.Text+"',"+debe+",'"+actual+"','"+cmb_estado.Text+"');", con.conn);
            int g;
            g = cmd.ExecuteNonQuery();
            con.CloseConnection();
        }


        //Se ingresaran los datos solo si esta en linea
        public void IL() {
            getDetPartida();
            string pal = "hola";
            Conex.Conex con = new Conex.Conex(pal);

            con.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("insert into partida(idPartida,numeroPartida,definicionPartida,total,fecha,estado) values('" + poliza + "',002,'" + txt_concepto.Text + "'," + debe + ",'" + actual + "','" + cmb_estado.Text + "');", con.conn);
            MySqlCommand cmd1 = new MySqlCommand("insert into detallepartida values(" + partida + ","+debe+",001,'Activo'," + poliza + ");", con.conn);
            int g,h;
            g = cmd.ExecuteNonQuery();
            h = cmd1.ExecuteNonQuery();
            con.CloseConnection();

        }



        public void cleanAll()
        {
            txt_concepto.Text = " ";
            txt_poliza.Text = " ";
            cmb_estado.Text = " ";

        }
    }

}

