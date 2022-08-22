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
    public partial class Frm_Login : Form
    {
        //variables
        int rolUsuario;
        //instancias
        N_Usuarios User = new N_Usuarios();
        E_Usuarios UserEntidad = new E_Usuarios();
        
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Txt_Contraseña_OnValueChanged(object sender, EventArgs e)
        {
            Txt_Contraseña.isPassword = true;
        }

        private void Btn_InicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = Txt_Usuario.Text;
            string contraseña = Txt_Contraseña.Text;
            UserEntidad.Usuario = usuario;
            UserEntidad.Contraseña = contraseña;

            string[] userDetails = User.ValidateUser(UserEntidad);
            if (usuario == "" && contraseña == "")
            {
                MessageBox.Show("Debe ingresar su usuario y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (usuario == userDetails[0] && contraseña == userDetails[1])
                {
                    rolUsuario = Convert.ToInt32(userDetails[2]);
                    Frm_RegistroVisitas RegistroVisitas = new Frm_RegistroVisitas(rolUsuario);
                    this.Hide();
                    RegistroVisitas.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
