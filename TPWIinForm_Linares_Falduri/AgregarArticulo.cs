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
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        private void BotonAgregarArticulo_Click(object sender, EventArgs e)
        {
            Articulo Art=new Articulo();
            Articulo_Negocio articulo_Negocio = new Articulo_Negocio();
            try
            {
                Art.Codigo = TxCodigo.Text;
                Art.Nombre = TxNombre.Text;
                Art.Descripcion = TxDesc.Text;
                Art.Precio = decimal.Parse (TxPrecio.Text);
                Art.URLImagen= TxImagen.Text;

                articulo_Negocio.Insertar_Articulo(Art);
                MessageBox.Show("El registro fue agregado con exito");
                Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            Marca_Negocio marca_Negocio=new Marca_Negocio();
            Categoria_Negocio categoria_Negocio = new Categoria_Negocio ();
            try
            {
                CboMarca.DataSource = marca_Negocio.ListarMarcas();
                CboCategoria.DataSource= categoria_Negocio.ListarCategorias();

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.ToString());
            }
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
