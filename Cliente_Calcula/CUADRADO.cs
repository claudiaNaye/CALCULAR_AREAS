using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Calcula
{
    public partial class CUADRADO : Form
    {
        public CUADRADO()
        {
            InitializeComponent();
        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            calcularArea.CalcularSoapClient ws = new calcularArea.CalcularSoapClient();
            resultadoCuadrado.Text = ws.CUADRADO(Convert.ToInt32(lado.Text)).ToString();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
