using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Troco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculaButton_Click(object sender, EventArgs e)
        {
            var valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            var valorPago = Convert.ToDecimal(valorPagoTextBox.Text);
            var troco = valorPago - valorCompra;
            //trocoTextBox.Text = Convert.ToString(troco); 
            //trocoTextBox.Text = troco.ToString("c");// colocando letra c, por padrâo 2 casas decimais 
            trocoTextBox.Text = troco.ToString("c", new CultureInfo("es-US"));

        }

    }
}
