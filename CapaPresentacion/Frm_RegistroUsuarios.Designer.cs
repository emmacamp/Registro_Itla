
namespace CapaPresentacion
{
    partial class Frm_RegistroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistroUsuarios));
            this.DashboardUsuarios = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Agregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Editar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.refrescar = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Panel();
            this.btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_Buscar = new Bunifu.Framework.UI.BunifuTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refrescar)).BeginInit();
            this.lbl_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardUsuarios
            // 
            this.DashboardUsuarios.AllowUserToAddRows = false;
            this.DashboardUsuarios.AllowUserToDeleteRows = false;
            this.DashboardUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DashboardUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DashboardUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DashboardUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.DashboardUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DashboardUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DashboardUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DashboardUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DashboardUsuarios.ColumnHeadersHeight = 30;
            this.DashboardUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DashboardUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardUsuarios.DoubleBuffered = true;
            this.DashboardUsuarios.EnableHeadersVisualStyles = false;
            this.DashboardUsuarios.GridColor = System.Drawing.Color.White;
            this.DashboardUsuarios.HeaderBgColor = System.Drawing.Color.White;
            this.DashboardUsuarios.HeaderForeColor = System.Drawing.Color.Black;
            this.DashboardUsuarios.Location = new System.Drawing.Point(0, 0);
            this.DashboardUsuarios.MultiSelect = false;
            this.DashboardUsuarios.Name = "DashboardUsuarios";
            this.DashboardUsuarios.ReadOnly = true;
            this.DashboardUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DashboardUsuarios.RowHeadersVisible = false;
            this.DashboardUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(98)))));
            this.DashboardUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DashboardUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DashboardUsuarios.Size = new System.Drawing.Size(667, 167);
            this.DashboardUsuarios.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DashboardUsuarios);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 167);
            this.panel1.TabIndex = 1;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btn_Agregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.BorderRadius = 0;
            this.btn_Agregar.ButtonText = "Agregar";
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Agregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Agregar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Iconimage")));
            this.btn_Agregar.Iconimage_right = null;
            this.btn_Agregar.Iconimage_right_Selected = null;
            this.btn_Agregar.Iconimage_Selected = null;
            this.btn_Agregar.IconMarginLeft = 0;
            this.btn_Agregar.IconMarginRight = 0;
            this.btn_Agregar.IconRightVisible = true;
            this.btn_Agregar.IconRightZoom = 0D;
            this.btn_Agregar.IconVisible = true;
            this.btn_Agregar.IconZoom = 50D;
            this.btn_Agregar.IsTab = false;
            this.btn_Agregar.Location = new System.Drawing.Point(280, 53);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_Agregar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btn_Agregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Agregar.selected = false;
            this.btn_Agregar.Size = new System.Drawing.Size(129, 30);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Agregar.Textcolor = System.Drawing.Color.White;
            this.btn_Agregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
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
            this.btn_Editar.IconZoom = 50D;
            this.btn_Editar.IsTab = false;
            this.btn_Editar.Location = new System.Drawing.Point(415, 53);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_Editar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btn_Editar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Editar.selected = false;
            this.btn_Editar.Size = new System.Drawing.Size(129, 30);
            this.btn_Editar.TabIndex = 5;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Editar.Textcolor = System.Drawing.Color.White;
            this.btn_Editar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
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
            this.btn_Eliminar.IconZoom = 50D;
            this.btn_Eliminar.IsTab = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(550, 53);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Eliminar.selected = false;
            this.btn_Eliminar.Size = new System.Drawing.Size(129, 29);
            this.btn_Eliminar.TabIndex = 6;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Eliminar.Textcolor = System.Drawing.Color.White;
            this.btn_Eliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar por usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refrescar
            // 
            this.refrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refrescar.Image = ((System.Drawing.Image)(resources.GetObject("refrescar.Image")));
            this.refrescar.Location = new System.Drawing.Point(198, 53);
            this.refrescar.Name = "refrescar";
            this.refrescar.Size = new System.Drawing.Size(18, 18);
            this.refrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refrescar.TabIndex = 8;
            this.refrescar.TabStop = false;
            this.refrescar.Click += new System.EventHandler(this.refrescar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.lbl_Titulo.Controls.Add(this.btn_Minimizar);
            this.lbl_Titulo.Controls.Add(this.btn_Cerrar);
            this.lbl_Titulo.Controls.Add(this.label2);
            this.lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(691, 26);
            this.lbl_Titulo.TabIndex = 9;
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.Image")));
            this.btn_Minimizar.Location = new System.Drawing.Point(643, 3);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(12, 18);
            this.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Minimizar.TabIndex = 2;
            this.btn_Minimizar.TabStop = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(661, 3);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(18, 18);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Cerrar.TabIndex = 1;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(612, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registrar Usuarios";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.label2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 7;
            this.bunifuElipse2.TargetControl = this.DashboardUsuarios;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 7;
            this.bunifuElipse3.TargetControl = this.btn_Agregar;
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
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.txt_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Buscar.BackgroundImage")));
            this.txt_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Buscar.ForeColor = System.Drawing.Color.White;
            this.txt_Buscar.Icon = ((System.Drawing.Image)(resources.GetObject("txt_Buscar.Icon")));
            this.txt_Buscar.Location = new System.Drawing.Point(12, 53);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(180, 30);
            this.txt_Buscar.TabIndex = 10;
            this.txt_Buscar.text = "";
            this.txt_Buscar.OnTextChange += new System.EventHandler(this.txt_Buscar_OnTextChange);
            // 
            // Frm_RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(691, 268);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.refrescar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(691, 268);
            this.MinimumSize = new System.Drawing.Size(691, 268);
            this.Name = "Frm_RegistroUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Usuarios";
            this.Load += new System.EventHandler(this.Frm_RegistroUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DashboardUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refrescar)).EndInit();
            this.lbl_Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DashboardUsuarios;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Agregar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Editar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox refrescar;
        private System.Windows.Forms.Panel lbl_Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_Minimizar;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuTextbox txt_Buscar;
    }
}