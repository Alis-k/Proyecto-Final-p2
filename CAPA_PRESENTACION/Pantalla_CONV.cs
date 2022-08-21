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
    public partial class Pantalla_CONV : Form
    {
        private bool Editarse = false;

        E_REGISTRO objEntidad ;
        N_REGISTRO objNegocio ;

        public Pantalla_CONV()
        {
            InitializeComponent();
            objEntidad = new E_REGISTRO();
            objNegocio = new N_REGISTRO();
        }

        private void CERRAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pantalla_CONV_Load(object sender, EventArgs e)
        {
            MostrarBuscarTabla("");
            AccionesTabla();
        }

        public void AccionesTabla()
        {
            DGV_CONSULTAS.Columns[0].Visible = false;
            //DGV_CONSULTAS.Columns[1].Width = 40;
            //DGV_CONSULTAS.Columns[2].Width = 40;
            //DGV_CONSULTAS.Columns[3].Width = 40;
            //DGV_CONSULTAS.Columns[4].Width = 100;
            //DGV_CONSULTAS.Columns[5].Width = 40;
            //DGV_CONSULTAS.Columns[6].Width = 130;
            //DGV_CONSULTAS.Columns[7].Width = 40;
            //DGV_CONSULTAS.Columns[8].Width = 130;
            DGV_CONSULTAS.Columns[10].Visible = false;
            DGV_CONSULTAS.Columns[11].Visible = false;
            DGV_CONSULTAS.Columns[12].Visible = false;
            DGV_CONSULTAS.Columns[13].Visible = false;

            DGV_CONSULTAS.ClearSelection();

        }

        public void MostrarBuscarTabla(string buscar)
        {
            DGV_CONSULTAS.DataSource = objNegocio.ListarRegistro(buscar);
        }

        public int ObtenerID()
        {
            int ID;
            if (DGV_CONSULTAS.SelectedRows.Count > 0)
            {
                ID = Convert.ToInt32(DGV_CONSULTAS.CurrentRow.Cells[0].Value.ToString());
                return ID;
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void TB_BUSCAR_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarTabla(TB_BUSCAR.Text);
        }

        private void LimpiarCaja()
        {
            Editarse = false;
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

        private void BT_MODIFICAR_Click(object sender, EventArgs e)
        {
            if (DGV_CONSULTAS.SelectedRows.Count > 0)
            {
                Editarse = true;
                TB_NOMBRE.Text = DGV_CONSULTAS.CurrentRow.Cells[1].Value.ToString();
                TB_APELLIDO.Text = DGV_CONSULTAS.CurrentRow.Cells[2].Value.ToString();
                TB_CARRERA.Text = DGV_CONSULTAS.CurrentRow.Cells[3].Value.ToString();
                TB_CORREO_E.Text = DGV_CONSULTAS.CurrentRow.Cells[4].Value.ToString();
                CB_EDIFICIO.Text = DGV_CONSULTAS.CurrentRow.Cells[5].Value.ToString();
                TB_ENTRADA.Text = DGV_CONSULTAS.CurrentRow.Cells[6].Value.ToString();
                TB_SALIDA.Text = DGV_CONSULTAS.CurrentRow.Cells[7].Value.ToString();
                TB_MOTIVO.Text = DGV_CONSULTAS.CurrentRow.Cells[8].Value.ToString();
                CB_AD.Text = DGV_CONSULTAS.CurrentRow.Cells[9].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea modificar");
            }
        }

        private void BT_GUARDAR_Click(object sender, EventArgs e)
        {

            if (Editarse == false)
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
                    MostrarBuscarTabla("");
                    LimpiarCaja();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar su visita" + ex);
                }
            }
            if (Editarse == true)
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

                    objNegocio.ModificandoVisitas(objEntidad, ObtenerID());

                    MessageBox.Show("Se modifico su visita");
                    MostrarBuscarTabla("");
                    LimpiarCaja();
                    Editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo modifico su visita" + ex);
                }
            }
        }

        private void BT_VOLVER_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_ADMI PA = new F_ADMI();
            PA.Show();
        }

        private void DGV_CONSULTAS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
