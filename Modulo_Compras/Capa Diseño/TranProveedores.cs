/*Raul Portillo 
  0901-13-14547
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proveedores1
{
    public partial class TranProveedores : Form
    {
        public int idApp = 6203;
        public TranProveedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantTranProveedores mov = new MantTranProveedores();
            mov.Show();
            this.Close();
        }

        private void TranProveedores_Load(object sender, EventArgs e)
        {
            try {
                String stringpad = "Dsn=hotelsancarlos; Database=hotelSanCarlos;";
                dllconnectionDatabase.dllconnectionDatabase connection = new dllconnectionDatabase.dllconnectionDatabase(stringpad);
                connection.OpenConnection();
                Dgv_TranProv.DataSource = connection.llenarDataGridView("select * from transacciones_proveedores");

                connection.CloseConnection();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            
        }
        private void Dgv_TranProv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MantTranProveedores mov = new MantTranProveedores();
            mov.id = Dgv_TranProv.CurrentRow.Cells[0].Value.ToString();
            mov.Txt_decrip.Text = Dgv_TranProv.CurrentRow.Cells[1].Value.ToString();
            mov.Txt_cod.Text = Dgv_TranProv.CurrentRow.Cells[0].Value.ToString();
            mov.Txt_decrip.Enabled = false;
            mov.Txt_cod.Enabled = false;
            mov.Show();
        }
    }
}
