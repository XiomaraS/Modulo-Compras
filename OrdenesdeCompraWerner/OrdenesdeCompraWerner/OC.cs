using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenesdeCompraWerner
{
    public partial class OC : Form
    {
        public OC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarOC F1 = new GenerarOC();
            F1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ver_solicitudes f2 = new Ver_solicitudes();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ControlDemora f5 = new ControlDemora();
            f5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlmacenarOCRealizadas f6 = new AlmacenarOCRealizadas();
            f6.Show();

        }
    }
}
