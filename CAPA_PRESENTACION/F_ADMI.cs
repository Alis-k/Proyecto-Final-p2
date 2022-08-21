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
    public partial class F_ADMI : Form
    {
        public F_ADMI()
        {
            InitializeComponent();
        }

        private void CERRAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Btconsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pantalla_CONV PC = new Pantalla_CONV();
            PC.Show();
        }

        private void Btvisitas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pantalla_GEN PG = new Pantalla_GEN();
            PG.Show();
        }

        private void Btusuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pantalla_Registrar PR = new Pantalla_Registrar();
            PR.Show();
        }

        private void Btprincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pantalla_Principal PP = new Pantalla_Principal();
            PP.Show();
        }
    }
}
