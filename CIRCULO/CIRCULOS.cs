using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIRCULO
{
    public partial class CIRCULOS : Form
    {
        public CIRCULOS()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            servicioCirculo.CalcularSoapClient ws = new servicioCirculo.CalcularSoapClient();
            resultado.Text = ws.CIRCULO(Convert.ToUInt32(radio.Text)).ToString();
        }
    }
}
