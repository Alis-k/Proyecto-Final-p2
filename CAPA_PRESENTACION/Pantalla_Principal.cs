using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class Pantalla_Principal : Form
    {
        public Pantalla_Principal()
        {
            InitializeComponent();
        }

        private void LimpiarCaja()
        {
            TB_USUARIO.Text = "";
            TB_CONTRASEÑA.Text = "";
            TB_USUARIO.Focus();
        }

        private void BT_RV_Click(object sender, EventArgs e)
        {
            if (TB_USUARIO.Text == "KDPITLA" && TB_CONTRASEÑA.Text == "ITLA123") 
            {
                this.Hide();
                F_ADMI PA = new F_ADMI();
                PA.Show();
            }

            else
            {
                MessageBox.Show("Ha ingresado el usuario o contraseña incorrecto.");
                LimpiarCaja();
            }
        }

        private void PB_CERRAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {

        }

        private void TB_CONTRASEÑA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
