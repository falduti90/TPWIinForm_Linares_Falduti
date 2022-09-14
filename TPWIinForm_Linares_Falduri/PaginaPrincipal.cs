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
        private List<Articulo> Lista;
        public PaginaPrincipal(string Nombre)
        {
            InitializeComponent();
            Nombre_Usuario = Nombre;
        }
        public PaginaPrincipal()
        {
            InitializeComponent();
  
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnListado_Click(object sender, EventArgs e)
        {
            using (ListadoGeneral ListadoGe = new ListadoGeneral())
            ListadoGe.ShowDialog();

        }
        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            LevelSaludo.Text += Nombre_Usuario;
            
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            AgregarArticulo Alta = new AgregarArticulo();
            Alta.ShowDialog();  
        }
    }
}
