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
    public partial class AlmacenarOCRealizadas : Form
    {
        public AlmacenarOCRealizadas()
        {
            InitializeComponent();
        }
        
        private void AlmacenarOCRealizadas_Load(object sender, EventArgs e)
        {
            OdbcConnection conector = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ");
            conector.Open();

            try
            {



                OdbcCommand sentencia = new OdbcCommand();
                sentencia.Connection = conector;
                sentencia.CommandText = "SELECT id_oc from hotelsancarlosv2.ORDENESDECOMPRA";

                OdbcDataAdapter da1 = new OdbcDataAdapter(sentencia);
                DataTable dt = new DataTable();
                da1.Fill(dt);


                comboBox1.ValueMember = "id_oc";
                comboBox1.DisplayMember = "id_oc";

                comboBox1.DataSource = dt;

            }
            catch (OdbcException ex)
            {
                MessageBox.Show("no encntrado. " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string año, mes, dia, fecha;
            año = dateTimePicker1.Value.Year.ToString();
            mes = dateTimePicker1.Value.Month.ToString();
            dia = dateTimePicker1.Value.Day.ToString();
            fecha = año + "/" + mes + "/" + dia;

            string sql = @"SELECT DATEDIFF(fecha_prevista_de_recibido, '" + fecha+ "') FROM `ordenesdecompra` WHERE id_oc = '" + this.comboBox1.Text + "'";
     
            OdbcConnection conector = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ");
            conector.Open();
            OdbcCommand cmd = new OdbcCommand(sql, conector);
            int fecha2 = Convert.ToInt32(cmd.ExecuteScalar());
            int dias = Math.Abs(fecha2);
         
            MessageBox.Show("DIAS:"+dias);

            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into hotelsancarlosv2.controldemoras(id_oc,fecha_entregada,demora) values('" + this.comboBox1.Text + "','" + fecha + "','" + dias + "');";
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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
