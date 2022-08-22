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
    public partial class Frm_RegistrarUsuario : Form
    {
        //variables
        int id;
        //instancias
        N_Usuarios DataUsuario = new N_Usuarios();
        E_Usuarios EntidadUsuario = new E_Usuarios();
        public Frm_RegistrarUsuario(int id)
        {
            InitializeComponent();
            if (id != 0)
            {
                this.id = id;
            }
        }
        private void Frm_RegistrarUsuario_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                ActivarLabels();
            }
            if (selectRol.Items.Count <= 0)
            {
                Roles_Usuario();
            }
            LimpiarCampos();
            LlenarCampos();
        }
        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            Validar();
        }
        //metodo para validar los campos del formulario
        private void Validar()
        {
            int idMessage = 0;

            if (txt_Nombre.Text == "")
            {
                idMessage = 1;
            }
            else if (txt_Apellido.Text == "")
            {
                idMessage = 2;
            }
            else if (txt_Usuario.Text == "")
            {
                idMessage = 3;
            }
            else if (txt_Contreseña.Text == "")
            {
                idMessage = 4;
            }
            else if (txt_Contreseña.Text != txt_ConfirmarContraseña.Text)
            {
                idMessage = 5;
            }
            else if (selectRol.SelectedIndex < 0)
            {
                idMessage = 6;
            }
            else if (id == 0)
            {
                idMessage = 7;
            }
            else if (id != 0)
            {
                idMessage = 8;
            }

            //desplegando mensajes dependiendo la el valor de idMessage
            switch (idMessage)
            {
                case 1:
                    MessageBox.Show("EL campo Nombre esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("El campo Apellido esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("El campo Usuario esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4:
                    MessageBox.Show("El campo Contraseña esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 5:
                    MessageBox.Show("Las Contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 6:
                    MessageBox.Show("El campo Rol Usuario esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 7:
                    AgregarUsuario();
                    break;
                case 8:
                    EditarUsuario();
                    break;
            }
        }
        private void txt_Contreseña_OnValueChanged(object sender, EventArgs e)
        {
            txt_Contreseña.isPassword = true;
        }
        private void txt_ConfirmarContraseña_OnValueChanged(object sender, EventArgs e)
        {
            txt_ConfirmarContraseña.isPassword = true;
        }
        //metodo para llenar el combobox de roles usuarios
        private void Roles_Usuario()
        {
            List<E_RolUsuario> roles = new List<E_RolUsuario>();
            roles = DataUsuario.GetRoles();

            foreach (var item in roles)
            {
                selectRol.Items.Add(item.RolUsuario);
            }
        }
        //metodo para llenar los campos del formulario con la informacion del usuario
        private void LlenarCampos()
        {
            List<E_Usuarios> usuario = new List<E_Usuarios>();
            
            if (id != 0)
            {
                this.Text = "Formulario de Edicion";
                this.lbl_Titulo.Text = "Editando Usuario";
                this.btn_Insertar.Text = "Editar";

                usuario = DataUsuario.GetUsuario(id);

                foreach (var item in usuario)
                {
                    txt_Nombre.Text = item.Nombre;
                    txt_Apellido.Text = item.Apellido;
                    txt_Usuario.Text = item.Usuario;
                    txt_Contreseña.Text = item.Contraseña;
                    txt_ConfirmarContraseña.Text = item.Contraseña;
                    fecha_Nacimiento.Value = item.Fecha_Nacimiento;
                    selectRol.SelectedIndex = item.IdRolUsuario -1;
                }
            }
        }
        //metodo para limpiar los cambos
        private void LimpiarCampos()
        {
            txt_Nombre.Text = "";
            txt_Apellido.Text = "";
            txt_Usuario.Text = "";
            txt_Contreseña.Text = "";
            txt_ConfirmarContraseña.Text = "";
            fecha_Nacimiento.Value = DateTime.Now;
            selectRol.SelectedIndex = -1;
        }
        //metodo para agregar un nuevo usuario
        private void AgregarUsuario()
        {
            EntidadUsuario.Nombre = txt_Nombre.Text;
            EntidadUsuario.Apellido = txt_Apellido.Text;
            EntidadUsuario.Usuario = txt_Usuario.Text;
            EntidadUsuario.Contraseña = txt_Contreseña.Text;
            EntidadUsuario.Fecha_Nacimiento = fecha_Nacimiento.Value;
            EntidadUsuario.IdRolUsuario = selectRol.SelectedIndex + 1;

            DataUsuario.AddNewUser(EntidadUsuario);

            MessageBox.Show("Se guardo el nuevo usuario", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        //metodo para editar un usuario
        private void EditarUsuario()
        {
            EntidadUsuario.IdUser = id;
            EntidadUsuario.Nombre = txt_Nombre.Text;
            EntidadUsuario.Apellido = txt_Apellido.Text;
            EntidadUsuario.Usuario = txt_Usuario.Text;
            EntidadUsuario.Contraseña = txt_Contreseña.Text;
            EntidadUsuario.Fecha_Nacimiento = fecha_Nacimiento.Value;
            EntidadUsuario.IdRolUsuario = selectRol.SelectedIndex + 1;

            DataUsuario.UpdateUser(EntidadUsuario);

            MessageBox.Show("Se edito el usuario", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        //activar labels
        private void ActivarLabels()
        {
            lbl_Nombre.Visible = true;
            lbl_Apellido.Visible = true;
            lbl_Usuario.Visible = true;
            lbl_Contraseña.Visible = true;
            lbl_ConfirmarCon.Visible = true;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
