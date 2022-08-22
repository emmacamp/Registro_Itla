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
    public partial class Frm_RegistroEdificios : Form
    {
        //variables
        int id;
        //instancias
        N_EdificiosItla DataEdificio = new N_EdificiosItla();
        E_EdiciosItla EntidadEd = new E_EdiciosItla();
        public Frm_RegistroEdificios()
        {
            InitializeComponent();
        }

        private void Frm_RegistroEdificios_Load(object sender, EventArgs e)
        {
            txt_NombreEdificio.Text = "";
            GetEdificios();
        }
        //metodo para traer los edificios
        private void GetEdificios()
        {
            DashboardEdificio.DataSource = DataEdificio.GetEdificios();
            DashboardEdificio.ClearSelection();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            GetEdificios();
            lbl_Nombre.Visible = false;
            DashboardEdificio.ClearSelection();
            txt_NombreEdificio.Text = "";
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                if (txt_NombreEdificio.Text != "")
                {
                    editarEdificio();
                    MessageBox.Show("Se edito el registro", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_NombreEdificio.Text = "";
                    lbl_Nombre.Visible = false;
                    btn_Insertar.Text = "Insertar";
                }
                else
                {
                    MessageBox.Show("Debe suministrar un nombre!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (txt_NombreEdificio.Text != "")
                {
                    EntidadEd.NombreEdificio = txt_NombreEdificio.Text;
                    DataEdificio.AddNewEdificio(EntidadEd);

                    MessageBox.Show("Se guardo el edificio", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_NombreEdificio.Text = "";
                    lbl_Nombre.Visible = false;
                    GetEdificios();
                }
                else
                {
                    MessageBox.Show("Debe suministrar un nombre!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                    EntidadEd.IdEdificio = id;
                    DataEdificio.DeleteEdificio(EntidadEd);
                    GetEdificios();
                }
                else
                {
                    MessageBox.Show("El registro esta a salvo!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //metodo para obtener el id de la fila seleccionada
        private int GetId()
        {
            if (DashboardEdificio.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(DashboardEdificio.CurrentRow.Cells[0].Value.ToString());
                return id;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int id = GetId();
            if (id != 0)
            {
                lbl_Nombre.Visible = true;
                btn_Insertar.Text = "Editar";
                LlenarCampos();
            }
        }
        //llenar campos
        private void LlenarCampos()
        {
            List<E_EdiciosItla> edificio = new List<E_EdiciosItla>();
            edificio = DataEdificio.GetEdificioById(id);
            foreach (var item in edificio)
            {
                txt_NombreEdificio.Text = item.NombreEdificio;
            }
        }
        //metodo editar un edificio
        private void editarEdificio()
        {
            EntidadEd.IdEdificio = id;
            EntidadEd.NombreEdificio = txt_NombreEdificio.Text;
            DataEdificio.UpdateEdificio(EntidadEd);

            GetEdificios();
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
