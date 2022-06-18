namespace CKFah
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
            this.temp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.converter = new System.Windows.Forms.Button();
            this.tcel = new System.Windows.Forms.RadioButton();
            this.tkel = new System.Windows.Forms.RadioButton();
            this.tfah = new System.Windows.Forms.RadioButton();
            this.cofah = new System.Windows.Forms.RadioButton();
            this.cokel = new System.Windows.Forms.RadioButton();
            this.cocel = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // temp
            // 
            this.temp.Location = new System.Drawing.Point(39, 39);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(264, 20);
            this.temp.TabIndex = 0;
            this.temp.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resposta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Converter p/";
            // 
            // converter
            // 
            this.converter.Location = new System.Drawing.Point(211, 157);
            this.converter.Name = "converter";
            this.converter.Size = new System.Drawing.Size(142, 35);
            this.converter.TabIndex = 4;
            this.converter.Text = "Converter";
            this.converter.UseVisualStyleBackColor = true;
            this.converter.Click += new System.EventHandler(this.converter_Click);
            // 
            // tcel
            // 
            this.tcel.AutoSize = true;
            this.tcel.Location = new System.Drawing.Point(6, 19);
            this.tcel.Name = "tcel";
            this.tcel.Size = new System.Drawing.Size(58, 17);
            this.tcel.TabIndex = 5;
            this.tcel.TabStop = true;
            this.tcel.Text = "Celsius";
            this.tcel.UseVisualStyleBackColor = true;
            // 
            // tkel
            // 
            this.tkel.AutoSize = true;
            this.tkel.Location = new System.Drawing.Point(6, 58);
            this.tkel.Name = "tkel";
            this.tkel.Size = new System.Drawing.Size(54, 17);
            this.tkel.TabIndex = 6;
            this.tkel.TabStop = true;
            this.tkel.Text = "Kelvin";
            this.tkel.UseVisualStyleBackColor = true;
            // 
            // tfah
            // 
            this.tfah.AutoSize = true;
            this.tfah.Location = new System.Drawing.Point(6, 104);
            this.tfah.Name = "tfah";
            this.tfah.Size = new System.Drawing.Size(75, 17);
            this.tfah.TabIndex = 7;
            this.tfah.TabStop = true;
            this.tfah.Text = "Fahrenheit";
            this.tfah.UseVisualStyleBackColor = true;
            // 
            // cofah
            // 
            this.cofah.AutoSize = true;
            this.cofah.Location = new System.Drawing.Point(533, 127);
            this.cofah.Name = "cofah";
            this.cofah.Size = new System.Drawing.Size(75, 17);
            this.cofah.TabIndex = 10;
            this.cofah.TabStop = true;
            this.cofah.Text = "Fahrenheit";
            this.cofah.UseVisualStyleBackColor = true;
            // 
            // cokel
            // 
            this.cokel.AutoSize = true;
            this.cokel.Location = new System.Drawing.Point(533, 81);
            this.cokel.Name = "cokel";
            this.cokel.Size = new System.Drawing.Size(54, 17);
            this.cokel.TabIndex = 9;
            this.cokel.TabStop = true;
            this.cokel.Text = "Kelvin";
            this.cokel.UseVisualStyleBackColor = true;
            // 
            // cocel
            // 
            this.cocel.AutoSize = true;
            this.cocel.Location = new System.Drawing.Point(533, 42);
            this.cocel.Name = "cocel";
            this.cocel.Size = new System.Drawing.Size(58, 17);
            this.cocel.TabIndex = 8;
            this.cocel.TabStop = true;
            this.cocel.Text = "Celsius";
            this.cocel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tcel);
            this.groupBox1.Controls.Add(this.tkel);
            this.groupBox1.Controls.Add(this.tfah);
            this.groupBox1.Location = new System.Drawing.Point(309, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 131);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperatura:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 246);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cofah);
            this.Controls.Add(this.cokel);
            this.Controls.Add(this.cocel);
            this.Controls.Add(this.converter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.temp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox temp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button converter;
        private System.Windows.Forms.RadioButton tcel;
        private System.Windows.Forms.RadioButton tkel;
        private System.Windows.Forms.RadioButton tfah;
        private System.Windows.Forms.RadioButton cofah;
        private System.Windows.Forms.RadioButton cokel;
        private System.Windows.Forms.RadioButton cocel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

