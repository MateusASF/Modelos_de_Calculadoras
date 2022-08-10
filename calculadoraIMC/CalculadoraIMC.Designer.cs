namespace calculadoraIMC
{
    partial class CalculadoraIMC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraIMC));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_peso = new System.Windows.Forms.Label();
            this.lb_altura = new System.Windows.Forms.Label();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.insert_peso = new System.Windows.Forms.TextBox();
            this.insert_altura = new System.Windows.Forms.TextBox();
            this.lb_cm = new System.Windows.Forms.Label();
            this.lb_kg = new System.Windows.Forms.Label();
            this.bt_Back_IMC_Menu = new System.Windows.Forms.Button();
            this.pb_Exercicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exercicio)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::calculadoras.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(194, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_peso
            // 
            this.lb_peso.AutoSize = true;
            this.lb_peso.BackColor = System.Drawing.Color.Transparent;
            this.lb_peso.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_peso.Location = new System.Drawing.Point(179, 269);
            this.lb_peso.Name = "lb_peso";
            this.lb_peso.Size = new System.Drawing.Size(67, 32);
            this.lb_peso.TabIndex = 1;
            this.lb_peso.Text = "Peso";
            // 
            // lb_altura
            // 
            this.lb_altura.AutoSize = true;
            this.lb_altura.BackColor = System.Drawing.Color.Transparent;
            this.lb_altura.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_altura.Location = new System.Drawing.Point(176, 301);
            this.lb_altura.Name = "lb_altura";
            this.lb_altura.Size = new System.Drawing.Size(85, 32);
            this.lb_altura.TabIndex = 2;
            this.lb_altura.Text = "Altura";
            // 
            // bt_calcular
            // 
            this.bt_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(196)))), ((int)(((byte)(240)))));
            this.bt_calcular.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_calcular.Location = new System.Drawing.Point(130, 381);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(187, 62);
            this.bt_calcular.TabIndex = 3;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = false;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(94)))), ((int)(((byte)(238)))));
            this.bt_limpar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_limpar.Location = new System.Drawing.Point(342, 381);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(208, 62);
            this.bt_limpar.TabIndex = 4;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo.Location = new System.Drawing.Point(120, 174);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(315, 45);
            this.lb_titulo.TabIndex = 7;
            this.lb_titulo.Text = "Calculadora de IMC";
            this.lb_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_resultado
            // 
            this.lb_resultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_resultado.Location = new System.Drawing.Point(130, 460);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(639, 112);
            this.lb_resultado.TabIndex = 8;
            this.lb_resultado.Text = " ";
            this.lb_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insert_peso
            // 
            this.insert_peso.Location = new System.Drawing.Point(256, 271);
            this.insert_peso.Name = "insert_peso";
            this.insert_peso.Size = new System.Drawing.Size(82, 27);
            this.insert_peso.TabIndex = 1;
            // 
            // insert_altura
            // 
            this.insert_altura.Location = new System.Drawing.Point(256, 306);
            this.insert_altura.Name = "insert_altura";
            this.insert_altura.Size = new System.Drawing.Size(82, 27);
            this.insert_altura.TabIndex = 2;
            // 
            // lb_cm
            // 
            this.lb_cm.AutoSize = true;
            this.lb_cm.BackColor = System.Drawing.Color.Transparent;
            this.lb_cm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_cm.Location = new System.Drawing.Point(342, 310);
            this.lb_cm.Name = "lb_cm";
            this.lb_cm.Size = new System.Drawing.Size(23, 20);
            this.lb_cm.TabIndex = 11;
            this.lb_cm.Text = "m";
            // 
            // lb_kg
            // 
            this.lb_kg.AutoSize = true;
            this.lb_kg.BackColor = System.Drawing.Color.Transparent;
            this.lb_kg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_kg.Location = new System.Drawing.Point(342, 274);
            this.lb_kg.Name = "lb_kg";
            this.lb_kg.Size = new System.Drawing.Size(26, 20);
            this.lb_kg.TabIndex = 12;
            this.lb_kg.Text = "kg";
            // 
            // bt_Back_IMC_Menu
            // 
            this.bt_Back_IMC_Menu.BackColor = System.Drawing.Color.Silver;
            this.bt_Back_IMC_Menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Back_IMC_Menu.Location = new System.Drawing.Point(579, 381);
            this.bt_Back_IMC_Menu.Name = "bt_Back_IMC_Menu";
            this.bt_Back_IMC_Menu.Size = new System.Drawing.Size(190, 62);
            this.bt_Back_IMC_Menu.TabIndex = 13;
            this.bt_Back_IMC_Menu.Text = "Voltar ao Menu Principal";
            this.bt_Back_IMC_Menu.UseVisualStyleBackColor = false;
            this.bt_Back_IMC_Menu.Click += new System.EventHandler(this.bt_Back_IMC_Menu_Click);
            // 
            // pb_Exercicio
            // 
            this.pb_Exercicio.BackColor = System.Drawing.Color.Transparent;
            this.pb_Exercicio.Image = ((System.Drawing.Image)(resources.GetObject("pb_Exercicio.Image")));
            this.pb_Exercicio.Location = new System.Drawing.Point(429, 50);
            this.pb_Exercicio.Name = "pb_Exercicio";
            this.pb_Exercicio.Size = new System.Drawing.Size(350, 297);
            this.pb_Exercicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Exercicio.TabIndex = 14;
            this.pb_Exercicio.TabStop = false;
            // 
            // CalculadoraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::calculadoras.Properties.Resources._6f45be1bb38cd6db87153106411b116a;
            this.ClientSize = new System.Drawing.Size(900, 590);
            this.Controls.Add(this.pb_Exercicio);
            this.Controls.Add(this.bt_Back_IMC_Menu);
            this.Controls.Add(this.lb_kg);
            this.Controls.Add(this.lb_cm);
            this.Controls.Add(this.insert_altura);
            this.Controls.Add(this.insert_peso);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.lb_altura);
            this.Controls.Add(this.lb_peso);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "CalculadoraIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculadoraIMC";
            this.Load += new System.EventHandler(this.CalculadoraIMC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exercicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lb_peso;
        private Label lb_altura;
        private Button bt_calcular;
        private Button bt_limpar;
        private Label lb_titulo;
        private Label lb_resultado;
        private TextBox insert_peso;
        private TextBox insert_altura;
        private Label lb_cm;
        private Label lb_kg;
        private Button bt_Back_IMC_Menu;
        private PictureBox pb_Exercicio;
    }
}