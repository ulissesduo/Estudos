using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador_de_notas
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

        private void button1_Click(object sender, EventArgs e)
        {
            double valorDigitado = double.Parse(num.Text);
            int notasDuz = 0;
            int notasCem = 0;
            int notasCinq = 0;
            int notasVin = 0;
            int notasDez = 0;
            int notasCinco = 0;
            int notasDois = 0;
            int notasUm = 0;
            int moedaCinq = 0;
            int moedaVinC = 0;
            int moedaDez = 0;
            int moedaCinco = 0;

            if (valorDigitado >= 200)
            {
                double resto = valorDigitado % 200;
                double variavelApoio = valorDigitado - resto;
                double notasDuzz = variavelApoio /200;
                valorDigitado = resto;
                notasDuz = Convert.ToInt32(notasDuzz);
            }

            if (valorDigitado >= 100)
            {
                double resto = valorDigitado % 100;   
                double variavelApoio = valorDigitado - resto;
                double notasCemm = variavelApoio / 100;
                valorDigitado = resto;
                notasCem = Convert.ToInt32(notasCemm);
            }
            if (valorDigitado >= 50)
            {
                double resto = valorDigitado % 50;
                double variavelApoio = valorDigitado - resto;
                double notasCinqq = variavelApoio / 50;
                valorDigitado = resto;
                notasCinq = Convert.ToInt32(notasCinqq);
            }
            if (valorDigitado >= 20)
            {
                double resto = valorDigitado % 20;
                double variavelApoio = valorDigitado - resto;
                double notasVinn = variavelApoio / 20;
                valorDigitado = resto;
                notasVin = Convert.ToInt32(notasVinn);
            }
            if (valorDigitado >= 10)
            {
                double resto = valorDigitado % 10;
                double variavelApoio = valorDigitado - resto;
                double notasDezz = variavelApoio / 10;
                valorDigitado = resto;
                notasDez = Convert.ToInt32(notasDezz);
            }
            if (valorDigitado >= 5)
            {
                double resto = valorDigitado % 5;
                double variavelApoio = valorDigitado - resto;
                double notasCinn = variavelApoio / 5;
                valorDigitado = resto;
                notasCinco = Convert.ToInt32(notasCinn);
            }
            if (valorDigitado >= 2)
            {
                double resto = valorDigitado % 2;
                double variavelApoio = valorDigitado - resto;
                double notasDoiss = variavelApoio / 2;
                valorDigitado = resto;
                notasDois = Convert.ToInt32(notasDoiss);
            }
            if (valorDigitado >= 1)
            {
                double resto = valorDigitado % 1;
                double variavelApoio = valorDigitado - resto;
                double moedaUmm = variavelApoio / 1;
                valorDigitado = resto;
                notasUm = Convert.ToInt32(moedaUmm);
            }
            if (valorDigitado >= 0.50)
            {
                double resto = valorDigitado % 0.50;
                double variavelApoio = valorDigitado - resto;
                double moedaCinqq = variavelApoio / 0.50;
                valorDigitado = resto;
                moedaCinq = Convert.ToInt32(moedaCinqq);
            }
            if (valorDigitado >= 0.25)
            {
                double resto = valorDigitado % 0.25;
                double variavelApoio = valorDigitado - resto;
                double moedaVinc = variavelApoio / 0.25;
                valorDigitado = resto;
                moedaVinC = Convert.ToInt32(moedaVinc);
            }
            if (valorDigitado >= 0.10)
            {
                double resto = valorDigitado % 0.10;
                double variavelApoio = valorDigitado - resto;
                double moedaDezz = variavelApoio / 0.10;
                valorDigitado = resto;
                moedaDez = Convert.ToInt32(moedaDezz);
            }
            if (valorDigitado > 0.10)
            {
                double resto = valorDigitado % 0.05;
                double variavelApoio = valorDigitado - resto;
                double moedaCinc = variavelApoio / 0.05;
                valorDigitado = resto;
                moedaCinco = Convert.ToInt32(moedaCinc);
            }


            MessageBox.Show("notas de duzentos: " + notasDuz +
                "\n\rNotas de cem: " + notasCem +
                "\n\rNotas de cinquenta: " + notasCinq +
                "\n\rNotas de vinte: " + notasVin +
                "\n\rNotas de dez: " + notasDez +
                "\n\rNotas de cinco: " + notasCinco +
                "\n\rNotas de dois: " + notasDois +
                "\n\rMoedas de um real: " + notasUm +
                "\n\rMoedas de cinquenta centavos: " + moedaCinq +
                "\n\rMoedas de vinte e cinco centavos: " + moedaVinC +
                "\n\rMoedas de dez centavos: " + moedaDez +
                "\n\rMoedas de cinco centavos: " + moedaCinco, "Contador de notas para troco");


        }
    }
}
