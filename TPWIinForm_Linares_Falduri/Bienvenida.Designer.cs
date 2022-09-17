namespace TPWIinForm_Linares_Falduri
{
    partial class Bienvenida
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            this.LabelNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BotonContinuar = new System.Windows.Forms.Button();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.BackColor = System.Drawing.Color.Moccasin;
            this.LabelNombre.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.LabelNombre.ForeColor = System.Drawing.Color.Blue;
            this.LabelNombre.Location = new System.Drawing.Point(14, 428);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(96, 27);
            this.LabelNombre.TabIndex = 3;
            this.LabelNombre.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(138, 427);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(198, 27);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TextBoxNombre_TextChanged);
            // 
            // BotonContinuar
            // 
            this.BotonContinuar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BotonContinuar.Location = new System.Drawing.Point(383, 418);
            this.BotonContinuar.Name = "BotonContinuar";
            this.BotonContinuar.Size = new System.Drawing.Size(148, 50);
            this.BotonContinuar.TabIndex = 1;
            this.BotonContinuar.Text = "Continuar";
            this.BotonContinuar.UseVisualStyleBackColor = false;
            this.BotonContinuar.Click += new System.EventHandler(this.BotonContinuar_Click);
            // 
            // BotonSalir
            // 
            this.BotonSalir.BackColor = System.Drawing.Color.IndianRed;
            this.BotonSalir.Location = new System.Drawing.Point(580, 427);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(106, 41);
            this.BotonSalir.TabIndex = 2;
            this.BotonSalir.Text = "Salir";
            this.BotonSalir.UseVisualStyleBackColor = false;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TPWIinForm_Linares_Falduri.Properties.Resources.Caratula;
            this.pictureBox1.Location = new System.Drawing.Point(4, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(862, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(868, 488);
            this.Controls.Add(this.BotonSalir);
            this.Controls.Add(this.BotonContinuar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BotonContinuar;
        private System.Windows.Forms.Button BotonSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

