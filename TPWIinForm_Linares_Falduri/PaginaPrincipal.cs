using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private List<Articulo>ListaArticulos;
        string Nombre_Usuario;
        public PaginaPrincipal(string Nombre)
        {
            InitializeComponent();
            Nombre_Usuario = Nombre;
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            LevelSaludo.Text += Nombre_Usuario;
            Articulo_Negocio negocio = new Articulo_Negocio();
            ListaArticulos = negocio.ListarArticulos();
            Dgv_Ventas.DataSource = ListaArticulos;
            pbxArticulos.Load(ListaArticulos[0].URLImagen);
            Dgv_Ventas.Columns["URLImagen"].Visible = false;
            OcultarColumnas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_Ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
