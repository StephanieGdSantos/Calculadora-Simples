using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double numero3, numero2, operador;
        string numero;
        public Calculadora()
        {
            InitializeComponent();
        }
        #region "Números"
        public void btn1_Click(object sender, EventArgs e)
        {
            numero += '1';
            txtVisor.Text = numero.ToString();
        }

        public void btn2_Click(object sender, EventArgs e)
        {
            numero += '2';
            txtVisor.Text = numero.ToString();
        }

        public void btn3_Click(object sender, EventArgs e)
        {
            numero += '3';
            txtVisor.Text = numero.ToString();
        }

        public void btn4_Click(object sender, EventArgs e)
        {
            numero += '4';
            txtVisor.Text = numero.ToString();
        }

        public void btn5_Click(object sender, EventArgs e)
        {
            numero += '5';
            txtVisor.Text = numero.ToString();
        }

        public void btn6_Click(object sender, EventArgs e)
        {
            numero += '6';
            txtVisor.Text = numero.ToString();
        }

        public void btn7_Click(object sender, EventArgs e)
        {
            numero += '7';
            txtVisor.Text = numero.ToString();
        }

        public void btn8_Click(object sender, EventArgs e)
        {
            numero += '8';
            txtVisor.Text = numero.ToString();
        }

        public void btn9_Click(object sender, EventArgs e)
        {
            numero += '9';
            txtVisor.Text = numero.ToString();
        }

        public void btn0_Click(object sender, EventArgs e)
        {
            numero += '0';
            txtVisor.Text = numero.ToString();
        }
        #endregion
        #region "Operadores"
        public void btnSoma_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(numero, CultureInfo.InvariantCulture);
            numero = null;
            operador = 1;
            lblOperador.Text = '+'.ToString();
        }

        public void btnSubtracao_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(numero, CultureInfo.InvariantCulture);
            numero = null;
            operador = 2;
            lblOperador.Text = '-'.ToString();
        }
        public void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(numero, CultureInfo.InvariantCulture);
            numero = null;
            operador = 3;
            lblOperador.Text = 'x'.ToString();
        }

        public void btnDivisao_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(numero, CultureInfo.InvariantCulture);
            numero = null;
            operador = 4;
            lblOperador.Text = '/'.ToString();
        }
        #endregion

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            numero += '.';
        }

        
        #region "Ações"
        private void btnResultado_Click(object sender, EventArgs e)
        {
            double resultado=0;
            numero3 = double.Parse(numero, CultureInfo.InvariantCulture);
                switch (operador)
                {
                    case 1:
                        resultado = numero2 + numero3;
                        break;
                    case 2:
                        resultado = numero2 - numero3;
                        break;
                    case 3:
                        resultado = numero2 * numero3;
                        break;
                    case 4:
                        resultado = numero2 / numero3;
                        break;
                }
            txtVisor.Text = resultado.ToString();
            lblOperador.Text = "";
            numero2 = numero3 = 0;
            numero = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
            lblOperador.Text = null;
            numero = null;
            numero2 = numero3 = 0;
        } //cancela toda a operação
        private void btnCancelarNumero_Click(object sender, EventArgs e)   
        {
            numero = null;
            txtVisor.Clear();
        } //vai cancelar apenas o número atual enquanto string, antes de se tornar double
        #endregion
    }
}
