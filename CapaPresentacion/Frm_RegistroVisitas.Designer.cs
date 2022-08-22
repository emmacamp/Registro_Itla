
namespace CapaPresentacion
{
    partial class Frm_RegistroVisitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistroVisitas));
            this.DashboardVisitas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AgregarVisita = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_EditarVisita = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_EliminarVisita = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SelectEdificio = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroDeUsuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeEdificiosItlaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeAulasItlaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Refrescar = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DashboardVisitas)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Refrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardVisitas
            // 
            this.DashboardVisitas.AllowUserToAddRows = false;
            this.DashboardVisitas.AllowUserToDeleteRows = false;
            this.DashboardVisitas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DashboardVisitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DashboardVisitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DashboardVisitas.BackgroundColor = System.Drawing.Color.White;
            this.DashboardVisitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DashboardVisitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DashboardVisitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DashboardVisitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DashboardVisitas.ColumnHeadersHeight = 30;
            this.DashboardVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DashboardVisitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardVisitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardVisitas.DoubleBuffered = true;
            this.DashboardVisitas.EnableHeadersVisualStyles = false;
            this.DashboardVisitas.GridColor = System.Drawing.Color.White;
            this.DashboardVisitas.HeaderBgColor = System.Drawing.Color.White;
            this.DashboardVisitas.HeaderForeColor = System.Drawing.Color.Black;
            this.DashboardVisitas.Location = new System.Drawing.Point(0, 0);
            this.DashboardVisitas.MultiSelect = false;
            this.DashboardVisitas.Name = "DashboardVisitas";
            this.DashboardVisitas.ReadOnly = true;
            this.DashboardVisitas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DashboardVisitas.RowHeadersVisible = false;
            this.DashboardVisitas.RowHeadersWidth = 40;
            this.DashboardVisitas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DashboardVisitas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DashboardVisitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DashboardVisitas.Size = new System.Drawing.Size(1145, 258);
            this.DashboardVisitas.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DashboardVisitas);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 258);
            this.panel1.TabIndex = 1;
            // 
            // btn_AgregarVisita
            // 
            this.btn_AgregarVisita.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btn_AgregarVisita.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AgregarVisita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarVisita.BorderRadius = 0;
            this.btn_AgregarVisita.ButtonText = "Agregar";
            this.btn_AgregarVisita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarVisita.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AgregarVisita.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AgregarVisita.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarVisita.Iconimage")));
            this.btn_AgregarVisita.Iconimage_right = null;
            this.btn_AgregarVisita.Iconimage_right_Selected = null;
            this.btn_AgregarVisita.Iconimage_Selected = null;
            this.btn_AgregarVisita.IconMarginLeft = 0;
            this.btn_AgregarVisita.IconMarginRight = 0;
            this.btn_AgregarVisita.IconRightVisible = true;
            this.btn_AgregarVisita.IconRightZoom = 0D;
            this.btn_AgregarVisita.IconVisible = true;
            this.btn_AgregarVisita.IconZoom = 50D;
            this.btn_AgregarVisita.IsTab = false;
            this.btn_AgregarVisita.Location = new System.Drawing.Point(644, 42);
            this.btn_AgregarVisita.Name = "btn_AgregarVisita";
            this.btn_AgregarVisita.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_AgregarVisita.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btn_AgregarVisita.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AgregarVisita.selected = false;
            this.btn_AgregarVisita.Size = new System.Drawing.Size(160, 29);
            this.btn_AgregarVisita.TabIndex = 2;
            this.btn_AgregarVisita.Text = "Agregar";
            this.btn_AgregarVisita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarVisita.Textcolor = System.Drawing.Color.White;
            this.btn_AgregarVisita.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarVisita.Click += new System.EventHandler(this.btn_AgregarVisita_Click);
            // 
            // btn_EditarVisita
            // 
            this.btn_EditarVisita.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btn_EditarVisita.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_EditarVisita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditarVisita.BorderRadius = 0;
            this.btn_EditarVisita.ButtonText = "Editar";
            this.btn_EditarVisita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditarVisita.DisabledColor = System.Drawing.Color.Gray;
            this.btn_EditarVisita.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EditarVisita.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_EditarVisita.Iconimage")));
            this.btn_EditarVisita.Iconimage_right = null;
            this.btn_EditarVisita.Iconimage_right_Selected = null;
            this.btn_EditarVisita.Iconimage_Selected = null;
            this.btn_EditarVisita.IconMarginLeft = 0;
            this.btn_EditarVisita.IconMarginRight = 0;
            this.btn_EditarVisita.IconRightVisible = true;
            this.btn_EditarVisita.IconRightZoom = 0D;
            this.btn_EditarVisita.IconVisible = true;
            this.btn_EditarVisita.IconZoom = 50D;
            this.btn_EditarVisita.IsTab = false;
            this.btn_EditarVisita.Location = new System.Drawing.Point(828, 42);
            this.btn_EditarVisita.Name = "btn_EditarVisita";
            this.btn_EditarVisita.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_EditarVisita.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btn_EditarVisita.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EditarVisita.selected = false;
            this.btn_EditarVisita.Size = new System.Drawing.Size(160, 29);
            this.btn_EditarVisita.TabIndex = 2;
            this.btn_EditarVisita.Text = "Editar";
            this.btn_EditarVisita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EditarVisita.Textcolor = System.Drawing.Color.White;
            this.btn_EditarVisita.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarVisita.Click += new System.EventHandler(this.btn_EditarVisita_Click);
            // 
            // btn_EliminarVisita
            // 
            this.btn_EliminarVisita.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_EliminarVisita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_EliminarVisita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarVisita.BorderRadius = 0;
            this.btn_EliminarVisita.ButtonText = "Eliminar";
            this.btn_EliminarVisita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarVisita.DisabledColor = System.Drawing.Color.Gray;
            this.btn_EliminarVisita.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EliminarVisita.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarVisita.Iconimage")));
            this.btn_EliminarVisita.Iconimage_right = null;
            this.btn_EliminarVisita.Iconimage_right_Selected = null;
            this.btn_EliminarVisita.Iconimage_Selected = null;
            this.btn_EliminarVisita.IconMarginLeft = 0;
            this.btn_EliminarVisita.IconMarginRight = 0;
            this.btn_EliminarVisita.IconRightVisible = true;
            this.btn_EliminarVisita.IconRightZoom = 0D;
            this.btn_EliminarVisita.IconVisible = true;
            this.btn_EliminarVisita.IconZoom = 50D;
            this.btn_EliminarVisita.IsTab = false;
            this.btn_EliminarVisita.Location = new System.Drawing.Point(1010, 42);
            this.btn_EliminarVisita.Name = "btn_EliminarVisita";
            this.btn_EliminarVisita.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_EliminarVisita.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_EliminarVisita.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EliminarVisita.selected = false;
            this.btn_EliminarVisita.Size = new System.Drawing.Size(147, 29);
            this.btn_EliminarVisita.TabIndex = 2;
            this.btn_EliminarVisita.Text = "Eliminar";
            this.btn_EliminarVisita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarVisita.Textcolor = System.Drawing.Color.White;
            this.btn_EliminarVisita.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarVisita.Click += new System.EventHandler(this.btn_EliminarVisita_Click);
            // 
            // SelectEdificio
            // 
            this.SelectEdificio.BackColor = System.Drawing.Color.White;
            this.SelectEdificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectEdificio.FormattingEnabled = true;
            this.SelectEdificio.IntegralHeight = false;
            this.SelectEdificio.Location = new System.Drawing.Point(12, 42);
            this.SelectEdificio.Name = "SelectEdificio";
            this.SelectEdificio.Size = new System.Drawing.Size(280, 21);
            this.SelectEdificio.TabIndex = 3;
            this.SelectEdificio.SelectedIndexChanged += new System.EventHandler(this.SelectEdificio_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeUsuariosToolStripMenuItem1,
            this.registroDeEdificiosItlaToolStripMenuItem1,
            this.registroDeAulasItlaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroDeUsuariosToolStripMenuItem1
            // 
            this.registroDeUsuariosToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.registroDeUsuariosToolStripMenuItem1.Name = "registroDeUsuariosToolStripMenuItem1";
            this.registroDeUsuariosToolStripMenuItem1.Size = new System.Drawing.Size(126, 20);
            this.registroDeUsuariosToolStripMenuItem1.Text = "Registro de Usuarios";
            this.registroDeUsuariosToolStripMenuItem1.Click += new System.EventHandler(this.registroDeUsuariosToolStripMenuItem1_Click);
            // 
            // registroDeEdificiosItlaToolStripMenuItem1
            // 
            this.registroDeEdificiosItlaToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.registroDeEdificiosItlaToolStripMenuItem1.Name = "registroDeEdificiosItlaToolStripMenuItem1";
            this.registroDeEdificiosItlaToolStripMenuItem1.Size = new System.Drawing.Size(144, 20);
            this.registroDeEdificiosItlaToolStripMenuItem1.Text = "Registro de Edificios Itla";
            this.registroDeEdificiosItlaToolStripMenuItem1.Click += new System.EventHandler(this.registroDeEdificiosItlaToolStripMenuItem1_Click);
            // 
            // registroDeAulasItlaToolStripMenuItem1
            // 
            this.registroDeAulasItlaToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.registroDeAulasItlaToolStripMenuItem1.Name = "registroDeAulasItlaToolStripMenuItem1";
            this.registroDeAulasItlaToolStripMenuItem1.Size = new System.Drawing.Size(129, 20);
            this.registroDeAulasItlaToolStripMenuItem1.Text = "Registro de Aulas Itla";
            this.registroDeAulasItlaToolStripMenuItem1.Click += new System.EventHandler(this.registroDeAulasItlaToolStripMenuItem1_Click);
            // 
            // Refrescar
            // 
            this.Refrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refrescar.Image = ((System.Drawing.Image)(resources.GetObject("Refrescar.Image")));
            this.Refrescar.Location = new System.Drawing.Point(307, 42);
            this.Refrescar.Name = "Refrescar";
            this.Refrescar.Size = new System.Drawing.Size(35, 21);
            this.Refrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Refrescar.TabIndex = 5;
            this.Refrescar.TabStop = false;
            this.Refrescar.Click += new System.EventHandler(this.Refrescar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(1137, 0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(20, 24);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Cerrar.TabIndex = 6;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.menuStrip1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.DashboardVisitas;
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.Image")));
            this.btn_Minimizar.Location = new System.Drawing.Point(1117, 0);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(14, 24);
            this.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Minimizar.TabIndex = 7;
            this.btn_Minimizar.TabStop = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 7;
            this.bunifuElipse3.TargetControl = this.btn_AgregarVisita;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 7;
            this.bunifuElipse4.TargetControl = this.btn_EditarVisita;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 7;
            this.bunifuElipse5.TargetControl = this.btn_EliminarVisita;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(432, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(242, 23);
            this.lbl_Titulo.TabIndex = 8;
            this.lbl_Titulo.Text = "Registro de Visitas";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Titulo.Visible = false;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lbl_Titulo;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Frm_RegistroVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1170, 362);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_Minimizar);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.Refrescar);
            this.Controls.Add(this.SelectEdificio);
            this.Controls.Add(this.btn_EliminarVisita);
            this.Controls.Add(this.btn_EditarVisita);
            this.Controls.Add(this.btn_AgregarVisita);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1170, 362);
            this.MinimumSize = new System.Drawing.Size(1170, 362);
            this.Name = "Frm_RegistroVisitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Visitas";
            this.Load += new System.EventHandler(this.Frm_RegistroVisitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DashboardVisitas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Refrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DashboardVisitas;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AgregarVisita;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EditarVisita;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EliminarVisita;
        private System.Windows.Forms.ComboBox SelectEdificio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroDeUsuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroDeEdificiosItlaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroDeAulasItlaToolStripMenuItem1;
        private System.Windows.Forms.PictureBox Refrescar;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.PictureBox btn_Minimizar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.Label lbl_Titulo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}