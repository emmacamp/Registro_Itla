
namespace CapaPresentacion
{
    partial class Frm_RegistrarVisita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistrarVisita));
            this.Txt_Carrera = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Txt_Apellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Txt_Nombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.mTxt_Correo = new System.Windows.Forms.MaskedTextBox();
            this.rText_MotivoVisita = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.SelectEdificio = new System.Windows.Forms.ComboBox();
            this.selectAulas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_InsertarVisita = new Bunifu.Framework.UI.BunifuFlatButton();
            this.horaEntrada = new System.Windows.Forms.DateTimePicker();
            this.horaSalida = new System.Windows.Forms.DateTimePicker();
            this.cabezera = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cabezera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Carrera
            // 
            this.Txt_Carrera.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Carrera.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txt_Carrera.ForeColor = System.Drawing.Color.White;
            this.Txt_Carrera.HintForeColor = System.Drawing.Color.White;
            this.Txt_Carrera.HintText = "Carrera";
            this.Txt_Carrera.isPassword = false;
            this.Txt_Carrera.LineFocusedColor = System.Drawing.Color.Blue;
            this.Txt_Carrera.LineIdleColor = System.Drawing.Color.Gray;
            this.Txt_Carrera.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Txt_Carrera.LineThickness = 3;
            this.Txt_Carrera.Location = new System.Drawing.Point(57, 164);
            this.Txt_Carrera.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Carrera.Name = "Txt_Carrera";
            this.Txt_Carrera.Size = new System.Drawing.Size(243, 36);
            this.Txt_Carrera.TabIndex = 0;
            this.Txt_Carrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Apellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txt_Apellido.ForeColor = System.Drawing.Color.White;
            this.Txt_Apellido.HintForeColor = System.Drawing.Color.White;
            this.Txt_Apellido.HintText = "Apellido";
            this.Txt_Apellido.isPassword = false;
            this.Txt_Apellido.LineFocusedColor = System.Drawing.Color.Blue;
            this.Txt_Apellido.LineIdleColor = System.Drawing.Color.Gray;
            this.Txt_Apellido.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Txt_Apellido.LineThickness = 3;
            this.Txt_Apellido.Location = new System.Drawing.Point(57, 119);
            this.Txt_Apellido.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(243, 37);
            this.Txt_Apellido.TabIndex = 0;
            this.Txt_Apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txt_Nombre.ForeColor = System.Drawing.Color.White;
            this.Txt_Nombre.HintForeColor = System.Drawing.Color.White;
            this.Txt_Nombre.HintText = "Nombre";
            this.Txt_Nombre.isPassword = false;
            this.Txt_Nombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.Txt_Nombre.LineIdleColor = System.Drawing.Color.Gray;
            this.Txt_Nombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Txt_Nombre.LineThickness = 3;
            this.Txt_Nombre.Location = new System.Drawing.Point(57, 74);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(243, 37);
            this.Txt_Nombre.TabIndex = 0;
            this.Txt_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mTxt_Correo
            // 
            this.mTxt_Correo.Location = new System.Drawing.Point(438, 180);
            this.mTxt_Correo.Name = "mTxt_Correo";
            this.mTxt_Correo.Size = new System.Drawing.Size(243, 20);
            this.mTxt_Correo.TabIndex = 4;
            // 
            // rText_MotivoVisita
            // 
            this.rText_MotivoVisita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rText_MotivoVisita.Location = new System.Drawing.Point(57, 284);
            this.rText_MotivoVisita.Name = "rText_MotivoVisita";
            this.rText_MotivoVisita.Size = new System.Drawing.Size(624, 41);
            this.rText_MotivoVisita.TabIndex = 5;
            this.rText_MotivoVisita.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(435, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Motivo de la Visita";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(53, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(628, 21);
            this.lbl_titulo.TabIndex = 8;
            this.lbl_titulo.Text = "REGISTRAR VISITAS";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectEdificio
            // 
            this.SelectEdificio.BackColor = System.Drawing.Color.White;
            this.SelectEdificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectEdificio.FormattingEnabled = true;
            this.SelectEdificio.Location = new System.Drawing.Point(438, 90);
            this.SelectEdificio.Name = "SelectEdificio";
            this.SelectEdificio.Size = new System.Drawing.Size(243, 21);
            this.SelectEdificio.TabIndex = 9;
            // 
            // selectAulas
            // 
            this.selectAulas.BackColor = System.Drawing.Color.White;
            this.selectAulas.DropDownHeight = 93;
            this.selectAulas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectAulas.FormattingEnabled = true;
            this.selectAulas.IntegralHeight = false;
            this.selectAulas.Location = new System.Drawing.Point(438, 135);
            this.selectAulas.Name = "selectAulas";
            this.selectAulas.Size = new System.Drawing.Size(243, 21);
            this.selectAulas.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(435, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Edificios Itla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(438, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Aulas Itla";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(54, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hora de Entrada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(438, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hora de Salida";
            // 
            // btn_InsertarVisita
            // 
            this.btn_InsertarVisita.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btn_InsertarVisita.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_InsertarVisita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_InsertarVisita.BorderRadius = 0;
            this.btn_InsertarVisita.ButtonText = "Insertar Visita";
            this.btn_InsertarVisita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InsertarVisita.DisabledColor = System.Drawing.Color.Gray;
            this.btn_InsertarVisita.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_InsertarVisita.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_InsertarVisita.Iconimage")));
            this.btn_InsertarVisita.Iconimage_right = null;
            this.btn_InsertarVisita.Iconimage_right_Selected = null;
            this.btn_InsertarVisita.Iconimage_Selected = null;
            this.btn_InsertarVisita.IconMarginLeft = 0;
            this.btn_InsertarVisita.IconMarginRight = 0;
            this.btn_InsertarVisita.IconRightVisible = true;
            this.btn_InsertarVisita.IconRightZoom = 0D;
            this.btn_InsertarVisita.IconVisible = true;
            this.btn_InsertarVisita.IconZoom = 50D;
            this.btn_InsertarVisita.IsTab = false;
            this.btn_InsertarVisita.Location = new System.Drawing.Point(259, 361);
            this.btn_InsertarVisita.Name = "btn_InsertarVisita";
            this.btn_InsertarVisita.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_InsertarVisita.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btn_InsertarVisita.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_InsertarVisita.selected = false;
            this.btn_InsertarVisita.Size = new System.Drawing.Size(214, 31);
            this.btn_InsertarVisita.TabIndex = 13;
            this.btn_InsertarVisita.Text = "Insertar Visita";
            this.btn_InsertarVisita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_InsertarVisita.Textcolor = System.Drawing.Color.White;
            this.btn_InsertarVisita.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InsertarVisita.Click += new System.EventHandler(this.btn_InsertarVisita_Click);
            // 
            // horaEntrada
            // 
            this.horaEntrada.Location = new System.Drawing.Point(57, 230);
            this.horaEntrada.Name = "horaEntrada";
            this.horaEntrada.Size = new System.Drawing.Size(243, 20);
            this.horaEntrada.TabIndex = 14;
            // 
            // horaSalida
            // 
            this.horaSalida.Location = new System.Drawing.Point(438, 230);
            this.horaSalida.Name = "horaSalida";
            this.horaSalida.Size = new System.Drawing.Size(243, 20);
            this.horaSalida.TabIndex = 15;
            // 
            // cabezera
            // 
            this.cabezera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.cabezera.Controls.Add(this.btn_Minimizar);
            this.cabezera.Controls.Add(this.btn_Cerrar);
            this.cabezera.Controls.Add(this.lbl_titulo);
            this.cabezera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cabezera.Dock = System.Windows.Forms.DockStyle.Top;
            this.cabezera.Location = new System.Drawing.Point(0, 0);
            this.cabezera.Name = "cabezera";
            this.cabezera.Size = new System.Drawing.Size(734, 36);
            this.cabezera.TabIndex = 16;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(708, 9);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(14, 18);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar.TabIndex = 9;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.Image")));
            this.btn_Minimizar.Location = new System.Drawing.Point(687, 9);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(10, 18);
            this.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minimizar.TabIndex = 9;
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
            this.bunifuDragControl2.TargetControl = this.lbl_titulo;
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
            this.bunifuElipse2.TargetControl = this.btn_InsertarVisita;
            // 
            // Frm_RegistrarVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(734, 421);
            this.Controls.Add(this.cabezera);
            this.Controls.Add(this.horaSalida);
            this.Controls.Add(this.horaEntrada);
            this.Controls.Add(this.btn_InsertarVisita);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectAulas);
            this.Controls.Add(this.SelectEdificio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rText_MotivoVisita);
            this.Controls.Add(this.mTxt_Correo);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.Txt_Carrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(734, 421);
            this.MinimumSize = new System.Drawing.Size(734, 421);
            this.Name = "Frm_RegistrarVisita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Visita";
            this.Load += new System.EventHandler(this.Frm_RegistrarVisita_Load);
            this.cabezera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox Txt_Carrera;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txt_Apellido;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txt_Nombre;
        private System.Windows.Forms.MaskedTextBox mTxt_Correo;
        private System.Windows.Forms.RichTextBox rText_MotivoVisita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.ComboBox SelectEdificio;
        private System.Windows.Forms.ComboBox selectAulas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btn_InsertarVisita;
        private System.Windows.Forms.DateTimePicker horaEntrada;
        private System.Windows.Forms.DateTimePicker horaSalida;
        private System.Windows.Forms.Panel cabezera;
        private System.Windows.Forms.PictureBox btn_Minimizar;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}