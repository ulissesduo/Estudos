using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace janelas_2_exercício_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.total.Text = "";
            decimal rapadura = numRap.Value*1.50M;
            decimal inhame = numInhame.Value*3.00M;
            decimal cupuacu = numCupuacu.Value*1.10M;
            decimal sandalias = numSand.Value*12.35M;
            decimal bolacha = numBolacha.Value*1.85M;
            decimal sabao = numSabao.Value*0.80M;
            decimal pinico = numPinico.Value*11.17M;
            decimal total = rapadura+inhame+cupuacu+sandalias+bolacha+sabao+pinico;

             
            if (cbRap.Checked && numRap.Value > 0)
            {
                this.total.Text = total.ToString();
            }
            if (cbInhame.Checked && numInhame.Value > 0)
            {
                this.total.Text = total.ToString();
            }
            if (cbCupuacu.Checked && numCupuacu.Value > 0)
            {
                this.total.Text = total.ToString();
            }
            if (cbSand.Checked && numSand.Value > 0)
            {
                this.total.Text = total.ToString();
            }
            if (cbBolacha.Checked && numBolacha.Value > 0)
            {
                this.total.Text = total.ToString();

            }
            if (cbSabao.Checked && numSabao.Value > 0)
            {
                this.total.Text = total.ToString();

            }
            if (cbPinico.Checked && numPinico.Value > 0)
            {
                this.total.Text = total.ToString();

            }
        }
    }
}
