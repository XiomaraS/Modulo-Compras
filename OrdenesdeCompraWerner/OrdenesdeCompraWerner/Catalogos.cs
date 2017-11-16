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
    public partial class Catalogos : Form
    {
        string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ";

        public Catalogos()
        {
            InitializeComponent();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           
                string sql = @"SELECT precio FROM productos WHERE idProducto =  '" + comboBox3.Text+ "'";
            string sql2 = @"SELECT descripcion FROM productos WHERE idProducto =  '" + comboBox3.Text + "'";

            OdbcConnection conector = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ");
            conector.Open();




            OdbcCommand cmd = new OdbcCommand(sql, conector);
            int suma = Convert.ToInt32(cmd.ExecuteScalar());


            textBox3.Text = suma.ToString();

            OdbcCommand cmd2 = new OdbcCommand(sql2, conector);

            string hola= Convert.ToString(cmd2.ExecuteScalar());

            textBox4.Text = hola;




        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Catalogos_Load(object sender, EventArgs e)
        {
            OdbcConnection conector = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ");
            conector.Open();

            try
            {



                OdbcCommand sentencia = new OdbcCommand();
                sentencia.Connection = conector;
                sentencia.CommandText = "SELECT * from hotelsancarlosv2.departamento";

                OdbcDataAdapter da1 = new OdbcDataAdapter(sentencia);
                DataTable dt = new DataTable();
                da1.Fill(dt);


                comboBox1.ValueMember = "nombreDepartamento";
                comboBox1.DisplayMember = "nombreDepartamento";

                comboBox1.DataSource = dt;
               
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("no encntrado. " + ex);
            }
            try
            {



                OdbcCommand sentencia = new OdbcCommand();
                sentencia.Connection = conector;
                sentencia.CommandText = "SELECT * from hotelsancarlosv2.productos";

                OdbcDataAdapter da2 = new OdbcDataAdapter(sentencia);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);


                comboBox3.ValueMember = "idProducto";
                comboBox3.DisplayMember = "idProducto";

                comboBox3.DataSource = dt2;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("no encntrado. " + ex);
            }
            try
            {



                OdbcCommand sentencia = new OdbcCommand();
                sentencia.Connection = conector;
                sentencia.CommandText = "SELECT * from hotelsancarlosv2.proveedores";

                OdbcDataAdapter da3 = new OdbcDataAdapter(sentencia);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);


                comboBox2.ValueMember = "idProveedores";
                comboBox2.DisplayMember = "idProveedores";

                comboBox2.DataSource = dt3;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("no encntrado. " + ex);
            }



        }

        private void Catalogostab_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        

          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"SELECT nombreProveedor FROM proveedores WHERE idProveedores =  '" + comboBox2.Text + "'";
            string sql2 = @"SELECT direccion FROM proveedores WHERE idProveedores =  '" + comboBox2.Text + "'";
            string sql3 = @"SELECT representante FROM proveedores WHERE idProveedores =  '" + comboBox2.Text + "'";

            OdbcConnection conector = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ");
            conector.Open();




            OdbcCommand cmd5 = new OdbcCommand(sql, conector);
            string txtnombrep = Convert.ToString(cmd5.ExecuteScalar());


            textBox5.Text = txtnombrep;
            OdbcCommand cmd3 = new OdbcCommand(sql2, conector);
            string txtdireccion = Convert.ToString(cmd3.ExecuteScalar());


            textBox2.Text = txtdireccion;
            OdbcCommand cmd4 = new OdbcCommand(sql3, conector);
            string txtrepresentante = Convert.ToString(cmd4.ExecuteScalar());


            textBox1.Text = txtrepresentante;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Globales.departamento = comboBox1.Text;
            Globales.producto = textBox4.Text;
            Globales.precio = textBox3.Text;
            Globales.proveedor = textBox5.Text;
            Globales.direccion = textBox2.Text;
            Globales.representante = textBox1.Text;
            Globales.cantidad = textBox6.Text;
            string año, mes, dia, fecha;
            año = dateTimePicker1.Value.Year.ToString();
            mes = dateTimePicker1.Value.Month.ToString();
            dia = dateTimePicker1.Value.Day.ToString();
            fecha = año + "/" + mes + "/" + dia;
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into hotelsancarlosv2.ORDENESDECOMPRA(id_oc,idProveedores,idProducto,cantidad,categoria,fecha_prevista_de_recibido) values('" + Globales.oc + "','" + this.comboBox2.Text + "','" + this.comboBox3.Text + "','" + Globales.cantidad + "','" + Globales.departamento + "','" + fecha + "');";
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
