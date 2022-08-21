using CAPA_ENTIDAD;
using CAPA_NEGOCIO;
using System;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class Pantalla_Registrar : Form
    {

        E_REGISTRO objEntidad = new E_REGISTRO();
        N_REGISTRO objNegocio = new N_REGISTRO();

        public Pantalla_Registrar()
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
            DT_FN.Text = "";
            CB_TU.Text = "";
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
                objEntidad.NombreUS = TB_NOMBRE.Text.ToUpper();
                objEntidad.ApellidoUS = TB_APELLIDO.Text.ToUpper();
                objEntidad.FechaNacimiento = DT_FN.Text.ToUpper();
                objEntidad.TipoUsuario = CB_TU.Text.ToUpper();

                objNegocio.AgregandoUsuarios(objEntidad);

                MessageBox.Show("Se guardo el nuevo usuario");
                LimpiarCaja();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el nuevo usuario" + ex);
            }
        }

        private void BT_VOLVER_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_ADMI PA = new F_ADMI();
            PA.Show();
        }

        private void Pantalla_Registrar_Load(object sender, EventArgs e)
        {

        }
    }
}
