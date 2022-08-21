namespace CAPA_PRESENTACION
{
    partial class Pantalla_GEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_GEN));
            this.TOP = new System.Windows.Forms.Panel();
            this.CERRAR = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NOMBRE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_APELLIDO = new System.Windows.Forms.TextBox();
            this.TB_CARRERA = new System.Windows.Forms.TextBox();
            this.TB_CORREO_E = new System.Windows.Forms.MaskedTextBox();
            this.CB_EDIFICIO = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_MOTIVO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CB_AD = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_GUARDAR = new System.Windows.Forms.Button();
            this.BT_VOLVER = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_NUEVO = new System.Windows.Forms.Button();
            this.MoverTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TB_ENTRADA = new System.Windows.Forms.TextBox();
            this.TB_SALIDA = new System.Windows.Forms.TextBox();
            this.TOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CERRAR)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TOP
            // 
            this.TOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.TOP.Controls.Add(this.CERRAR);
            this.TOP.Controls.Add(this.label1);
            this.TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.TOP.Location = new System.Drawing.Point(0, 0);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(943, 50);
            this.TOP.TabIndex = 0;
            // 
            // CERRAR
            // 
            this.CERRAR.BackColor = System.Drawing.Color.Red;
            this.CERRAR.Image = ((System.Drawing.Image)(resources.GetObject("CERRAR.Image")));
            this.CERRAR.Location = new System.Drawing.Point(887, 0);
            this.CERRAR.Name = "CERRAR";
            this.CERRAR.Size = new System.Drawing.Size(56, 50);
            this.CERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CERRAR.TabIndex = 2;
            this.CERRAR.TabStop = false;
            this.CERRAR.Click += new System.EventHandler(this.CERRAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de visita";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // TB_NOMBRE
            // 
            this.TB_NOMBRE.Location = new System.Drawing.Point(114, 90);
            this.TB_NOMBRE.Name = "TB_NOMBRE";
            this.TB_NOMBRE.Size = new System.Drawing.Size(116, 20);
            this.TB_NOMBRE.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Carrera (opcional):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Correo electrónico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Edificio:";
            // 
            // TB_APELLIDO
            // 
            this.TB_APELLIDO.Location = new System.Drawing.Point(114, 140);
            this.TB_APELLIDO.Name = "TB_APELLIDO";
            this.TB_APELLIDO.Size = new System.Drawing.Size(116, 20);
            this.TB_APELLIDO.TabIndex = 7;
            // 
            // TB_CARRERA
            // 
            this.TB_CARRERA.Location = new System.Drawing.Point(407, 93);
            this.TB_CARRERA.Name = "TB_CARRERA";
            this.TB_CARRERA.Size = new System.Drawing.Size(190, 20);
            this.TB_CARRERA.TabIndex = 8;
            // 
            // TB_CORREO_E
            // 
            this.TB_CORREO_E.Location = new System.Drawing.Point(413, 140);
            this.TB_CORREO_E.Name = "TB_CORREO_E";
            this.TB_CORREO_E.Size = new System.Drawing.Size(184, 20);
            this.TB_CORREO_E.TabIndex = 10;
            // 
            // CB_EDIFICIO
            // 
            this.CB_EDIFICIO.FormattingEnabled = true;
            this.CB_EDIFICIO.Items.AddRange(new object[] {
            "Edificio 1",
            "Edificio 2",
            "Edificio 3",
            "Edificio 4"});
            this.CB_EDIFICIO.Location = new System.Drawing.Point(114, 188);
            this.CB_EDIFICIO.Name = "CB_EDIFICIO";
            this.CB_EDIFICIO.Size = new System.Drawing.Size(116, 21);
            this.CB_EDIFICIO.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(622, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hora de entrada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(622, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hora de salida:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(590, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Motivo de la visita:";
            // 
            // TB_MOTIVO
            // 
            this.TB_MOTIVO.Location = new System.Drawing.Point(764, 170);
            this.TB_MOTIVO.Multiline = true;
            this.TB_MOTIVO.Name = "TB_MOTIVO";
            this.TB_MOTIVO.Size = new System.Drawing.Size(167, 39);
            this.TB_MOTIVO.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(250, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Aula ó lugar a dirigirse:";
            // 
            // CB_AD
            // 
            this.CB_AD.FormattingEnabled = true;
            this.CB_AD.Items.AddRange(new object[] {
            "Rectoria",
            "Admisiones",
            "Registro",
            "Academico",
            "Bedeleria",
            "Cooperativa",
            "Departamento de Recursos Humanos",
            "Departamento de Asistencia Financiera",
            "Oficinas Administrativas"});
            this.CB_AD.Location = new System.Drawing.Point(442, 188);
            this.CB_AD.Name = "CB_AD";
            this.CB_AD.Size = new System.Drawing.Size(121, 21);
            this.CB_AD.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(146, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 32);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BT_GUARDAR
            // 
            this.BT_GUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.BT_GUARDAR.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_GUARDAR.ForeColor = System.Drawing.Color.White;
            this.BT_GUARDAR.Location = new System.Drawing.Point(114, 236);
            this.BT_GUARDAR.Name = "BT_GUARDAR";
            this.BT_GUARDAR.Size = new System.Drawing.Size(169, 47);
            this.BT_GUARDAR.TabIndex = 1;
            this.BT_GUARDAR.Text = "Guardar ";
            this.BT_GUARDAR.UseVisualStyleBackColor = false;
            this.BT_GUARDAR.Click += new System.EventHandler(this.BT_GUARDAR_Click);
            // 
            // BT_VOLVER
            // 
            this.BT_VOLVER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.BT_VOLVER.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_VOLVER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BT_VOLVER.Location = new System.Drawing.Point(625, 236);
            this.BT_VOLVER.Name = "BT_VOLVER";
            this.BT_VOLVER.Size = new System.Drawing.Size(234, 47);
            this.BT_VOLVER.TabIndex = 25;
            this.BT_VOLVER.Text = " Pagina Anterior";
            this.BT_VOLVER.UseVisualStyleBackColor = false;
            this.BT_VOLVER.Click += new System.EventHandler(this.BT_VOLVER_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BT_NUEVO);
            this.panel3.Location = new System.Drawing.Point(389, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 47);
            this.panel3.TabIndex = 26;
            // 
            // BT_NUEVO
            // 
            this.BT_NUEVO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.BT_NUEVO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_NUEVO.ForeColor = System.Drawing.Color.White;
            this.BT_NUEVO.Location = new System.Drawing.Point(0, 0);
            this.BT_NUEVO.Name = "BT_NUEVO";
            this.BT_NUEVO.Size = new System.Drawing.Size(169, 47);
            this.BT_NUEVO.TabIndex = 1;
            this.BT_NUEVO.Text = "Nuevo Registro";
            this.BT_NUEVO.UseVisualStyleBackColor = false;
            this.BT_NUEVO.Click += new System.EventHandler(this.BT_NUEVO_Click);
            // 
            // MoverTop
            // 
            this.MoverTop.Fixed = true;
            this.MoverTop.Horizontal = true;
            this.MoverTop.TargetControl = this.TOP;
            this.MoverTop.Vertical = true;
            // 
            // TB_ENTRADA
            // 
            this.TB_ENTRADA.Location = new System.Drawing.Point(764, 90);
            this.TB_ENTRADA.Name = "TB_ENTRADA";
            this.TB_ENTRADA.Size = new System.Drawing.Size(167, 20);
            this.TB_ENTRADA.TabIndex = 49;
            // 
            // TB_SALIDA
            // 
            this.TB_SALIDA.Location = new System.Drawing.Point(764, 131);
            this.TB_SALIDA.Name = "TB_SALIDA";
            this.TB_SALIDA.Size = new System.Drawing.Size(167, 20);
            this.TB_SALIDA.TabIndex = 50;
            // 
            // Pantalla_GEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(943, 300);
            this.Controls.Add(this.BT_GUARDAR);
            this.Controls.Add(this.TB_SALIDA);
            this.Controls.Add(this.TB_ENTRADA);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BT_VOLVER);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CB_AD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TB_MOTIVO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CB_EDIFICIO);
            this.Controls.Add(this.TB_CORREO_E);
            this.Controls.Add(this.TB_CARRERA);
            this.Controls.Add(this.TB_APELLIDO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_NOMBRE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_GEN";
            this.Text = "Form2";
            this.TOP.ResumeLayout(false);
            this.TOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CERRAR)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_NOMBRE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_APELLIDO;
        private System.Windows.Forms.TextBox TB_CARRERA;
        private System.Windows.Forms.MaskedTextBox TB_CORREO_E;
        private System.Windows.Forms.ComboBox CB_EDIFICIO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_MOTIVO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CB_AD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_GUARDAR;
        private System.Windows.Forms.Button BT_VOLVER;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_NUEVO;
        private Bunifu.Framework.UI.BunifuDragControl MoverTop;
        private System.Windows.Forms.PictureBox CERRAR;
        private System.Windows.Forms.TextBox TB_ENTRADA;
        private System.Windows.Forms.TextBox TB_SALIDA;
    }
}