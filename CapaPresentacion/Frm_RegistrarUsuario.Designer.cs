
namespace CapaPresentacion
{
    partial class Frm_RegistrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistrarUsuario));
            this.btn_Insertar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_Nombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Apellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Contreseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.selectRol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ConfirmarContraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cabezera = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.lbl_ConfirmarCon = new System.Windows.Forms.Label();
            this.cabezera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btn_Insertar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Insertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Insertar.BorderRadius = 0;
            this.btn_Insertar.ButtonText = "Insertar Usuario";
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
            this.btn_Insertar.IconZoom = 50D;
            this.btn_Insertar.IsTab = false;
            this.btn_Insertar.Location = new System.Drawing.Point(328, 288);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_Insertar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btn_Insertar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Insertar.selected = false;
            this.btn_Insertar.Size = new System.Drawing.Size(212, 30);
            this.btn_Insertar.TabIndex = 0;
            this.btn_Insertar.Text = "Insertar Usuario";
            this.btn_Insertar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insertar.Textcolor = System.Drawing.Color.White;
            this.btn_Insertar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(35, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(498, 28);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Registrar Usuarios";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Nombre.ForeColor = System.Drawing.Color.White;
            this.txt_Nombre.HintForeColor = System.Drawing.Color.White;
            this.txt_Nombre.HintText = "Nombre";
            this.txt_Nombre.isPassword = false;
            this.txt_Nombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Nombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Nombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Nombre.LineThickness = 3;
            this.txt_Nombre.Location = new System.Drawing.Point(39, 73);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(199, 21);
            this.txt_Nombre.TabIndex = 2;
            this.txt_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Apellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Apellido.ForeColor = System.Drawing.Color.White;
            this.txt_Apellido.HintForeColor = System.Drawing.Color.White;
            this.txt_Apellido.HintText = "Apellido";
            this.txt_Apellido.isPassword = false;
            this.txt_Apellido.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Apellido.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Apellido.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Apellido.LineThickness = 3;
            this.txt_Apellido.Location = new System.Drawing.Point(39, 143);
            this.txt_Apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(199, 26);
            this.txt_Apellido.TabIndex = 3;
            this.txt_Apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Usuario.ForeColor = System.Drawing.Color.White;
            this.txt_Usuario.HintForeColor = System.Drawing.Color.White;
            this.txt_Usuario.HintText = "Usuario";
            this.txt_Usuario.isPassword = false;
            this.txt_Usuario.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Usuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Usuario.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Usuario.LineThickness = 3;
            this.txt_Usuario.Location = new System.Drawing.Point(327, 73);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(199, 21);
            this.txt_Usuario.TabIndex = 4;
            this.txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Contreseña
            // 
            this.txt_Contreseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Contreseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Contreseña.ForeColor = System.Drawing.Color.White;
            this.txt_Contreseña.HintForeColor = System.Drawing.Color.White;
            this.txt_Contreseña.HintText = "Contraseña";
            this.txt_Contreseña.isPassword = false;
            this.txt_Contreseña.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Contreseña.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Contreseña.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Contreseña.LineThickness = 3;
            this.txt_Contreseña.Location = new System.Drawing.Point(40, 222);
            this.txt_Contreseña.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Contreseña.Name = "txt_Contreseña";
            this.txt_Contreseña.Size = new System.Drawing.Size(198, 21);
            this.txt_Contreseña.TabIndex = 5;
            this.txt_Contreseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Contreseña.OnValueChanged += new System.EventHandler(this.txt_Contreseña_OnValueChanged);
            // 
            // fecha_Nacimiento
            // 
            this.fecha_Nacimiento.Location = new System.Drawing.Point(328, 150);
            this.fecha_Nacimiento.Name = "fecha_Nacimiento";
            this.fecha_Nacimiento.Size = new System.Drawing.Size(212, 20);
            this.fecha_Nacimiento.TabIndex = 6;
            // 
            // selectRol
            // 
            this.selectRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectRol.FormattingEnabled = true;
            this.selectRol.Location = new System.Drawing.Point(328, 229);
            this.selectRol.Name = "selectRol";
            this.selectRol.Size = new System.Drawing.Size(212, 21);
            this.selectRol.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(325, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(325, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rol de Usuario";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ConfirmarContraseña
            // 
            this.txt_ConfirmarContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ConfirmarContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ConfirmarContraseña.ForeColor = System.Drawing.Color.White;
            this.txt_ConfirmarContraseña.HintForeColor = System.Drawing.Color.White;
            this.txt_ConfirmarContraseña.HintText = "Confirmar Contraseña";
            this.txt_ConfirmarContraseña.isPassword = false;
            this.txt_ConfirmarContraseña.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_ConfirmarContraseña.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_ConfirmarContraseña.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_ConfirmarContraseña.LineThickness = 3;
            this.txt_ConfirmarContraseña.Location = new System.Drawing.Point(39, 294);
            this.txt_ConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ConfirmarContraseña.Name = "txt_ConfirmarContraseña";
            this.txt_ConfirmarContraseña.Size = new System.Drawing.Size(198, 21);
            this.txt_ConfirmarContraseña.TabIndex = 10;
            this.txt_ConfirmarContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ConfirmarContraseña.OnValueChanged += new System.EventHandler(this.txt_ConfirmarContraseña_OnValueChanged);
            // 
            // cabezera
            // 
            this.cabezera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.cabezera.Controls.Add(this.btn_Minimizar);
            this.cabezera.Controls.Add(this.btn_Cerrar);
            this.cabezera.Controls.Add(this.lbl_Titulo);
            this.cabezera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cabezera.Dock = System.Windows.Forms.DockStyle.Top;
            this.cabezera.Location = new System.Drawing.Point(0, 0);
            this.cabezera.Name = "cabezera";
            this.cabezera.Size = new System.Drawing.Size(577, 28);
            this.cabezera.TabIndex = 11;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(556, 8);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(13, 13);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar.TabIndex = 2;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.Image")));
            this.btn_Minimizar.Location = new System.Drawing.Point(539, 8);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(11, 13);
            this.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minimizar.TabIndex = 2;
            this.btn_Minimizar.TabStop = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.cabezera;
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
            this.bunifuElipse2.TargetControl = this.btn_Insertar;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_Nombre.Location = new System.Drawing.Point(37, 56);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 12;
            this.lbl_Nombre.Text = "Nombre";
            this.lbl_Nombre.Visible = false;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.ForeColor = System.Drawing.Color.White;
            this.lbl_Apellido.Location = new System.Drawing.Point(37, 126);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_Apellido.TabIndex = 13;
            this.lbl_Apellido.Text = "Apellido";
            this.lbl_Apellido.Visible = false;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_Usuario.Location = new System.Drawing.Point(325, 56);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 14;
            this.lbl_Usuario.Text = "Usuario";
            this.lbl_Usuario.Visible = false;
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.ForeColor = System.Drawing.Color.White;
            this.lbl_Contraseña.Location = new System.Drawing.Point(37, 205);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_Contraseña.TabIndex = 14;
            this.lbl_Contraseña.Text = "Contraseña";
            this.lbl_Contraseña.Visible = false;
            // 
            // lbl_ConfirmarCon
            // 
            this.lbl_ConfirmarCon.AutoSize = true;
            this.lbl_ConfirmarCon.ForeColor = System.Drawing.Color.White;
            this.lbl_ConfirmarCon.Location = new System.Drawing.Point(36, 277);
            this.lbl_ConfirmarCon.Name = "lbl_ConfirmarCon";
            this.lbl_ConfirmarCon.Size = new System.Drawing.Size(108, 13);
            this.lbl_ConfirmarCon.TabIndex = 14;
            this.lbl_ConfirmarCon.Text = "Confirmar Contraseña";
            this.lbl_ConfirmarCon.Visible = false;
            // 
            // Frm_RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(577, 346);
            this.Controls.Add(this.lbl_ConfirmarCon);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.cabezera);
            this.Controls.Add(this.txt_ConfirmarContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectRol);
            this.Controls.Add(this.fecha_Nacimiento);
            this.Controls.Add(this.txt_Contreseña);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Insertar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(577, 346);
            this.MinimumSize = new System.Drawing.Size(577, 346);
            this.Name = "Frm_RegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario";
            this.Load += new System.EventHandler(this.Frm_RegistrarUsuario_Load);
            this.cabezera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_Insertar;
        private System.Windows.Forms.Label lbl_Titulo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Nombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Apellido;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Usuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Contreseña;
        private System.Windows.Forms.DateTimePicker fecha_Nacimiento;
        private System.Windows.Forms.ComboBox selectRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ConfirmarContraseña;
        private System.Windows.Forms.Panel cabezera;
        private System.Windows.Forms.PictureBox btn_Minimizar;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label lbl_ConfirmarCon;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Nombre;
    }
}