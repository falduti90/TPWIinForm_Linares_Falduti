using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio_Clases;
using Reglas_Negocio;

namespace TPWIinForm_Linares_Falduri
{
    public partial class PaginaPrincipal : Form
    {
        string Nombre_Usuario;
        private List<Articulo> ListaArticulos;

        public PaginaPrincipal()
        {
            InitializeComponent();
        }
        public PaginaPrincipal(string Nombre)
        {
            InitializeComponent();
            Nombre_Usuario = Nombre;
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            Articulo_Negocio Articulos = new Articulo_Negocio();

            LevelSaludo.Text += Nombre_Usuario;
           
            try
            {
                ListaArticulos = Articulos.ListarArticulos();

                Dgv_Ventas.DataSource = ListaArticulos;
                OcultarColumnas();
                SubirImagen(ListaArticulos[0].URLImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            AgregarArticulo Alta = new AgregarArticulo();
            Alta.ShowDialog();
        }

        private void BtnModificar_Click_1(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            articulo = (Articulo)Dgv_Ventas.CurrentRow.DataBoundItem;

            ModificarArticulo modificar = new ModificarArticulo(articulo);
            modificar.ShowDialog();
        }

        private void BtnELiminar_Click(object sender, EventArgs e)
        {
            Articulo_Negocio negocio = new Articulo_Negocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)Dgv_Ventas.CurrentRow.DataBoundItem;

                    negocio.EliminarFisico(seleccionado.ArticuloId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OcultarColumnas()
        {
            Dgv_Ventas.Columns["URLImagen"].Visible = false;
            Dgv_Ventas.Columns["ArticuloId"].Visible = false;
        }

        private void SubirImagen(string NuevaImagen)
        {
            try
            {
                pbxArticulos.Load(NuevaImagen);
            }
            catch (Exception Ex)
            {
                pbxArticulos.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
            }
        }

        private void Dgv_Ventas_SelectionChanged_1(object sender, EventArgs e)
        {
            if (Dgv_Ventas.CurrentRow != null)
            {
                Articulo Obj = (Articulo)Dgv_Ventas.CurrentRow.DataBoundItem;
                SubirImagen(Obj.URLImagen);
            }
        }
    }
}
