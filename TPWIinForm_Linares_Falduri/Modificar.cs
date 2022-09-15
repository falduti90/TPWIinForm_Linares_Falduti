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
    public partial class Modificar : Form
    {
        private Articulo Obj;
        
        public Modificar()
        {
            InitializeComponent();
        }
        public Modificar(Articulo Articulo_Actual)
        {
            Obj = Articulo_Actual;
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {

            TxCodigo.Text=Obj.Codigo;
            TxDesc.Text = Obj.Descripcion;
            TxNombre.Text = Obj.Nombre;
            TxPrecio.Text = Obj.Precio.ToString();
            Marca_Negocio marca_Negocio = new Marca_Negocio();
            Categoria_Negocio categoria_Negocio = new Categoria_Negocio();

            try
            {
                CboMarca.DataSource = marca_Negocio.ListarMarcas();
                CboCategoria.DataSource = categoria_Negocio.ListarCategorias();

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.ToString());
            }



        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            Articulo Art = new Articulo();
            Articulo_Negocio articulo_Negocio = new Articulo_Negocio();

            try
            {
                Art.Codigo = TxCodigo.Text;
                Art.Nombre = TxNombre.Text;
                Art.Descripcion = TxDesc.Text;
                Art.Precio = decimal.Parse(TxPrecio.Text);
                Art.URLImagen = TxImagen.Text;

                Art.Marca = (Marca)CboMarca.SelectedItem;
                Art.Categoria = (Categoria)CboCategoria.SelectedItem;

                articulo_Negocio.Modificar_Articulo(Art);

                MessageBox.Show("El Articulo fue modificado con exito");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
