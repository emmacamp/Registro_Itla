
namespace CapaPresentacion
{
    partial class Frm_RegistroEdificios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistroEdificios));
            this.DashboardEdificio = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.btn_Insertar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_NombreEdificio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Editar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Refrescar = new System.Windows.Forms.PictureBox();
            this.Cabezera = new System.Windows.Forms.Panel();
            this.btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DashboardEdificio)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Refrescar)).BeginInit();
            this.Cabezera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardEdificio
            // 
            this.DashboardEdificio.AllowUserToResizeColumns = false;
            this.DashboardEdificio.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DashboardEdificio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DashboardEdificio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DashboardEdificio.BackgroundColor = System.Drawing.Color.White;
            this.DashboardEdificio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DashboardEdificio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DashboardEdificio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DashboardEdificio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DashboardEdificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DashboardEdificio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardEdificio.DoubleBuffered = true;
            this.DashboardEdificio.EnableHeadersVisualStyles = false;
            this.DashboardEdificio.GridColor = System.Drawing.Color.Black;
            this.DashboardEdificio.HeaderBgColor = System.Drawing.Color.White;
            this.DashboardEdificio.HeaderForeColor = System.Drawing.Color.Black;
            this.DashboardEdificio.Location = new System.Drawing.Point(12, 72);
            this.DashboardEdificio.MultiSelect = false;
            this.DashboardEdificio.Name = "DashboardEdificio";
            this.DashboardEdificio.ReadOnly = true;
            this.DashboardEdificio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DashboardEdificio.RowHeadersVisible = false;
            this.DashboardEdificio.RowHeadersWidth = 5;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(98)))));
            this.DashboardEdificio.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DashboardEdificio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DashboardEdificio.Size = new System.Drawing.Size(240, 106);
            this.DashboardEdificio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard Edificios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(306, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registrar Edificio";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Nombre);
            this.panel1.Controls.Add(this.btn_Insertar);
            this.panel1.Controls.Add(this.txt_NombreEdificio);
            this.panel1.Location = new System.Drawing.Point(306, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 152);
            this.panel1.TabIndex = 3;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_Nombre.Location = new System.Drawing.Point(4, 20);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(233, 27);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            this.lbl_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Nombre.Visible = false;
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btn_Insertar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Insertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Insertar.BorderRadius = 0;
            this.btn_Insertar.ButtonText = "Insertar";
            this.btn_Insertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Insertar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Insertar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Insertar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Insertar.Iconimage")));
            this.btn_Insertar.Iconimage_right = null;
            this.btn_Insertar.Iconimage_right_Selected = null;
            this.btn_Insertar.Iconimage_Selected = null;
            this.btn_Insertar.IconMarginLeft = 0;
            this.btn_Insertar.IconMarginRight = 0;
            this.btn_Insertar.IconRightVisible = true;
            this.btn_Insertar.IconRightZoom = 0D;
            this.btn_Insertar.IconVisible = true;
            this.btn_Insertar.IconZoom = 40D;
            this.btn_Insertar.IsTab = false;
            this.btn_Insertar.Location = new System.Drawing.Point(46, 113);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_Insertar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btn_Insertar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Insertar.selected = false;
            this.btn_Insertar.Size = new System.Drawing.Size(159, 36);
            this.btn_Insertar.TabIndex = 1;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insertar.Textcolor = System.Drawing.Color.White;
            this.btn_Insertar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // txt_NombreEdificio
            // 
            this.txt_NombreEdificio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NombreEdificio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_NombreEdificio.ForeColor = System.Drawing.Color.White;
            this.txt_NombreEdificio.HintForeColor = System.Drawing.Color.White;
            this.txt_NombreEdificio.HintText = "Nombre Edificio";
            this.txt_NombreEdificio.isPassword = false;
            this.txt_NombreEdificio.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_NombreEdificio.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_NombreEdificio.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_NombreEdificio.LineThickness = 3;
            this.txt_NombreEdificio.Location = new System.Drawing.Point(4, 51);
            this.txt_NombreEdificio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreEdificio.Name = "txt_NombreEdificio";
            this.txt_NombreEdificio.Size = new System.Drawing.Size(233, 32);
            this.txt_NombreEdificio.TabIndex = 0;
            this.txt_NombreEdificio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Eliminar);
            this.panel3.Controls.Add(this.btn_Editar);
            this.panel3.Location = new System.Drawing.Point(12, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 40);
            this.panel3.TabIndex = 4;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.BorderRadius = 0;
            this.btn_Eliminar.ButtonText = "Eliminar";
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Eliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Iconimage")));
            this.btn_Eliminar.Iconimage_right = null;
            this.btn_Eliminar.Iconimage_right_Selected = null;
            this.btn_Eliminar.Iconimage_Selected = null;
            this.btn_Eliminar.IconMarginLeft = 0;
            this.btn_Eliminar.IconMarginRight = 0;
            this.btn_Eliminar.IconRightVisible = true;
            this.btn_Eliminar.IconRightZoom = 0D;
            this.btn_Eliminar.IconVisible = true;
            this.btn_Eliminar.IconZoom = 40D;
            this.btn_Eliminar.IsTab = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(127, 2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Eliminar.selected = false;
            this.btn_Eliminar.Size = new System.Drawing.Size(110, 36);
            this.btn_Eliminar.TabIndex = 1;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Eliminar.Textcolor = System.Drawing.Color.White;
            this.btn_Eliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btn_Editar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Editar.BorderRadius = 0;
            this.btn_Editar.ButtonText = "Editar";
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Editar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Editar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Editar.Iconimage")));
            this.btn_Editar.Iconimage_right = null;
            this.btn_Editar.Iconimage_right_Selected = null;
            this.btn_Editar.Iconimage_Selected = null;
            this.btn_Editar.IconMarginLeft = 0;
            this.btn_Editar.IconMarginRight = 0;
            this.btn_Editar.IconRightVisible = true;
            this.btn_Editar.IconRightZoom = 0D;
            this.btn_Editar.IconVisible = true;
            this.btn_Editar.IconZoom = 40D;
            this.btn_Editar.IsTab = false;
            this.btn_Editar.Location = new System.Drawing.Point(3, 3);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_Editar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btn_Editar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Editar.selected = false;
            this.btn_Editar.Size = new System.Drawing.Size(110, 35);
            this.btn_Editar.TabIndex = 0;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Editar.Textcolor = System.Drawing.Color.White;
            this.btn_Editar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refrescar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refrescar.Image")));
            this.btn_Refrescar.Location = new System.Drawing.Point(228, 47);
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(24, 19);
            this.btn_Refrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Refrescar.TabIndex = 5;
            this.btn_Refrescar.TabStop = false;
            this.btn_Refrescar.Click += new System.EventHandler(this.btn_Refrescar_Click);
            // 
            // Cabezera
            // 
            this.Cabezera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.Cabezera.Controls.Add(this.btn_Minimizar);
            this.Cabezera.Controls.Add(this.btn_Cerrar);
            this.Cabezera.Controls.Add(this.lbl_Titulo);
            this.Cabezera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cabezera.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cabezera.Location = new System.Drawing.Point(0, 0);
            this.Cabezera.Name = "Cabezera";
            this.Cabezera.Size = new System.Drawing.Size(560, 33);
            this.Cabezera.TabIndex = 6;
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.Image")));
            this.btn_Minimizar.Location = new System.Drawing.Point(514, 7);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(10, 14);
            this.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minimizar.TabIndex = 1;
            this.btn_Minimizar.TabStop = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(530, 7);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(17, 14);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar.TabIndex = 1;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(212, 7);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(133, 19);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Registro Edificios";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Cabezera;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lbl_Titulo;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 7;
            this.bunifuElipse2.TargetControl = this.DashboardEdificio;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 7;
            this.bunifuElipse3.TargetControl = this.btn_Insertar;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 7;
            this.bunifuElipse4.TargetControl = this.btn_Editar;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 7;
            this.bunifuElipse5.TargetControl = this.btn_Eliminar;
            // 
            // Frm_RegistroEdificios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(560, 236);
            this.Controls.Add(this.Cabezera);
            this.Controls.Add(this.btn_Refrescar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DashboardEdificio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(560, 236);
            this.MinimumSize = new System.Drawing.Size(560, 236);
            this.Name = "Frm_RegistroEdificios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Edificios ITLA";
            this.Load += new System.EventHandler(this.Frm_RegistroEdificios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DashboardEdificio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Refrescar)).EndInit();
            this.Cabezera.ResumeLayout(false);
            this.Cabezera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DashboardEdificio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Insertar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_NombreEdificio;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Eliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Editar;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.PictureBox btn_Refrescar;
        private System.Windows.Forms.Panel Cabezera;
        private System.Windows.Forms.PictureBox btn_Minimizar;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private System.Windows.Forms.Label lbl_Titulo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
    }
}