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
    public partial class Frm_RegistroAulas : Form
    {
        //variables
        int id = 0;
        //instancias
        N_AulaItla DataAula = new N_AulaItla();
        E_AulaItla EntidadAu = new E_AulaItla();
        public Frm_RegistroAulas()
        {
            InitializeComponent();
        }

        private void Frm_RegistroAulas_Load(object sender, EventArgs e)
        {
            txt_NombreAula.Text = "";
            GetAulas();
        }
        //metodo para listar las aulas
        private void GetAulas()
        {
            DashboardAulas.DataSource = DataAula.GetAulas();
            DashboardAulas.ClearSelection();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            GetAulas();
            lbl_Nombre.Visible = false;
            btn_Insertar.Text = "Insertar Aula";
            txt_NombreAula.Text = "";
        }
        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                if (txt_NombreAula.Text != "")
                {
                    editarAula();
                    MessageBox.Show("Se edito el registro", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_NombreAula.Text = "";
                    lbl_Nombre.Visible = false;
                    btn_Insertar.Text = "Insertar Aula";
                }
                else
                {
                    MessageBox.Show("Debe suministrar un nombre", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (txt_NombreAula.Text != "")
                {
                    EntidadAu.NombreAula = txt_NombreAula.Text;
                    DataAula.AddNewAula(EntidadAu);

                    MessageBox.Show("Se guardo el edificio", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_NombreAula.Text = "";
                    lbl_Nombre.Visible = false;
                    GetAulas();
                }
                else
                {
                    MessageBox.Show("Debe suministrar un nombre", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int id = GetId();
            if (id != 0)
            {
                lbl_Nombre.Visible = true;
                btn_Insertar.Text = "Editar Aula";
                LlenarCampos();
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
                    EntidadAu.IdAula = id;
                    DataAula.DeleteAula(EntidadAu);
                    GetAulas();
                }
                else
                {
                    MessageBox.Show("El registro esta a salvo!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //metodo editar un edificio
        private void editarAula()
        {
            EntidadAu.IdAula = id;
            EntidadAu.NombreAula = txt_NombreAula.Text;
            DataAula.UpdateAula(EntidadAu);

            GetAulas();
        }
        //metodo para obtener el id de la fila seleccionada
        private int GetId()
        {
            if (DashboardAulas.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(DashboardAulas.CurrentRow.Cells[0].Value.ToString());
                return id;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        //llenar campos
        private void LlenarCampos()
        {
            List<E_AulaItla> edificio = new List<E_AulaItla>();
            edificio = DataAula.GetAulaById(id);
            foreach (var item in edificio)
            {
                txt_NombreAula.Text = item.NombreAula;
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
