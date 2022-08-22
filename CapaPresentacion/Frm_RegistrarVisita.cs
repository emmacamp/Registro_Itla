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
    public partial class Frm_RegistrarVisita : Form
    {
        //variables
        int id;
        //instancias
        N_RegistroVisitas LogicaVisita = new N_RegistroVisitas();
        E_RegistroVisitas EntidadVisita = new E_RegistroVisitas();
        N_EdificiosItla DataEdificios = new N_EdificiosItla();
        N_AulaItla DataAulas = new N_AulaItla();
       
        public Frm_RegistrarVisita(int id)
        {
            InitializeComponent();
            if (id != 0)
            {
                this.id = id;
            }
        }
        //metodo que se ejecuta cuando se abre el formulario
        private void Frm_RegistrarVisita_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            ListEdificios();
            ListAulas();
            LlenarCampos();
        }
        private void btn_InsertarVisita_Click(object sender, EventArgs e)
        {
            Validar();
        }
        //metodo para validar los campos y las asigciones en el formulario
        private void Validar()
        {
            int idMessage = 0;

            if (Txt_Nombre.Text == "")
            {
                idMessage = 1;
            }
            else if (Txt_Apellido.Text == "")
            {
                idMessage = 2;
            }
            else if (Txt_Carrera.Text == "")
            {
                idMessage = 3;
            }
            else if (SelectEdificio.SelectedIndex < 0)
            {
                idMessage = 4;
            }
            else if (selectAulas.SelectedIndex < 0)
            {
                idMessage = 5;
            }
            else if (mTxt_Correo.Text == "")
            {
                idMessage = 6;
            }
            else if (!IsValidEmail(mTxt_Correo.Text))
            {
                idMessage = 7;
            }
            else if (rText_MotivoVisita.Text == "")
            {
                idMessage = 8;
            }
            else if (id == 0)
            {
                idMessage = 9;
            }
            else if (id != 0)
            {
                idMessage = 10;
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
                    MessageBox.Show("El campo Carrera esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4:
                    MessageBox.Show("El campo Edificio esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 5:
                    MessageBox.Show("El campo Aula esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 6:
                    MessageBox.Show("El campo Correo esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 7:
                    MessageBox.Show("El Correo no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 8:
                    MessageBox.Show("El campo Motivo Visita esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 9:
                    InsertarVisita();
                    break;
                case 10:
                    EditarVisita();
                    break;
            }
        }
        //metodo para validar el correo
        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //metodo para ingresar un registro
        private void InsertarVisita()
        {
            EntidadVisita.Nombre = Txt_Nombre.Text;
            EntidadVisita.Apellido = Txt_Apellido.Text;
            EntidadVisita.Carrera = Txt_Carrera.Text;
            EntidadVisita.Correo = mTxt_Correo.Text;
            EntidadVisita.HoraEntrada = horaEntrada.Value;
            EntidadVisita.HoraSalida = horaSalida.Value;
            EntidadVisita.MotivoVisita = rText_MotivoVisita.Text;
            EntidadVisita.IdEdificio = SelectEdificio.SelectedIndex +1;
            EntidadVisita.IdAula = selectAulas.SelectedIndex +1;

            LogicaVisita.AddVisita(EntidadVisita);

            MessageBox.Show("Se guardo el registro", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        //llenar campos
        private void LlenarCampos()
        {
            List<E_RegistroVisitas> visita = new List<E_RegistroVisitas>();

            if (id != 0)
            {
                this.Text = "Formulario de Edicion";
                this.lbl_titulo.Text = "Editando Visita";
                this.btn_InsertarVisita.Text = "Editar";

                visita = LogicaVisita.GetVisitasById(id);

                foreach (var item in visita)
                {
                    Txt_Nombre.Text = item.Nombre;
                    Txt_Apellido.Text = item.Apellido;
                    Txt_Carrera.Text = item.Carrera;
                    mTxt_Correo.Text = item.Correo;
                    horaEntrada.Value = item.HoraEntrada;
                    horaSalida.Value = item.HoraSalida;
                    rText_MotivoVisita.Text = item.MotivoVisita;
                    SelectEdificio.SelectedIndex = item.IdEdificio -1;
                    selectAulas.SelectedIndex = item.IdAula -1;
                }
            }
        }
        //metodo para limpiar los campos
        private void LimpiarCampos()
        {
            Txt_Nombre.Text = "";
            Txt_Apellido.Text = "";
            Txt_Carrera.Text = "";
            mTxt_Correo.Text = "";
            horaEntrada.Value = DateTime.Now;
            horaSalida.Value = DateTime.Now;
            rText_MotivoVisita.Text = "";
            SelectEdificio.SelectedIndex = -1;
            selectAulas.SelectedIndex = -1;
        }
        //metodo para editar un registro
        private void EditarVisita()
        {
            EntidadVisita.IdVisita = this.id;
            EntidadVisita.Nombre = Txt_Nombre.Text;
            EntidadVisita.Apellido = Txt_Apellido.Text;
            EntidadVisita.Carrera = Txt_Carrera.Text;
            EntidadVisita.Correo = mTxt_Correo.Text;
            EntidadVisita.HoraEntrada = horaEntrada.Value;
            EntidadVisita.HoraSalida = horaSalida.Value;
            EntidadVisita.MotivoVisita = rText_MotivoVisita.Text;
            EntidadVisita.IdEdificio = SelectEdificio.SelectedIndex + 1;
            EntidadVisita.IdAula = selectAulas.SelectedIndex + 1;

            LogicaVisita.UpdateVisita(EntidadVisita);

            MessageBox.Show("Se edito el registro", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        //metodo para llenar el comboBox para seleccionar los edificios
        private void ListEdificios()
        {
            if (SelectEdificio.Items.Count <= 0)
            {
                foreach (var item in DataEdificios.GetNombreEdificios())
                {
                    SelectEdificio.Items.Add(item.NombreEdificio);
                }
            }
        }
        //metodo para llenar el comboBox para seleccionar las aulas
        private void ListAulas()
        {
            if (selectAulas.Items.Count <= 0)
            {
                foreach (var item in DataAulas.GetNombreAulas())
                {
                    selectAulas.Items.Add(item.NombreAula);
                }
            }
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
