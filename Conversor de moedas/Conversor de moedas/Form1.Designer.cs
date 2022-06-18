namespace Conversor_de_moedas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inicial = new System.Windows.Forms.TextBox();
            this.cotacao = new System.Windows.Forms.TextBox();
            this.dereal = new System.Windows.Forms.RadioButton();
            this.dedolar = new System.Windows.Forms.RadioButton();
            this.coreal = new System.Windows.Forms.RadioButton();
            this.codolar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cotação do dólar";
            // 
            // inicial
            // 
            this.inicial.Location = new System.Drawing.Point(177, 29);
            this.inicial.Name = "inicial";
            this.inicial.Size = new System.Drawing.Size(144, 20);
            this.inicial.TabIndex = 2;
            this.inicial.Text = "0";
            // 
            // cotacao
            // 
            this.cotacao.Location = new System.Drawing.Point(177, 69);
            this.cotacao.Name = "cotacao";
            this.cotacao.Size = new System.Drawing.Size(144, 20);
            this.cotacao.TabIndex = 3;
            this.cotacao.Text = "0";
            // 
            // dereal
            // 
            this.dereal.AutoSize = true;
            this.dereal.Location = new System.Drawing.Point(30, 19);
            this.dereal.Name = "dereal";
            this.dereal.Size = new System.Drawing.Size(47, 17);
            this.dereal.TabIndex = 4;
            this.dereal.TabStop = true;
            this.dereal.Text = "Real";
            this.dereal.UseVisualStyleBackColor = true;
            // 
            // dedolar
            // 
            this.dedolar.AutoSize = true;
            this.dedolar.Location = new System.Drawing.Point(30, 65);
            this.dedolar.Name = "dedolar";
            this.dedolar.Size = new System.Drawing.Size(50, 17);
            this.dedolar.TabIndex = 5;
            this.dedolar.TabStop = true;
            this.dedolar.Text = "Dólar";
            this.dedolar.UseVisualStyleBackColor = true;
            // 
            // coreal
            // 
            this.coreal.AutoSize = true;
            this.coreal.Location = new System.Drawing.Point(221, 174);
            this.coreal.Name = "coreal";
            this.coreal.Size = new System.Drawing.Size(47, 17);
            this.coreal.TabIndex = 6;
            this.coreal.TabStop = true;
            this.coreal.Text = "Real";
            this.coreal.UseVisualStyleBackColor = true;
            // 
            // codolar
            // 
            this.codolar.AutoSize = true;
            this.codolar.Location = new System.Drawing.Point(221, 220);
            this.codolar.Name = "codolar";
            this.codolar.Size = new System.Drawing.Size(50, 17);
            this.codolar.TabIndex = 7;
            this.codolar.TabStop = true;
            this.codolar.Text = "Dólar";
            this.codolar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dereal);
            this.groupBox1.Controls.Add(this.dedolar);
            this.groupBox1.Location = new System.Drawing.Point(15, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moeda";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Converter p/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 347);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.codolar);
            this.Controls.Add(this.coreal);
            this.Controls.Add(this.cotacao);
            this.Controls.Add(this.inicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inicial;
        private System.Windows.Forms.TextBox cotacao;
        private System.Windows.Forms.RadioButton dereal;
        private System.Windows.Forms.RadioButton dedolar;
        private System.Windows.Forms.RadioButton coreal;
        private System.Windows.Forms.RadioButton codolar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

