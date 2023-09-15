using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_Salarial_Simples_Final
{
    public partial class FormFinal : Form
    {
        public FormFinal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void calculoDescontoButton_Click(object sender, EventArgs e)
        {
            double salarioInicial;
            double salarioCalcINSS1;
            double salarioCalcINSS2;
            double salarioAposINSS;
            double descontoINSS;
            double descontoIR;
            double descontoTotal;
            double salarioFinal;

            descontoINSS = 0;
            descontoIR = 0;
            salarioAposINSS = 0;
            try
            {
                salarioInicial = double.Parse(salarioTextBox.Text);


                if (salarioInicial <= 1320)
                {
                    descontoINSS = salarioInicial * 0.075;


                }
                if (salarioInicial >= 1320.01 && salarioInicial <= 2571.29)
                {
                    salarioCalcINSS1 = salarioInicial - 1320;
                    salarioCalcINSS2 = salarioCalcINSS1 * 0.09;
                    descontoINSS = salarioCalcINSS2 + 99;
                    salarioAposINSS = salarioInicial - descontoINSS;

                }
                if (salarioInicial >= 2571.30 && salarioInicial <= 3856.94)
                {
                    salarioCalcINSS1 = salarioInicial - 2571.29;
                    salarioCalcINSS2 = salarioCalcINSS1 * 0.12;
                    descontoINSS = 99 + 112.62 + salarioCalcINSS2;
                    salarioAposINSS = salarioInicial - descontoINSS;
                }
                if (salarioInicial >= 3856.95 && salarioInicial <= 7507.49)
                {
                    salarioCalcINSS1 = salarioInicial - 3856.94;
                    salarioCalcINSS2 = salarioCalcINSS1 * 0.14;
                    descontoINSS = 99 + 112.62 + 154.28 + salarioCalcINSS2;
                    salarioAposINSS = salarioInicial - descontoINSS;
                }
                if (salarioInicial > 7507.49)
                {
                    descontoINSS = 876.96;
                    salarioAposINSS = salarioInicial - descontoINSS;
                }

                
                if (salarioAposINSS <= 2112)
                {
                    descontoIR = 0;


                }
                if (salarioAposINSS >= 2112.01 && salarioAposINSS <= 2826.65)
                {
                    descontoIR = (salarioAposINSS*0.075) - 158.4;

                }
                if (salarioAposINSS >= 2826.66 && salarioAposINSS <= 3751.05)
                {
                    descontoIR = (salarioAposINSS * 0.15) - 370.4;

                }
                if (salarioAposINSS >= 3751.06 && salarioAposINSS <= 4664.68)
                {
                    descontoIR = (salarioAposINSS * 0.225) - 651.73;

                }
                if (salarioAposINSS > 4664.69)
                {
                    descontoIR = (salarioAposINSS * 0.275) - 884.96;

                }
                
                descontoTotal = descontoIR + descontoINSS;
                salarioFinal = salarioInicial - descontoTotal;
                mostrarSalarioLiquidoLable.Text = salarioFinal.ToString("c");

                mostrarSalarioBrutoLabel.Text = salarioInicial.ToString("c");
                mostrarDescontoInssLable.Text = descontoINSS.ToString("c");
                mostrarDescontoIrLable.Text = descontoIR.ToString("c");
                mostrarDescontoTotalLable.Text = descontoTotal.ToString("c");
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor do salário inválido!");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
