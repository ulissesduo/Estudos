namespace janelas2_IMC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.NumericUpDown();
            this.peso = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pic_Random = new System.Windows.Forms.PictureBox();
            this.img_Random = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Random)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Escolha o sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura em m:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso em kg";
            // 
            // altura
            // 
            this.altura.DecimalPlaces = 2;
            this.altura.Location = new System.Drawing.Point(173, 60);
            this.altura.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(120, 20);
            this.altura.TabIndex = 3;
            this.altura.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // peso
            // 
            this.peso.Location = new System.Drawing.Point(172, 85);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(120, 20);
            this.peso.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.comboBox1.Location = new System.Drawing.Point(172, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Selecione";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(93, 121);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(188, 121);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar dados";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(93, 179);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 8;
            // 
            // pic_Random
            // 
            this.pic_Random.Location = new System.Drawing.Point(329, 12);
            this.pic_Random.Name = "pic_Random";
            this.pic_Random.Size = new System.Drawing.Size(222, 264);
            this.pic_Random.TabIndex = 9;
            this.pic_Random.TabStop = false;
            // 
            // img_Random
            // 
            this.img_Random.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Random.ImageStream")));
            this.img_Random.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Random.Images.SetKeyName(0, "Homem abaixoPeso.jpeg");
            this.img_Random.Images.SetKeyName(1, "Homem pesoNormal.jpeg");
            this.img_Random.Images.SetKeyName(2, "Homem sobrepeso.jpeg");
            this.img_Random.Images.SetKeyName(3, "Homem obeso.jpeg");
            this.img_Random.Images.SetKeyName(4, "Homem obesoGrave.jpeg");
            this.img_Random.Images.SetKeyName(5, "Mulher abaixoPeso.jpeg");
            this.img_Random.Images.SetKeyName(6, "Mulher pesoNormal.jpeg");
            this.img_Random.Images.SetKeyName(7, "Mulher sobrepeso.jpeg");
            this.img_Random.Images.SetKeyName(8, "Mulher obesa.jpeg");
            this.img_Random.Images.SetKeyName(9, "Mulher obesaGrave.jpeg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 293);
            this.Controls.Add(this.pic_Random);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Random)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown altura;
        private System.Windows.Forms.NumericUpDown peso;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pic_Random;
        private System.Windows.Forms.ImageList img_Random;
    }
}

