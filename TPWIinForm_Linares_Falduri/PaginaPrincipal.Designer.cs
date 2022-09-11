namespace TPWIinForm_Linares_Falduri
{
    partial class PaginaPrincipal
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
            this.LevelSaludo = new System.Windows.Forms.Label();
            this.Dgv_Ventas = new System.Windows.Forms.DataGridView();
            this.pbxArticulos = new System.Windows.Forms.PictureBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // LevelSaludo
            // 
            this.LevelSaludo.AutoSize = true;
            this.LevelSaludo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelSaludo.Location = new System.Drawing.Point(12, 9);
            this.LevelSaludo.Name = "LevelSaludo";
            this.LevelSaludo.Size = new System.Drawing.Size(102, 22);
            this.LevelSaludo.TabIndex = 0;
            this.LevelSaludo.Text = "Bievenido, ";
            // 
            // Dgv_Ventas
            // 
            this.Dgv_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Ventas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgv_Ventas.Location = new System.Drawing.Point(12, 61);
            this.Dgv_Ventas.Name = "Dgv_Ventas";
            this.Dgv_Ventas.RowHeadersWidth = 51;
            this.Dgv_Ventas.RowTemplate.Height = 24;
            this.Dgv_Ventas.Size = new System.Drawing.Size(693, 285);
            this.Dgv_Ventas.TabIndex = 1;
            // 
            // pbxArticulos
            // 
            this.pbxArticulos.Location = new System.Drawing.Point(711, 61);
            this.pbxArticulos.Name = "pbxArticulos";
            this.pbxArticulos.Size = new System.Drawing.Size(340, 285);
            this.pbxArticulos.TabIndex = 2;
            this.pbxArticulos.TabStop = false;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Agregar.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(12, 364);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(84, 38);
            this.Btn_Agregar.TabIndex = 3;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Modificar.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Location = new System.Drawing.Point(102, 364);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(85, 38);
            this.Btn_Modificar.TabIndex = 4;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Location = new System.Drawing.Point(193, 364);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(87, 38);
            this.Btn_Eliminar.TabIndex = 5;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.YellowGreen;
            this.Btn_Exit.Location = new System.Drawing.Point(957, 409);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(112, 39);
            this.Btn_Exit.TabIndex = 6;
            this.Btn_Exit.Text = "Inicio";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.pbxArticulos);
            this.Controls.Add(this.Dgv_Ventas);
            this.Controls.Add(this.LevelSaludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PaginaPrincipal";
            this.Text = "Pagina Principal";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LevelSaludo;
        private System.Windows.Forms.DataGridView Dgv_Ventas;
        private System.Windows.Forms.PictureBox pbxArticulos;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Exit;
    }
}