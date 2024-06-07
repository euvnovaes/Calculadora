using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular(double num1, double num2, string sinal)
        {
            Double x = 0;

            switch (sinal)
            {
                case "+":
                    x = num1 + num2;
                    break;
                case "-":
                    x = num1 - num2;
                    break;
                case "x":
                    x = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        x = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("Não é possível dividir por 0!");
                    }
                    break;
                default: MessageBox.Show("Operador invalido!");
                    return;
            }
            txtTotal.Text = x.ToString();
            
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Double v1 = Double.Parse(txtVa1.Text);

            Double v2 = Double.Parse(txtVa2.Text);

            string sinal = "";

            if (rdSoma.Checked)
            {
                sinal = "+";
            }
            else if (rdSubt.Checked)
            {
                sinal = "-";
            }
            else if (rdMult.Checked)
            {
                sinal = "x";
            }
            else if (rdDiv.Checked)
            {
                sinal = "/";
            }

            calcular(v1, v2, sinal);
        }

    }
}
