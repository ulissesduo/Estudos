using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKFah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void converter_Click(object sender, EventArgs e)
        {
            if (tcel.Checked && cofah.Checked) 
            {
                int c = int.Parse(temp.Text);
                double fah = c * 1.8 + 32.0;
                MessageBox.Show(c + "ºC equivale a " + fah + " ºF.","Conversor de temperatura");
            }
            if (tcel.Checked && cokel.Checked)
            {
                int c = int.Parse(temp.Text);
                double kel = c + 273.0;
                MessageBox.Show(c + "ºC equivale a " + kel + " K.", "Conversor de temperatura");
            }
            if (tkel.Checked && cocel.Checked)
            {
                int kel = int.Parse(temp.Text);
                double c = kel - 273.0;
                MessageBox.Show(kel + "K equivale a " + c + " ºC.", "Conversor de temperatura");
            }
            if (tkel.Checked && cofah.Checked)
            {
                int kel = int.Parse(temp.Text);
                double fah = 1.8*(kel - 273)+32.0;
                MessageBox.Show(kel + "K equivale a " + fah + " ºF.", "Conversor de temperatura");
            }
            if (tfah.Checked && cocel.Checked)
            {
                int fah = int.Parse(temp.Text);
                double c = (fah - 32.0)*5/9;
                MessageBox.Show(fah + "ºF equivale a " + c + " ºC.", "Conversor de temperatura");
            }
            if (tfah.Checked && cokel.Checked)
            {
                int fah = int.Parse(temp.Text);
                double kel = (fah - 32.0) * 5/9 + 273.0;
                MessageBox.Show(fah + "ºF equivale a " + kel + " K.", "Conversor de temperatura");
            }
        }
    }
}
