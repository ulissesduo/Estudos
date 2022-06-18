using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace janelas2_IMC
{
    public partial class Form1 : Form
    {
        int img_num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calculoIMC = Convert.ToDouble(peso.Value / (altura.Value * altura.Value));
            lblResultado.Text = calculoIMC.ToString();

            if (calculoIMC < 17 && comboBox1.SelectedIndex == 1)
            {
                lblResultado.Text = "Muito abaixo do peso: " + calculoIMC;
                pic_Random.Image = img_Random.Images[0];
                
            }
            else if (calculoIMC >= 17 && calculoIMC < 18 && comboBox1.SelectedIndex == 1)
            {
                lblResultado.Text = "Abaixo do peso: " + calculoIMC;
                pic_Random.Image = img_Random.Images[0];
            }
            else if (calculoIMC >= 18 && calculoIMC < 25 && comboBox1.SelectedIndex == 1)
            {
                lblResultado.Text = "Peso normal: " + calculoIMC;
                pic_Random.Image = img_Random.Images[1];
            }
            else if (calculoIMC >= 25 && calculoIMC < 30 && comboBox1.SelectedIndex == 1)
            {
                lblResultado.Text = "Acima do peso: " + calculoIMC;
                pic_Random.Image = img_Random.Images[2];

            }
            else if (calculoIMC >= 30 && calculoIMC < 35 && comboBox1.SelectedIndex == 1)
            {
                lblResultado.Text = "Obesidade I: " + calculoIMC;
                pic_Random.Image = img_Random.Images[3];

            }
            else if (calculoIMC >= 35 && calculoIMC < 40 && comboBox1.SelectedIndex == 1)
            {
                lblResultado.Text = "Obesidade II (severa): " + calculoIMC;
                pic_Random.Image = img_Random.Images[4];

            }

            else if (calculoIMC >= 40 && comboBox1.SelectedIndex == 1)
            {
                lblResultado.Text = "Obesidade III (mórbida): " + calculoIMC;
                pic_Random.Image = img_Random.Images[4];

            }
            if (calculoIMC < 17 && comboBox1.SelectedIndex == 0)
            {
                lblResultado.Text = "Muito abaixo do peso: " + calculoIMC;
                pic_Random.Image = img_Random.Images[5];

            }
            else if (calculoIMC >= 17 && calculoIMC < 18 && comboBox1.SelectedIndex == 0)
            {
                lblResultado.Text = "Abaixo do peso: " + calculoIMC;
                pic_Random.Image = img_Random.Images[5];
            }
            else if (calculoIMC >= 18 && calculoIMC < 25 && comboBox1.SelectedIndex == 0)
            {
                lblResultado.Text = "Peso normal: " + calculoIMC;
                pic_Random.Image = img_Random.Images[6];
            }
            else if (calculoIMC >= 25 && calculoIMC < 30 && comboBox1.SelectedIndex == 0)
            {
                lblResultado.Text = "Acima do peso: " + calculoIMC;
                pic_Random.Image = img_Random.Images[7];

            }
            else if (calculoIMC >= 30 && calculoIMC < 35 && comboBox1.SelectedIndex == 0)
            {
                lblResultado.Text = "Obesidade I: " + calculoIMC;
                pic_Random.Image = img_Random.Images[8];

            }
            else if (calculoIMC >= 35 && calculoIMC < 40 && comboBox1.SelectedIndex == 0)
            {
                lblResultado.Text = "Obesidade II (severa): " + calculoIMC;
                pic_Random.Image = img_Random.Images[9];

            }

            else if (calculoIMC >= 40 && comboBox1.SelectedIndex == 0)
            {
                lblResultado.Text = "Obesidade III (mórbida): " + calculoIMC;
                pic_Random.Image = img_Random.Images[9];

            }
            
        }
        

    private void btnLimpar_Click(object sender, EventArgs e)
        {
            peso.Value = 0;
            altura.Value = 0;
            comboBox1.SelectedIndex = 0;
            lblResultado.Text = "";
            pic_Random.Visible = false;


        }
    }
}
