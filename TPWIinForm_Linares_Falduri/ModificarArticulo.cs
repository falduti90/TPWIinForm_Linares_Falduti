using Dominio_Clases;
using Reglas_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TPWIinForm_Linares_Falduri
{
    public partial class ModificarArticulo : Form
    {
        private Articulo Obj = null;
        
        public ModificarArticulo()
        {
            InitializeComponent();
        }
        public ModificarArticulo(Articulo Articulo_Actual)
        {
            this.Obj = Articulo_Actual;
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            Marca_Negocio marca = new Marca_Negocio();
            Categoria_Negocio cat = new Categoria_Negocio();

            try
            {
                CboMarca.DataSource = marca.ListarMarcas();
                CboMarca.ValueMember = "MarcaId";
                CboMarca.DisplayMember = "Descripcion";
                CboCategoria.DataSource = cat.ListarCategorias();
                CboCategoria.ValueMember = "CategoriaId";
                CboCategoria.DisplayMember = "Descripcion";

                TxCodigo.Text = Obj.Codigo;
                TxDesc.Text = Obj.Descripcion;
                TxNombre.Text = Obj.Nombre;
                TxPrecio.Text = Obj.Precio.ToString();
                TxImagen.Text = Obj.URLImagen;

                CboMarca.SelectedValue = Obj.Marca.MarcaId;
                CboCategoria.SelectedValue = Obj.Categoria.CategoriaId;

                cargarImagen(Obj.URLImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            Articulo Art = new Articulo();
            Articulo_Negocio articulo_Negocio = new Articulo_Negocio();

            try
            {
                Art.ArticuloId = Obj.ArticuloId;
                
                Art.Codigo = TxCodigo.Text;
                Art.Nombre = TxNombre.Text;
                Art.Descripcion = TxDesc.Text;
                Art.Precio = decimal.Parse(TxPrecio.Text);
                Art.URLImagen = TxImagen.Text;

                Art.Marca = (Marca)CboMarca.SelectedItem;
                Art.Categoria = (Categoria)CboCategoria.SelectedItem;

                articulo_Negocio.Modificar_Articulo(Art, Art.ArticuloId);

                MessageBox.Show("El Articulo fue modificado con exito");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                Pbox.Load(imagen);
            }
            catch (Exception ex)
            {
                Pbox.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
    }
}
