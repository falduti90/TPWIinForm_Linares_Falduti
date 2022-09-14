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
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            BotonContinuar.Enabled = false;
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }


        private void ControlBotones()
        {
            if (TxtNombre.Text.Trim() != string.Empty && TxtNombre.Text.All(char.IsLetter))
            {
               BotonContinuar.Enabled = true;
                errorProvider1.SetError(TxtNombre, "");
            }
            else
            {
                if (!(TxtNombre.Text.All(char.IsLetter)))
                {
                    errorProvider1.SetError(TxtNombre, "El nombre solo contiene letras");
                }
                else { errorProvider1.SetError(TxtNombre, "Debe introducir su nombre"); }
            }
            //btnSolicitarPrestamo.Enabled = false;
            TxtNombre.Focus();
        }
        private void TextBoxNombre_TextChanged(object sender, EventArgs e)
        {
            ControlBotones();
        }

        private void BotonContinuar_Click(object sender, EventArgs e)
        {
            using (PaginaPrincipal VentanaPrincipal = new PaginaPrincipal((string)TxtNombre.Text))
                VentanaPrincipal.ShowDialog();
        }
    }
}
