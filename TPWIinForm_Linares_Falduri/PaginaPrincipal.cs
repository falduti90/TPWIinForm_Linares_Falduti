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
            this.CargarPagina();

            CbxCampo.Items.Add("Precio");
            CbxCampo.Items.Add("Nombre");
            CbxCampo.Items.Add("Descripcion");

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            AgregarArticulo NuevoArticoForm = new AgregarArticulo();
            NuevoArticoForm.ShowDialog();

            this.CargarPagina();
        }

        private void BtnModificar_Click_1(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();

            articulo = (Articulo)Dgv_Ventas.CurrentRow.DataBoundItem;
            ModificarArticulo ModificarArticuloForm = new ModificarArticulo(articulo);
            ModificarArticuloForm.ShowDialog();
            this.CargarPagina();
        }

        private void BtnELiminar_Click(object sender, EventArgs e)
        {
            Articulo_Negocio Articulo = new Articulo_Negocio();
            Articulo ArticuloSeleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               
                if (respuesta == DialogResult.Yes)
                {
                    ArticuloSeleccionado = (Articulo)Dgv_Ventas.CurrentRow.DataBoundItem;

                    Articulo.EliminarFisico(ArticuloSeleccionado.ArticuloId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.CargarPagina();
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

        private void CargarPagina()
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

        private void TxBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> ListaAvanzada;
            string Filtro= TxBusqueda.Text;

            if (Filtro.Length >= 3)
            {
               ListaAvanzada = ListaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(Filtro.ToUpper()) || x.Codigo.ToUpper().Contains(Filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(Filtro.ToUpper())||x.Categoria.Descripcion.ToUpper().Contains(Filtro.ToUpper()));
            }
            else
            {
                ListaAvanzada = ListaArticulos;
            }

            Dgv_Ventas.DataSource = null;
            Dgv_Ventas.DataSource = ListaAvanzada;
            OcultarColumnas();
        }

        private void CbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Opcion = CbxCampo.SelectedItem.ToString();
            if (Opcion == "Precio")
            {
                CbxCriterio.Items.Clear();
                CbxCriterio.Items.Add("Mayor a ");
                CbxCriterio.Items.Add("Menor a ");
                CbxCriterio.Items.Add("Igual a ");

            }
            else
            {
                CbxCriterio.Items.Clear();
                CbxCriterio.Items.Add("Comienza con");
                CbxCriterio.Items.Add("Termina con");
                CbxCriterio.Items.Add("Contine");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Articulo_Negocio articulo_Negocio = new Articulo_Negocio(); 
            try
            {
            string Campo=CbxCampo.SelectedItem.ToString();
            string Criterio=CbxCriterio.SelectedItem.ToString();
            string Filtro = TxBusqueda.Text;
            Dgv_Ventas.DataSource= articulo_Negocio.Filtrar( Campo, Criterio, Filtro);

            }
            catch (Exception ex)
            {
                        MessageBox.Show(ex.ToString());
            }
        }
    }
}
