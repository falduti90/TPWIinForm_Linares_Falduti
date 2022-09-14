namespace TPWIinForm_Linares_Falduri
{
    partial class AgregarArticulo
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
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.LevelNombre = new System.Windows.Forms.Label();
            this.LevelDescripcion = new System.Windows.Forms.Label();
            this.LavelPrecio = new System.Windows.Forms.Label();
            this.LavelUrlImagen = new System.Windows.Forms.Label();
            this.TxCodigo = new System.Windows.Forms.TextBox();
            this.TxImagen = new System.Windows.Forms.TextBox();
            this.TxPrecio = new System.Windows.Forms.TextBox();
            this.TxDesc = new System.Windows.Forms.TextBox();
            this.TxNombre = new System.Windows.Forms.TextBox();
            this.BotonAgregarArticulo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.LabelMarca = new System.Windows.Forms.Label();
            this.LabelCategoria = new System.Windows.Forms.Label();
            this.CboMarca = new System.Windows.Forms.ComboBox();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.AutoSize = true;
            this.LabelCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodigo.Location = new System.Drawing.Point(68, 48);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(94, 30);
            this.LabelCodigo.TabIndex = 0;
            this.LabelCodigo.Text = "Codigo";
            this.LabelCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LevelNombre
            // 
            this.LevelNombre.AutoSize = true;
            this.LevelNombre.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelNombre.Location = new System.Drawing.Point(56, 88);
            this.LevelNombre.Name = "LevelNombre";
            this.LevelNombre.Size = new System.Drawing.Size(106, 30);
            this.LevelNombre.TabIndex = 1;
            this.LevelNombre.Text = "Nombre";
            this.LevelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LevelDescripcion
            // 
            this.LevelDescripcion.AutoSize = true;
            this.LevelDescripcion.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelDescripcion.Location = new System.Drawing.Point(18, 135);
            this.LevelDescripcion.Name = "LevelDescripcion";
            this.LevelDescripcion.Size = new System.Drawing.Size(144, 30);
            this.LevelDescripcion.TabIndex = 2;
            this.LevelDescripcion.Text = "Descripcion";
            this.LevelDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LavelPrecio
            // 
            this.LavelPrecio.AutoSize = true;
            this.LavelPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LavelPrecio.Location = new System.Drawing.Point(55, 183);
            this.LavelPrecio.Name = "LavelPrecio";
            this.LavelPrecio.Size = new System.Drawing.Size(102, 30);
            this.LavelPrecio.TabIndex = 3;
            this.LavelPrecio.Text = "Precio $";
            this.LavelPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LavelUrlImagen
            // 
            this.LavelUrlImagen.AutoSize = true;
            this.LavelUrlImagen.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LavelUrlImagen.Location = new System.Drawing.Point(33, 223);
            this.LavelUrlImagen.Name = "LavelUrlImagen";
            this.LavelUrlImagen.Size = new System.Drawing.Size(129, 30);
            this.LavelUrlImagen.TabIndex = 4;
            this.LavelUrlImagen.Text = "UrlImagen";
            this.LavelUrlImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxCodigo
            // 
            this.TxCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxCodigo.Location = new System.Drawing.Point(185, 48);
            this.TxCodigo.Name = "TxCodigo";
            this.TxCodigo.Size = new System.Drawing.Size(231, 31);
            this.TxCodigo.TabIndex = 5;
            // 
            // TxImagen
            // 
            this.TxImagen.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxImagen.Location = new System.Drawing.Point(187, 222);
            this.TxImagen.Name = "TxImagen";
            this.TxImagen.Size = new System.Drawing.Size(231, 31);
            this.TxImagen.TabIndex = 6;
            // 
            // TxPrecio
            // 
            this.TxPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxPrecio.Location = new System.Drawing.Point(187, 185);
            this.TxPrecio.Name = "TxPrecio";
            this.TxPrecio.Size = new System.Drawing.Size(231, 31);
            this.TxPrecio.TabIndex = 7;
            // 
            // TxDesc
            // 
            this.TxDesc.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDesc.Location = new System.Drawing.Point(187, 137);
            this.TxDesc.Name = "TxDesc";
            this.TxDesc.Size = new System.Drawing.Size(231, 31);
            this.TxDesc.TabIndex = 8;
            // 
            // TxNombre
            // 
            this.TxNombre.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxNombre.Location = new System.Drawing.Point(185, 90);
            this.TxNombre.Name = "TxNombre";
            this.TxNombre.Size = new System.Drawing.Size(233, 31);
            this.TxNombre.TabIndex = 9;
            // 
            // BotonAgregarArticulo
            // 
            this.BotonAgregarArticulo.Location = new System.Drawing.Point(204, 363);
            this.BotonAgregarArticulo.Name = "BotonAgregarArticulo";
            this.BotonAgregarArticulo.Size = new System.Drawing.Size(244, 65);
            this.BotonAgregarArticulo.TabIndex = 10;
            this.BotonAgregarArticulo.Text = "Agregar";
            this.BotonAgregarArticulo.UseVisualStyleBackColor = true;
            this.BotonAgregarArticulo.Click += new System.EventHandler(this.BotonAgregarArticulo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BotonSalir
            // 
            this.BotonSalir.Location = new System.Drawing.Point(636, 389);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(152, 49);
            this.BotonSalir.TabIndex = 12;
            this.BotonSalir.Text = "Cancelar/Volver";
            this.BotonSalir.UseVisualStyleBackColor = true;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // LabelMarca
            // 
            this.LabelMarca.AutoSize = true;
            this.LabelMarca.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.LabelMarca.Location = new System.Drawing.Point(80, 263);
            this.LabelMarca.Name = "LabelMarca";
            this.LabelMarca.Size = new System.Drawing.Size(82, 30);
            this.LabelMarca.TabIndex = 13;
            this.LabelMarca.Text = "Marca";
            this.LabelMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelCategoria
            // 
            this.LabelCategoria.AutoSize = true;
            this.LabelCategoria.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.LabelCategoria.Location = new System.Drawing.Point(37, 307);
            this.LabelCategoria.Name = "LabelCategoria";
            this.LabelCategoria.Size = new System.Drawing.Size(151, 38);
            this.LabelCategoria.TabIndex = 14;
            this.LabelCategoria.Text = "Categoria";
            this.LabelCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CboMarca
            // 
            this.CboMarca.FormattingEnabled = true;
            this.CboMarca.Location = new System.Drawing.Point(187, 271);
            this.CboMarca.Name = "CboMarca";
            this.CboMarca.Size = new System.Drawing.Size(233, 24);
            this.CboMarca.TabIndex = 15;
            // 
            // CboCategoria
            // 
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(187, 313);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(233, 24);
            this.CboCategoria.TabIndex = 16;
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CboCategoria);
            this.Controls.Add(this.CboMarca);
            this.Controls.Add(this.LabelCategoria);
            this.Controls.Add(this.LabelMarca);
            this.Controls.Add(this.BotonSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BotonAgregarArticulo);
            this.Controls.Add(this.TxNombre);
            this.Controls.Add(this.TxDesc);
            this.Controls.Add(this.TxPrecio);
            this.Controls.Add(this.TxImagen);
            this.Controls.Add(this.TxCodigo);
            this.Controls.Add(this.LavelUrlImagen);
            this.Controls.Add(this.LavelPrecio);
            this.Controls.Add(this.LevelDescripcion);
            this.Controls.Add(this.LevelNombre);
            this.Controls.Add(this.LabelCodigo);
            this.Name = "AgregarArticulo";
            this.Text = "AgregarArticulo";
            this.Load += new System.EventHandler(this.AgregarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCodigo;
        private System.Windows.Forms.Label LevelNombre;
        private System.Windows.Forms.Label LevelDescripcion;
        private System.Windows.Forms.Label LavelPrecio;
        private System.Windows.Forms.Label LavelUrlImagen;
        private System.Windows.Forms.TextBox TxCodigo;
        private System.Windows.Forms.TextBox TxImagen;
        private System.Windows.Forms.TextBox TxPrecio;
        private System.Windows.Forms.TextBox TxDesc;
        private System.Windows.Forms.TextBox TxNombre;
        private System.Windows.Forms.Button BotonAgregarArticulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BotonSalir;
        private System.Windows.Forms.Label LabelMarca;
        private System.Windows.Forms.Label LabelCategoria;
        private System.Windows.Forms.ComboBox CboMarca;
        private System.Windows.Forms.ComboBox CboCategoria;
    }
}