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
using CapaEntidad.Modelos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Frm_RegistroUsuarios : Form
    {
        //instancias
        N_Usuarios DataUsuario = new N_Usuarios();
        E_Usuarios EntidadUsuario = new E_Usuarios();
        Frm_RegistrarUsuario RegistrarUsuario = new Frm_RegistrarUsuario(0);
        public Frm_RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void Frm_RegistroUsuarios_Load(object sender, EventArgs e)
        {
            GetUsuarios();
            DashboardUsuarios.ClearSelection();
        }
        private void refrescar_Click(object sender, EventArgs e)
        {
            txt_Buscar.text = "";
            GetUsuarios();
            DashboardUsuarios.ClearSelection();
        }
        private void txt_Buscar_OnTextChange(object sender, EventArgs e)
        {
            string usuario = txt_Buscar.text;
            DashboardUsuarios.DataSource = DataUsuario.GetUsuarioByUsuario(usuario);
            AccionesDashboard();
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            RegistrarUsuario.ShowDialog();
            GetUsuarios();
        }
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int id = GetId();
            if (id != 0)
            {
                Frm_RegistrarUsuario editar = new Frm_RegistrarUsuario(id);
                editar.ShowDialog();
                GetUsuarios();
            }
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            //obtiendo el id seleccionado en la tabla de mi metodo getId
            int id = GetId();
            if (id != 0)
            {
                var message = MessageBox.Show("Esta seguro?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    //llamando al metodo delete de la clase de Procedimientos de la capa de Acceso a Datos
                    EntidadUsuario.IdUser = id;
                    DataUsuario.DeleteUser(EntidadUsuario);
                    GetUsuarios();
                    AccionesDashboard();
                }
                else
                {
                    MessageBox.Show("El registro esta a salvo!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
       
        //metodo para listar todos los usuarios
        private void GetUsuarios()
        {
            DashboardUsuarios.DataSource = DataUsuario.GetUsuarios();
            AccionesDashboard();
        }
        //metodo acciones sobre el dashboard de usuarios
        private void AccionesDashboard()
        {
            DashboardUsuarios.Columns[0].Visible = false;
            DashboardUsuarios.ClearSelection();
        }
        //metodo para obtener el id de la fila seleccionada
        private int GetId()
        {
            int id;
            if (DashboardUsuarios.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(DashboardUsuarios.CurrentRow.Cells[0].Value.ToString());
                return id;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
