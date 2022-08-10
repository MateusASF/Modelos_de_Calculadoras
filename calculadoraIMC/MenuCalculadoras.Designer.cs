namespace calculadoras
{
    partial class MenuCalculadoras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCalculadoras));
            this.bt_menu_calcIMC = new System.Windows.Forms.Button();
            this.bt_menu_calcBasic = new System.Windows.Forms.Button();
            this.lb_menuTittle = new System.Windows.Forms.Label();
            this.lb_instrucaoMenu = new System.Windows.Forms.Label();
            this.gif_nazare = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gif_nazare)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_menu_calcIMC
            // 
            this.bt_menu_calcIMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.bt_menu_calcIMC.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_menu_calcIMC.Location = new System.Drawing.Point(48, 179);
            this.bt_menu_calcIMC.Name = "bt_menu_calcIMC";
            this.bt_menu_calcIMC.Size = new System.Drawing.Size(351, 86);
            this.bt_menu_calcIMC.TabIndex = 1;
            this.bt_menu_calcIMC.Text = "Calculadora de IMC";
            this.bt_menu_calcIMC.UseVisualStyleBackColor = false;
            this.bt_menu_calcIMC.Click += new System.EventHandler(this.bt_menu_calcIMC_Click);
            // 
            // bt_menu_calcBasic
            // 
            this.bt_menu_calcBasic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.bt_menu_calcBasic.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_menu_calcBasic.Location = new System.Drawing.Point(48, 305);
            this.bt_menu_calcBasic.Name = "bt_menu_calcBasic";
            this.bt_menu_calcBasic.Size = new System.Drawing.Size(351, 86);
            this.bt_menu_calcBasic.TabIndex = 2;
            this.bt_menu_calcBasic.Text = "Calculadora Básica";
            this.bt_menu_calcBasic.UseVisualStyleBackColor = false;
            this.bt_menu_calcBasic.Click += new System.EventHandler(this.bt_menu_calcBasic_Click);
            // 
            // lb_menuTittle
            // 
            this.lb_menuTittle.AutoSize = true;
            this.lb_menuTittle.BackColor = System.Drawing.Color.Transparent;
            this.lb_menuTittle.Font = new System.Drawing.Font("Impact", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_menuTittle.Location = new System.Drawing.Point(115, 15);
            this.lb_menuTittle.Name = "lb_menuTittle";
            this.lb_menuTittle.Size = new System.Drawing.Size(570, 71);
            this.lb_menuTittle.TabIndex = 0;
            this.lb_menuTittle.Text = "Menu de Calculadoras";
            // 
            // lb_instrucaoMenu
            // 
            this.lb_instrucaoMenu.AutoSize = true;
            this.lb_instrucaoMenu.BackColor = System.Drawing.Color.Transparent;
            this.lb_instrucaoMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_instrucaoMenu.Location = new System.Drawing.Point(262, 91);
            this.lb_instrucaoMenu.Name = "lb_instrucaoMenu";
            this.lb_instrucaoMenu.Size = new System.Drawing.Size(277, 28);
            this.lb_instrucaoMenu.TabIndex = 3;
            this.lb_instrucaoMenu.Text = "clique na calculadora desejada";
            // 
            // gif_nazare
            // 
            this.gif_nazare.Image = ((System.Drawing.Image)(resources.GetObject("gif_nazare.Image")));
            this.gif_nazare.Location = new System.Drawing.Point(423, 179);
            this.gif_nazare.Name = "gif_nazare";
            this.gif_nazare.Size = new System.Drawing.Size(336, 212);
            this.gif_nazare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gif_nazare.TabIndex = 4;
            this.gif_nazare.TabStop = false;
            // 
            // MenuCalculadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::calculadoras.Properties.Resources._6f45be1bb38cd6db87153106411b116a;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gif_nazare);
            this.Controls.Add(this.lb_instrucaoMenu);
            this.Controls.Add(this.lb_menuTittle);
            this.Controls.Add(this.bt_menu_calcBasic);
            this.Controls.Add(this.bt_menu_calcIMC);
            this.MaximizeBox = false;
            this.Name = "MenuCalculadoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Calcuadoras";
            ((System.ComponentModel.ISupportInitialize)(this.gif_nazare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_menu_calcIMC;
        private Button bt_menu_calcBasic;
        private Label lb_menuTittle;
        private Label lb_instrucaoMenu;
        private PictureBox gif_nazare;
    }
}