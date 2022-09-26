using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULOS_EN_GENERAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            calcularAreas1.CalcularSoapClient ws = new calcularAreas1.CalcularSoapClient();
            resultadoCuadrado.Text = ws.CUADRADO(Convert.ToInt32(lado.Text)).ToString();
            resultadotriangulo.Text = ws.TRIANGULO(Convert.ToInt32(Base.Text),Convert.ToInt32(altura.Text)).ToString();
            resultadocirculo.Text = ws.CIRCULO(Convert.ToInt32(radio.Text)).ToString();
          
        }
    }
}
