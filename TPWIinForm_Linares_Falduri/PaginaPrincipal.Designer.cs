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
            this.LabelBusqueda_avanzada = new System.Windows.Forms.Label();
            this.TxBusqueda = new System.Windows.Forms.TextBox();
            this.LabelCp = new System.Windows.Forms.Label();
            this.LabelCr = new System.Windows.Forms.Label();
            this.CbxCriterio = new System.Windows.Forms.ComboBox();
            this.CbxCampo = new System.Windows.Forms.ComboBox();
            this.LabelFiltro = new System.Windows.Forms.Label();
            this.TxFltro = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
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
            this.LevelSaludo.TabIndex = 6;
            this.LevelSaludo.Text = "Bievenido, ";
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Agregar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(0, 516);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(157, 38);
            this.Btn_Agregar.TabIndex = 2;
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
            this.Btn_Exit.TabIndex = 5;
            this.Btn_Exit.Text = "Volver al Inicio";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // BtnELiminar
            // 
            this.BtnELiminar.Location = new System.Drawing.Point(349, 516);
            this.BtnELiminar.Name = "BtnELiminar";
            this.BtnELiminar.Size = new System.Drawing.Size(157, 38);
            this.BtnELiminar.TabIndex = 4;
            this.BtnELiminar.Text = "Eliminar";
            this.BtnELiminar.UseVisualStyleBackColor = true;
            this.BtnELiminar.Click += new System.EventHandler(this.BtnELiminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(173, 516);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(157, 38);
            this.BtnModificar.TabIndex = 3;
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
            this.Dgv_Ventas.TabIndex = 0;
            this.Dgv_Ventas.SelectionChanged += new System.EventHandler(this.Dgv_Ventas_SelectionChanged_1);
            // 
            // LabelBusqueda_avanzada
            // 
            this.LabelBusqueda_avanzada.AutoSize = true;
            this.LabelBusqueda_avanzada.Location = new System.Drawing.Point(24, 468);
            this.LabelBusqueda_avanzada.Name = "LabelBusqueda_avanzada";
            this.LabelBusqueda_avanzada.Size = new System.Drawing.Size(133, 16);
            this.LabelBusqueda_avanzada.TabIndex = 7;
            this.LabelBusqueda_avanzada.Text = "Busqueda Avanzada";
            // 
            // TxBusqueda
            // 
            this.TxBusqueda.Location = new System.Drawing.Point(161, 468);
            this.TxBusqueda.Name = "TxBusqueda";
            this.TxBusqueda.Size = new System.Drawing.Size(318, 22);
            this.TxBusqueda.TabIndex = 1;
            this.TxBusqueda.TextChanged += new System.EventHandler(this.TxBusqueda_TextChanged);
            // 
            // LabelCp
            // 
            this.LabelCp.AutoSize = true;
            this.LabelCp.Location = new System.Drawing.Point(716, 496);
            this.LabelCp.Name = "LabelCp";
            this.LabelCp.Size = new System.Drawing.Size(50, 16);
            this.LabelCp.TabIndex = 10;
            this.LabelCp.Text = "Opcion";
            // 
            // LabelCr
            // 
            this.LabelCr.AutoSize = true;
            this.LabelCr.Location = new System.Drawing.Point(716, 529);
            this.LabelCr.Name = "LabelCr";
            this.LabelCr.Size = new System.Drawing.Size(49, 16);
            this.LabelCr.TabIndex = 11;
            this.LabelCr.Text = "Criterio";
            // 
            // CbxCriterio
            // 
            this.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCriterio.FormattingEnabled = true;
            this.CbxCriterio.Location = new System.Drawing.Point(778, 529);
            this.CbxCriterio.Name = "CbxCriterio";
            this.CbxCriterio.Size = new System.Drawing.Size(121, 24);
            this.CbxCriterio.TabIndex = 12;
            // 
            // CbxCampo
            // 
            this.CbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCampo.FormattingEnabled = true;
            this.CbxCampo.Location = new System.Drawing.Point(778, 496);
            this.CbxCampo.Name = "CbxCampo";
            this.CbxCampo.Size = new System.Drawing.Size(121, 24);
            this.CbxCampo.TabIndex = 13;
            this.CbxCampo.SelectedIndexChanged += new System.EventHandler(this.CbxCampo_SelectedIndexChanged);
            // 
            // LabelFiltro
            // 
            this.LabelFiltro.AutoSize = true;
            this.LabelFiltro.Location = new System.Drawing.Point(716, 571);
            this.LabelFiltro.Name = "LabelFiltro";
            this.LabelFiltro.Size = new System.Drawing.Size(36, 16);
            this.LabelFiltro.TabIndex = 14;
            this.LabelFiltro.Text = "Filtro";
            // 
            // TxFltro
            // 
            this.TxFltro.Location = new System.Drawing.Point(778, 571);
            this.TxFltro.Name = "TxFltro";
            this.TxFltro.Size = new System.Drawing.Size(121, 22);
            this.TxFltro.TabIndex = 15;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(941, 531);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxFltro);
            this.Controls.Add(this.LabelFiltro);
            this.Controls.Add(this.CbxCampo);
            this.Controls.Add(this.CbxCriterio);
            this.Controls.Add(this.LabelCr);
            this.Controls.Add(this.LabelCp);
            this.Controls.Add(this.TxBusqueda);
            this.Controls.Add(this.LabelBusqueda_avanzada);
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
        private System.Windows.Forms.Label LabelBusqueda_avanzada;
        private System.Windows.Forms.TextBox TxBusqueda;
        private System.Windows.Forms.Label LabelCp;
        private System.Windows.Forms.Label LabelCr;
        private System.Windows.Forms.ComboBox CbxCriterio;
        private System.Windows.Forms.ComboBox CbxCampo;
        private System.Windows.Forms.Label LabelFiltro;
        private System.Windows.Forms.TextBox TxFltro;
        private System.Windows.Forms.Button BtnBuscar;
    }
}