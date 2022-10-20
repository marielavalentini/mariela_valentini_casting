using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mariela_valentini_casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConversionImplicita_Click(object sender, EventArgs e)
        {
            //Ejemplo de conversion implicita:

            int numero = 652;
            long numerolong = numero;

            MessageBox.Show("El numero: " + numerolong + " es ahora de tipo long");
        }

        private void btnConversionExplicita_Click(object sender, EventArgs e)
        {
            //Ejemplo de conversion explicita 
             decimal numeroIngresado = Convert.ToDecimal(txtDecimal.Text);

            MessageBox.Show("El numero: " + numeroIngresado + " es ahora de tipo decimal");

        }
    }
}
