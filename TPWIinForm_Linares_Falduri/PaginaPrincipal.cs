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
    public partial class PaginaPrincipal : Form
    {
        string Nombre_Usuario;
        public PaginaPrincipal(string Nombre)
        {
            InitializeComponent();
            Nombre_Usuario = Nombre;
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            LevelSaludo.Text += Nombre_Usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
