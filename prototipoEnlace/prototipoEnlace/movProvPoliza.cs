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



//Scarlet Menchú elias
//0901-11-4-11608
namespace prototipoEnlace
{
    public partial class movProvPoliza : Form
    {
        public movProvPoliza()
        {
            InitializeComponent();
        }

        string cod_app = "6301";

        //variables globales a utilizar
        string fi, ff;
        int respuesta;
        int debe, haber;
        int poliza;
        string actual, concepto;
        int partida;



        private void button1_Click(object sender, EventArgs e)
        {
            fi = dtp_inicio.Value.ToString("yyyy-MM-dd");
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
            else
            {

                IL();
                MessageBox.Show("Se ha añadido los Datos");
                cleanAll();
                getPoliza();
            }


        }

        //Cambia al Form de Movimientos Proveedores
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 pr = new Form1();
            this.Hide();
            pr.Show();
        

        }


        //Funcion que toma la fecha del dataTimePicker 1 (fecha inicial)
        public void getfi() {
            fi = dtp_inicio.Value.ToString("yyyy-MM-dd");
        }

        

        //Funcion que toma la fecha del dataTimePicker 2 (fecha final)
        public void getff()
        {
            ff = dtp_final.Value.ToString("yyyy-MM-dd");
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void movProvPoliza_Load(object sender, EventArgs e)
        {
            getPoliza();
            txt_codigo.Text = cod_app;
        }

        public void consultarf() {
            string pal = "hola";
            Conex.Conex con = new Conex.Conex(pal);

            try
            {
               
                string sql = "select Id_mov_proveedor from movimientos_proveedor where fecha between '"+fi+"' and '"+ff+"'; ";

                con.OpenConnection();
                respuesta = con.consultarfp(sql);

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



        public void getPoliza()
        {
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


        public void getDetPartida()
        {
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
                else
                {

                    partida = Convert.ToInt32(Reader["id"]);
                }

            }
            con.CloseConnection();

            partida = partida + 1;

        }



        //Aqui se hace
        public void getDebe()
        {


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
            string pal = "hola";
            Conex.Conex con = new Conex.Conex(pal);
            string sql = "select SUM(C.saldo) as total from movimientos_proveedor C, transacciones T where T.accion = '-' and C.cod_transaccion = T.cod_transacciones and fecha between '" + fi + "' and  '" + ff + "'; ";


            con.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con.conn);

            MySqlDataReader Reader = cmd.ExecuteReader();

            if (Reader.Read())
            {
                if (Convert.IsDBNull(Reader["total"]))
                {
                    haber = 0;
                }
                else
                {

                    haber = Convert.ToInt32(Reader["total"]);

                }

            }

            con.CloseConnection();


        }


        public void IB()
        {

            string pal = "hola";
            Conex.Conex con = new Conex.Conex(pal);

            con.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("insert into partida(idPartida,numeroPartida,definicionPartida,total,fecha,estado) values('" + txt_poliza.Text + "',002,'" + txt_concepto.Text + "'," + debe + ",'" + actual + "','" + cmb_estado.Text + "');", con.conn);
            int g;
            g = cmd.ExecuteNonQuery();
            con.CloseConnection();
        }


        //Se ingresaran los datos solo si esta en linea
        public void IL()
        {
            getDetPartida();
            string pal = "hola";
            Conex.Conex con = new Conex.Conex(pal);

            con.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("insert into partida(idPartida,numeroPartida,definicionPartida,total,fecha,estado) values('" + txt_poliza.Text + "',002,'" + txt_concepto.Text + "'," + debe + ",'" + actual + "','" + cmb_estado.Text + "');", con.conn);
            MySqlCommand cmd1 = new MySqlCommand("insert into detallepartida values(" + partida + "," + debe + ",001,'Activo'," + txt_poliza.Text + ");", con.conn);
            int g, h;
            g = cmd.ExecuteNonQuery();
            h = cmd1.ExecuteNonQuery();
            con.CloseConnection();

        }


        public void cleanAll() {
            txt_concepto.Text = " ";
            txt_poliza.Text = " ";
            cmb_estado.Text = " ";
        }


    }
    }
