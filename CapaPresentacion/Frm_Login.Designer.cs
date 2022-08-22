
namespace CapaPresentacion
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Txt_Usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Txt_Contraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Btn_InicioSesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lbl_Cabecera = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.lbl_Cabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txt_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_Usuario.HintForeColor = System.Drawing.Color.Empty;
            this.Txt_Usuario.HintText = "Usuario";
            this.Txt_Usuario.isPassword = false;
            this.Txt_Usuario.LineFocusedColor = System.Drawing.Color.Blue;
            this.Txt_Usuario.LineIdleColor = System.Drawing.Color.Gray;
            this.Txt_Usuario.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Txt_Usuario.LineThickness = 3;
            this.Txt_Usuario.Location = new System.Drawing.Point(44, 145);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(267, 44);
            this.Txt_Usuario.TabIndex = 0;
            this.Txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Contraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txt_Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_Contraseña.HintForeColor = System.Drawing.Color.Empty;
            this.Txt_Contraseña.HintText = "Contraseña";
            this.Txt_Contraseña.isPassword = false;
            this.Txt_Contraseña.LineFocusedColor = System.Drawing.Color.Blue;
            this.Txt_Contraseña.LineIdleColor = System.Drawing.Color.Gray;
            this.Txt_Contraseña.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Txt_Contraseña.LineThickness = 3;
            this.Txt_Contraseña.Location = new System.Drawing.Point(44, 197);
            this.Txt_Contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.Size = new System.Drawing.Size(267, 44);
            this.Txt_Contraseña.TabIndex = 1;
            this.Txt_Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_Contraseña.OnValueChanged += new System.EventHandler(this.Txt_Contraseña_OnValueChanged);
            // 
            // Btn_InicioSesion
            // 
            this.Btn_InicioSesion.Activecolor = System.Drawing.Color.Blue;
            this.Btn_InicioSesion.BackColor = System.Drawing.Color.Blue;
            this.Btn_InicioSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_InicioSesion.BorderRadius = 0;
            this.Btn_InicioSesion.ButtonText = "Iniciar Sesion";
            this.Btn_InicioSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_InicioSesion.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_InicioSesion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_InicioSesion.Iconcolor = System.Drawing.Color.MidnightBlue;
            this.Btn_InicioSesion.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_InicioSesion.Iconimage")));
            this.Btn_InicioSesion.Iconimage_right = null;
            this.Btn_InicioSesion.Iconimage_right_Selected = null;
            this.Btn_InicioSesion.Iconimage_Selected = null;
            this.Btn_InicioSesion.IconMarginLeft = 5;
            this.Btn_InicioSesion.IconMarginRight = 0;
            this.Btn_InicioSesion.IconRightVisible = true;
            this.Btn_InicioSesion.IconRightZoom = 0D;
            this.Btn_InicioSesion.IconVisible = true;
            this.Btn_InicioSesion.IconZoom = 50D;
            this.Btn_InicioSesion.IsTab = false;
            this.Btn_InicioSesion.Location = new System.Drawing.Point(44, 272);
            this.Btn_InicioSesion.Name = "Btn_InicioSesion";
            this.Btn_InicioSesion.Normalcolor = System.Drawing.Color.Blue;
            this.Btn_InicioSesion.OnHovercolor = System.Drawing.Color.Blue;
            this.Btn_InicioSesion.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_InicioSesion.selected = false;
            this.Btn_InicioSesion.Size = new System.Drawing.Size(267, 39);
            this.Btn_InicioSesion.TabIndex = 4;
            this.Btn_InicioSesion.Text = "Iniciar Sesion";
            this.Btn_InicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_InicioSesion.Textcolor = System.Drawing.Color.White;
            this.Btn_InicioSesion.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_InicioSesion.Click += new System.EventHandler(this.Btn_InicioSesion_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Blue;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(12, 83);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(331, 58);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "Inicio Sesion";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cerrar
            // 
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(145, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(50, 50);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Cerrar.TabIndex = 6;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.lbl_Cabecera;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lbl_Cabecera
            // 
            this.lbl_Cabecera.Controls.Add(this.Cerrar);
            this.lbl_Cabecera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Cabecera.Location = new System.Drawing.Point(0, 0);
            this.lbl_Cabecera.Name = "lbl_Cabecera";
            this.lbl_Cabecera.Size = new System.Drawing.Size(355, 80);
            this.lbl_Cabecera.TabIndex = 7;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.Btn_InicioSesion;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 333);
            this.Controls.Add(this.lbl_Cabecera);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.Btn_InicioSesion);
            this.Controls.Add(this.Txt_Contraseña);
            this.Controls.Add(this.Txt_Usuario);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(355, 333);
            this.MinimumSize = new System.Drawing.Size(355, 333);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.lbl_Cabecera.ResumeLayout(false);
            this.lbl_Cabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox Txt_Usuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txt_Contraseña;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_InicioSesion;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.PictureBox Cerrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel lbl_Cabecera;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}

