using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class Frm_RegistroVisitas : Form
    {
        //variables
        int id_RolUsuario;
        //instancias
        E_RegistroVisitas VisitasEntidad = new E_RegistroVisitas();
        N_RegistroVisitas DataVisitas = new N_RegistroVisitas();
        N_EdificiosItla DataEdificios = new N_EdificiosItla();
        Frm_RegistrarVisita RegistrarVisita = new Frm_RegistrarVisita(0);
        Frm_RegistroUsuarios RegistroUsuario = new Frm_RegistroUsuarios();
        Frm_RegistroEdificios RegistroEdificios = new Frm_RegistroEdificios();
        Frm_RegistroAulas RegistroAulas = new Frm_RegistroAulas();
        public Frm_RegistroVisitas(int id_RolUsuario)
        {
            InitializeComponent();
            this.id_RolUsuario = id_RolUsuario;
        }
        private void Frm_RegistroVisitas_Load(object sender, EventArgs e)
        {
            if (id_RolUsuario == 1)
            {
                AppControl();
            }
            ListEdificios();
            SelectEdificio.SelectedIndex = 0;
            GetVisitas();
        }

        private void Refrescar_Click(object sender, EventArgs e)
        {
            SelectEdificio.SelectedIndex = 0;
            GetVisitas();
            AccionesDashboard();
        }
        private void SelectEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            int edificio = SelectEdificio.SelectedIndex;
            if (edificio == 0)
            {
                GetVisitas();
            }
            else
            {
                DashboardVisitas.DataSource = DataVisitas.GetVisitasByEdificio(edificio);
                AccionesDashboard();
            }
        }

        private void btn_AgregarVisita_Click(object sender, EventArgs e)
        {
            RegistrarVisita.ShowDialog();
            GetVisitas();
        }
        private void btn_EditarVisita_Click(object sender, EventArgs e)
        {
            int id = GetId();
            if (id != 0)
            {
                Frm_RegistrarVisita editar = new Frm_RegistrarVisita(id);
                editar.ShowDialog();
                GetVisitas();
            }
        }
        private void btn_EliminarVisita_Click(object sender, EventArgs e)
        {
            //obtiendo el id seleccionado en la tabla de mi metodo getId
            int id = GetId();
            if (id != 0)
            {
                var message = MessageBox.Show("Esta seguro?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    //llamando al metodo delete de la clase de Procedimientos de la capa de Acceso a Datos
                    VisitasEntidad.IdVisita = id;
                    DataVisitas.DeleteVisita(VisitasEntidad);
                    GetVisitas();
                    AccionesDashboard();
                }
                else
                {
                    MessageBox.Show("El registro esta a salvo!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //metodo para llenar el comboBox para seleccionar los edificios
        private void ListEdificios()
        {
            SelectEdificio.Items.Add("Todos los edificios");
            foreach (var item in DataEdificios.GetNombreEdificios())
            {
                SelectEdificio.Items.Add(item.NombreEdificio);
            }
        }

        //metodo privado para obtener todas las visitas
        private void GetVisitas()
        {
            if (SelectEdificio.SelectedIndex == 0)
            {
                DashboardVisitas.DataSource = DataVisitas.GetVisitas();
                AccionesDashboard();
            }
        }
        //metodo acciones sobre el dashboard de visitas
        private void AccionesDashboard()
        {
            DashboardVisitas.Columns[0].Visible = false;
            DashboardVisitas.ClearSelection();
        }

        //metodo para obtener el id de la fila seleccionada
        private int GetId()
        {
            int id;
            if (DashboardVisitas.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(DashboardVisitas.CurrentRow.Cells[0].Value.ToString());
                return id;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        //metodo para controlar los procedimientos segun el rol del usuario
        private void AppControl()
        {
            lbl_Titulo.Visible = true;
            btn_AgregarVisita.Visible = false;
            btn_EditarVisita.Visible = false;
            btn_EliminarVisita.Visible = false;

            registroDeUsuariosToolStripMenuItem1.Visible = false;
            registroDeEdificiosItlaToolStripMenuItem1.Visible = false;
            registroDeAulasItlaToolStripMenuItem1.Visible = false;
        }

        private void registroDeUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroUsuario.ShowDialog();
        }

        private void registroDeEdificiosItlaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroEdificios.ShowDialog();
        }

        private void registroDeAulasItlaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroAulas.ShowDialog();
        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login Login = new Frm_Login();
            Login.Show();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
