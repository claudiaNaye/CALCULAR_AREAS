using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CUADRADO_Click(object sender, EventArgs e)
        {
            CalcularServiceReference.CalcularSoapClient ws = new CalcularServiceReference.CalcularSoapClient();
            resultado.Text = ws.CUADRADO((int)Convert.ToUInt32(ladotextBox.Text)).ToString();
        }
    }
}
