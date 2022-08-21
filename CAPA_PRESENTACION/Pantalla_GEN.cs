using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ENTIDAD;
using CAPA_NEGOCIO;

namespace CAPA_PRESENTACION
{
    public partial class Pantalla_GEN : Form
    {

        E_REGISTRO objEntidad = new E_REGISTRO();
        N_REGISTRO objNegocio = new N_REGISTRO();

        public Pantalla_GEN()
        {
            InitializeComponent();
        }

        private void CERRAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LimpiarCaja()
        {
            TB_NOMBRE.Text = "";
            TB_APELLIDO.Text = "";
            TB_CARRERA.Text = "";
            TB_CORREO_E.Text = "";
            CB_EDIFICIO.Text = "";
            TB_ENTRADA.Text = "";
            TB_SALIDA.Text = "";
            TB_MOTIVO.Text = "";
            CB_AD.Text = "";
            TB_NOMBRE.Focus();
        }

        private void BT_NUEVO_Click(object sender, EventArgs e)
        {
            LimpiarCaja();
        }

        private void BT_GUARDAR_Click(object sender, EventArgs e)
        {
            try
                {
                    objEntidad.Nombre = TB_NOMBRE.Text.ToUpper();
                    objEntidad.Apellido = TB_APELLIDO.Text.ToUpper();
                    objEntidad.Carrera = TB_CARRERA.Text.ToUpper();
                    objEntidad.CorreoElectronico = TB_CORREO_E.Text.ToUpper();
                    objEntidad.Edificio = CB_EDIFICIO.Text.ToUpper();
                    objEntidad.HoraEntrada = TB_ENTRADA.Text.ToUpper();
                    objEntidad.HoraSalida = TB_SALIDA.Text.ToUpper();
                    objEntidad.MotivoVisita = TB_MOTIVO.Text.ToUpper();
                    objEntidad.AulaLugar = CB_AD.Text.ToUpper();

                    objNegocio.AgregandoVisitas(objEntidad);

                    MessageBox.Show("Se guardo su visita");
                    LimpiarCaja();
                }
            catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar su visita" + ex);
                }
        }

        private void BT_VOLVER_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_ADMI PP = new F_ADMI();
            PP.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
