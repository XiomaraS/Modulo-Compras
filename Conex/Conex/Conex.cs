using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Conex
{
    public class Conex
    {
        public MySqlConnection conn;
        private String connStr;
        private int ans;
        /*Create a constructor*/
        public Conex(String coonection)
        {
            this.connStr = coonection;
        }


        /*Open a connection*/

        public bool OpenConnection()
        {
            try
            {
                conn = new MySqlConnection("datasource = localhost; database = hotelSanCarlos; username = root; password =");
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                /*Error of connection*/
                return false;
            }



        }



        /*Close the connection*/
        public bool CloseConnection()
        {

            try
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                return true;


            }
            catch (MySqlException ex)
            {
                return false;
            }


        }


        public DataTable llenarDataGridView(String sentencia)
        {

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sentencia, connStr);
            da.Fill(dt);

            return dt;

        }


        public void Insertar(String sentencia)
        {
            string insertquery = sentencia;
            MySqlCommand command = new MySqlCommand(insertquery, conn);
            command.ExecuteNonQuery();

        }

        public void Actualizar(String sentencia)
        {
            string insertquery = sentencia;
            MySqlCommand command = new MySqlCommand(insertquery, conn);
            command.ExecuteNonQuery();

        }

        public void Borrar(String sentencia)
        {
            string insertquery = sentencia;
            MySqlCommand command = new MySqlCommand(insertquery, conn);
            command.ExecuteNonQuery();

        }


        public int consultarfc(String sentencia) {
            string consult = sentencia;
            MySqlCommand cmd = new MySqlCommand(consult, conn);

            MySqlDataReader Reader = cmd.ExecuteReader();
          

            if (Reader.Read())
            {
                ans = Convert.ToInt32(Reader["Id_mov_cliente"]);
            }
        

            return ans;

        }


        public int consultarfp(String sentencia)
        {
            string consult = sentencia;
            MySqlCommand cmd = new MySqlCommand(consult, conn);

            MySqlDataReader Reader = cmd.ExecuteReader();


            if (Reader.Read())
            {
                ans = Convert.ToInt32(Reader["Id_mov_proveedor"]);
            }


            return ans;

        }


        public int prueba(String sentencia)
        {
            string consult = sentencia;
            MySqlCommand cmd = new MySqlCommand(consult, conn);

            MySqlDataReader Reader = cmd.ExecuteReader();


            if (Reader.Read())
            {
                ans = Convert.ToInt32(Reader["Id_mov_cliente"]);
            }


            return ans;

        }

    }
}
