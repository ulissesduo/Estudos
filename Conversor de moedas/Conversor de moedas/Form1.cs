using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_moedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dereal.Checked && codolar.Checked) {
                int num = int.Parse(inicial.Text);
                double dolarcot = double.Parse(cotacao.Text);
                double resultado = num / dolarcot;
                MessageBox.Show("O valor convertido é de $" + resultado.ToString("F2"), "Conversor de moedas");
            }
            
            if (dedolar.Checked && coreal.Checked)
            {
                int num = int.Parse(inicial.Text);
                double dolarcot = double.Parse(cotacao.Text);
                double resultado = num * dolarcot;
                MessageBox.Show("O valor convertido é de R$" + resultado.ToString("F2"), "Conversor de moedas");
            }
            if (dedolar.Checked && codolar.Checked) {
                MessageBox.Show("Dólar para dólar", "Conversor de moedas");
            }

            if (dereal.Checked && coreal.Checked)
            {
                MessageBox.Show("Real para real", "Conversor de moedas");
            }
        }
    }
}
