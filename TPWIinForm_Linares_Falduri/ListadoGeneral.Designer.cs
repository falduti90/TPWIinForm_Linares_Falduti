namespace TPWIinForm_Linares_Falduri
{
    partial class ListadoGeneral
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
            this.Dgv_Ventas = new System.Windows.Forms.DataGridView();
            this.pbxArticulos = new System.Windows.Forms.PictureBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnELiminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Ventas
            // 
            this.Dgv_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Ventas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgv_Ventas.Location = new System.Drawing.Point(12, 43);
            this.Dgv_Ventas.Name = "Dgv_Ventas";
            this.Dgv_Ventas.RowHeadersWidth = 51;
            this.Dgv_Ventas.RowTemplate.Height = 24;
            this.Dgv_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Ventas.Size = new System.Drawing.Size(602, 300);
            this.Dgv_Ventas.TabIndex = 2;
            // 
            // pbxArticulos
            // 
            this.pbxArticulos.Location = new System.Drawing.Point(642, 43);
            this.pbxArticulos.Name = "pbxArticulos";
            this.pbxArticulos.Size = new System.Drawing.Size(370, 300);
            this.pbxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulos.TabIndex = 3;
            this.pbxArticulos.TabStop = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(39, 362);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 4;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnELiminar
            // 
            this.BtnELiminar.Location = new System.Drawing.Point(521, 362);
            this.BtnELiminar.Name = "BtnELiminar";
            this.BtnELiminar.Size = new System.Drawing.Size(75, 23);
            this.BtnELiminar.TabIndex = 5;
            this.BtnELiminar.Text = "Eliminar";
            this.BtnELiminar.UseVisualStyleBackColor = true;
            this.BtnELiminar.Click += new System.EventHandler(this.BtnELiminar_Click);
            // 
            // ListadoGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.BtnELiminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.pbxArticulos);
            this.Controls.Add(this.Dgv_Ventas);
            this.Name = "ListadoGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoGeneral";
            this.Load += new System.EventHandler(this.ListadoGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Ventas;
        private System.Windows.Forms.PictureBox pbxArticulos;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnELiminar;
    }
}