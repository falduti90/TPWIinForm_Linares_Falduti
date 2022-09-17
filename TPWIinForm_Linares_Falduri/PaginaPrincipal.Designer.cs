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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            this.Saludo = new System.Windows.Forms.Label();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.BtnELiminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.Dgv_Ventas = new System.Windows.Forms.DataGridView();
            this.LabelBusqueda_avanzada = new System.Windows.Forms.Label();
            this.TxBusqueda = new System.Windows.Forms.TextBox();
            this.LabelCp = new System.Windows.Forms.Label();
            this.LabelCr = new System.Windows.Forms.Label();
            this.CbxCriterio = new System.Windows.Forms.ComboBox();
            this.CbxCampo = new System.Windows.Forms.ComboBox();
            this.LabelFiltro = new System.Windows.Forms.Label();
            this.TxFitro = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LabelFiltroParametros = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbxArticulos = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Saludo
            // 
            this.Saludo.AutoSize = true;
            this.Saludo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Saludo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saludo.ForeColor = System.Drawing.Color.Gray;
            this.Saludo.Location = new System.Drawing.Point(797, 21);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(121, 25);
            this.Saludo.TabIndex = 6;
            this.Saludo.Text = "Bievenido, ";
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.CadetBlue;
            this.Btn_Agregar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(12, 415);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(157, 38);
            this.Btn_Agregar.TabIndex = 2;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.MediumPurple;
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(1007, 537);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(112, 57);
            this.Btn_Exit.TabIndex = 5;
            this.Btn_Exit.Text = "Volver al Inicio";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // BtnELiminar
            // 
            this.BtnELiminar.BackColor = System.Drawing.Color.Crimson;
            this.BtnELiminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnELiminar.Location = new System.Drawing.Point(12, 556);
            this.BtnELiminar.Name = "BtnELiminar";
            this.BtnELiminar.Size = new System.Drawing.Size(157, 38);
            this.BtnELiminar.TabIndex = 4;
            this.BtnELiminar.Text = "Eliminar";
            this.BtnELiminar.UseVisualStyleBackColor = false;
            this.BtnELiminar.Click += new System.EventHandler(this.BtnELiminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnModificar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(12, 484);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(157, 38);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click_1);
            // 
            // Dgv_Ventas
            // 
            this.Dgv_Ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Ventas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.Dgv_Ventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_Ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Ventas.ColumnHeadersHeight = 30;
            this.Dgv_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Ventas.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Ventas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgv_Ventas.EnableHeadersVisualStyles = false;
            this.Dgv_Ventas.GridColor = System.Drawing.SystemColors.Highlight;
            this.Dgv_Ventas.Location = new System.Drawing.Point(12, 103);
            this.Dgv_Ventas.Name = "Dgv_Ventas";
            this.Dgv_Ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Ventas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Ventas.RowHeadersVisible = false;
            this.Dgv_Ventas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Dgv_Ventas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Ventas.RowTemplate.Height = 24;
            this.Dgv_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Ventas.Size = new System.Drawing.Size(766, 300);
            this.Dgv_Ventas.TabIndex = 0;
            this.Dgv_Ventas.SelectionChanged += new System.EventHandler(this.Dgv_Ventas_SelectionChanged_1);
            // 
            // LabelBusqueda_avanzada
            // 
            this.LabelBusqueda_avanzada.AutoSize = true;
            this.LabelBusqueda_avanzada.BackColor = System.Drawing.Color.DarkBlue;
            this.LabelBusqueda_avanzada.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBusqueda_avanzada.ForeColor = System.Drawing.Color.DarkGray;
            this.LabelBusqueda_avanzada.Location = new System.Drawing.Point(260, 415);
            this.LabelBusqueda_avanzada.Name = "LabelBusqueda_avanzada";
            this.LabelBusqueda_avanzada.Size = new System.Drawing.Size(171, 22);
            this.LabelBusqueda_avanzada.TabIndex = 7;
            this.LabelBusqueda_avanzada.Text = "Busqueda  Rapida";
            // 
            // TxBusqueda
            // 
            this.TxBusqueda.Location = new System.Drawing.Point(451, 415);
            this.TxBusqueda.Name = "TxBusqueda";
            this.TxBusqueda.Size = new System.Drawing.Size(298, 22);
            this.TxBusqueda.TabIndex = 1;
            this.TxBusqueda.TextChanged += new System.EventHandler(this.TxBusqueda_TextChanged);
            // 
            // LabelCp
            // 
            this.LabelCp.AutoSize = true;
            this.LabelCp.BackColor = System.Drawing.Color.LightBlue;
            this.LabelCp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCp.Location = new System.Drawing.Point(234, 499);
            this.LabelCp.Name = "LabelCp";
            this.LabelCp.Size = new System.Drawing.Size(76, 18);
            this.LabelCp.TabIndex = 10;
            this.LabelCp.Text = "OPCION";
            // 
            // LabelCr
            // 
            this.LabelCr.AutoSize = true;
            this.LabelCr.BackColor = System.Drawing.Color.LightBlue;
            this.LabelCr.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCr.Location = new System.Drawing.Point(234, 532);
            this.LabelCr.Name = "LabelCr";
            this.LabelCr.Size = new System.Drawing.Size(92, 18);
            this.LabelCr.TabIndex = 11;
            this.LabelCr.Text = "CRITERIO";
            // 
            // CbxCriterio
            // 
            this.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCriterio.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCriterio.FormattingEnabled = true;
            this.CbxCriterio.Location = new System.Drawing.Point(335, 527);
            this.CbxCriterio.Name = "CbxCriterio";
            this.CbxCriterio.Size = new System.Drawing.Size(121, 28);
            this.CbxCriterio.TabIndex = 12;
            // 
            // CbxCampo
            // 
            this.CbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCampo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCampo.FormattingEnabled = true;
            this.CbxCampo.Location = new System.Drawing.Point(335, 494);
            this.CbxCampo.Name = "CbxCampo";
            this.CbxCampo.Size = new System.Drawing.Size(121, 28);
            this.CbxCampo.TabIndex = 13;
            this.CbxCampo.SelectedIndexChanged += new System.EventHandler(this.CbxCampo_SelectedIndexChanged);
            // 
            // LabelFiltro
            // 
            this.LabelFiltro.AutoSize = true;
            this.LabelFiltro.BackColor = System.Drawing.Color.LightBlue;
            this.LabelFiltro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFiltro.Location = new System.Drawing.Point(234, 566);
            this.LabelFiltro.Name = "LabelFiltro";
            this.LabelFiltro.Size = new System.Drawing.Size(71, 18);
            this.LabelFiltro.TabIndex = 14;
            this.LabelFiltro.Text = "FILTRO";
            // 
            // TxFitro
            // 
            this.TxFitro.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxFitro.Location = new System.Drawing.Point(335, 561);
            this.TxFitro.Name = "TxFitro";
            this.TxFitro.Size = new System.Drawing.Size(236, 28);
            this.TxFitro.TabIndex = 15;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBuscar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(463, 494);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(108, 58);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LabelFiltroParametros
            // 
            this.LabelFiltroParametros.AutoSize = true;
            this.LabelFiltroParametros.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LabelFiltroParametros.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFiltroParametros.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelFiltroParametros.Location = new System.Drawing.Point(331, 458);
            this.LabelFiltroParametros.Name = "LabelFiltroParametros";
            this.LabelFiltroParametros.Size = new System.Drawing.Size(231, 22);
            this.LabelFiltroParametros.TabIndex = 18;
            this.LabelFiltroParametros.Text = "  Busqueda      Avanzada ";
            this.LabelFiltroParametros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TPWIinForm_Linares_Falduri.Properties.Resources.Logo___Simple_Minimalista_Lineal___Negro_Blanco1;
            this.pictureBox2.Location = new System.Drawing.Point(121, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(559, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pbxArticulos
            // 
            this.pbxArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.pbxArticulos.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxArticulos.InitialImage")));
            this.pbxArticulos.Location = new System.Drawing.Point(802, 103);
            this.pbxArticulos.Name = "pbxArticulos";
            this.pbxArticulos.Size = new System.Drawing.Size(306, 300);
            this.pbxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulos.TabIndex = 9;
            this.pbxArticulos.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TPWIinForm_Linares_Falduri.Properties.Resources.Diseñopag;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -341);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1155, 960);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1122, 614);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LabelFiltroParametros);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxFitro);
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
            this.Controls.Add(this.Saludo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Saludo;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button BtnELiminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.PictureBox pbxArticulos;
        private System.Windows.Forms.DataGridView Dgv_Ventas;
        private System.Windows.Forms.Label LabelBusqueda_avanzada;
        private System.Windows.Forms.TextBox TxBusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelCp;
        private System.Windows.Forms.Label LabelCr;
        private System.Windows.Forms.ComboBox CbxCriterio;
        private System.Windows.Forms.ComboBox CbxCampo;
        private System.Windows.Forms.Label LabelFiltro;
        private System.Windows.Forms.TextBox TxFitro;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LabelFiltroParametros;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}