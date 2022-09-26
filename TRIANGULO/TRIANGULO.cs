using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRIANGULO
{
    public partial class TRIANGULO : Form
    {
        public TRIANGULO()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            triangulo.CalcularSoapClient ws = new triangulo.CalcularSoapClient();
            resultado.Text = ws.TRIANGULO(Convert.ToInt32(Base.Text), Convert.ToInt32(altura.Text)).ToString();

        }
    }
}
