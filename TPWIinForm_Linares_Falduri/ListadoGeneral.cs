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
    public partial class ListadoGeneral : Form
    {
        private List<Articulo> ListaArticulos;
        public ListadoGeneral()
        {
            InitializeComponent();
        }

        private void ListadoGeneral_Load(object sender, EventArgs e)
        {
            Articulo_Negocio negocio = new Articulo_Negocio();
            ListaArticulos = negocio.ListarArticulos();
            Dgv_Ventas.DataSource = ListaArticulos;
            pbxArticulos.Load(ListaArticulos[0].URLImagen);
            Dgv_Ventas.Columns["URLImagen"].Visible = false;
            OcultarColumnas();
        }

        private void OcultarColumnas()
        {
            Dgv_Ventas.Columns["URLImagen"].Visible = false;
            Dgv_Ventas.Columns["ArticuloId"].Visible = false;
            // Dgv_Ventas.Columns["CategoriaId"].Visible = false;
            //Dgv_Ventas.Columns["MarcaId"].Visible = false;
        }
        private void Dgv_Ventas_SelectionChanged(object sender, EventArgs e)
        {

            Articulo Obj = (Articulo)Dgv_Ventas.CurrentRow.DataBoundItem;
            SubirImagen(Obj.URLImagen);
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            articulo = (Articulo)Dgv_Ventas.CurrentRow.DataBoundItem;

            Modificar modificar = new Modificar(articulo);
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
    }
}
