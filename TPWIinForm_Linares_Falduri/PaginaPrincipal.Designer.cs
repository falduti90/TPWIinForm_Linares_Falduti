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
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.BtnELiminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.pbxArticulos = new System.Windows.Forms.PictureBox();
            this.Dgv_Ventas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ventas)).BeginInit();
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
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Agregar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(12, 557);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(157, 38);
            this.Btn_Agregar.TabIndex = 3;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.Magenta;
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(1058, 584);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(112, 57);
            this.Btn_Exit.TabIndex = 6;
            this.Btn_Exit.Text = "Volver al Inicio";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // BtnELiminar
            // 
            this.BtnELiminar.Location = new System.Drawing.Point(377, 567);
            this.BtnELiminar.Name = "BtnELiminar";
            this.BtnELiminar.Size = new System.Drawing.Size(75, 23);
            this.BtnELiminar.TabIndex = 11;
            this.BtnELiminar.Text = "Eliminar";
            this.BtnELiminar.UseVisualStyleBackColor = true;
            this.BtnELiminar.Click += new System.EventHandler(this.BtnELiminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(220, 567);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 10;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click_1);
            // 
            // pbxArticulos
            // 
            this.pbxArticulos.Location = new System.Drawing.Point(800, 147);
            this.pbxArticulos.Name = "pbxArticulos";
            this.pbxArticulos.Size = new System.Drawing.Size(370, 300);
            this.pbxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulos.TabIndex = 9;
            this.pbxArticulos.TabStop = false;
            // 
            // Dgv_Ventas
            // 
            this.Dgv_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Ventas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgv_Ventas.Location = new System.Drawing.Point(12, 147);
            this.Dgv_Ventas.Name = "Dgv_Ventas";
            this.Dgv_Ventas.RowHeadersWidth = 51;
            this.Dgv_Ventas.RowTemplate.Height = 24;
            this.Dgv_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Ventas.Size = new System.Drawing.Size(762, 300);
            this.Dgv_Ventas.TabIndex = 8;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.BtnELiminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.pbxArticulos);
            this.Controls.Add(this.Dgv_Ventas);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.LevelSaludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LevelSaludo;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button BtnELiminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.PictureBox pbxArticulos;
        private System.Windows.Forms.DataGridView Dgv_Ventas;
    }
}