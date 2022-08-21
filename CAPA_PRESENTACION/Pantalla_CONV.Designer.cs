namespace CAPA_PRESENTACION
{
    partial class Pantalla_CONV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_CONV));
            this.TOP = new System.Windows.Forms.Panel();
            this.CERRAR = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_CONSULTAS = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_BUSCAR = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BT_VOLVER = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_MODIFICAR = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_GUARDAR = new System.Windows.Forms.Button();
            this.MoverTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.TB_NOMBRE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_APELLIDO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_CARRERA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_CORREO_E = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_EDIFICIO = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CB_AD = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_MOTIVO = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TB_ENTRADA = new System.Windows.Forms.TextBox();
            this.TB_SALIDA = new System.Windows.Forms.TextBox();
            this.TOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CERRAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CONSULTAS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.TOP.Size = new System.Drawing.Size(1031, 50);
            this.TOP.TabIndex = 0;
            // 
            // CERRAR
            // 
            this.CERRAR.BackColor = System.Drawing.Color.Red;
            this.CERRAR.Image = ((System.Drawing.Image)(resources.GetObject("CERRAR.Image")));
            this.CERRAR.Location = new System.Drawing.Point(976, 0);
            this.CERRAR.Name = "CERRAR";
            this.CERRAR.Size = new System.Drawing.Size(55, 50);
            this.CERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CERRAR.TabIndex = 3;
            this.CERRAR.TabStop = false;
            this.CERRAR.Click += new System.EventHandler(this.CERRAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultar Visitas";
            // 
            // DGV_CONSULTAS
            // 
            this.DGV_CONSULTAS.AllowUserToAddRows = false;
            this.DGV_CONSULTAS.AllowUserToDeleteRows = false;
            this.DGV_CONSULTAS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CONSULTAS.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_CONSULTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CONSULTAS.Location = new System.Drawing.Point(0, 102);
            this.DGV_CONSULTAS.Name = "DGV_CONSULTAS";
            this.DGV_CONSULTAS.ReadOnly = true;
            this.DGV_CONSULTAS.Size = new System.Drawing.Size(1031, 160);
            this.DGV_CONSULTAS.TabIndex = 1;
            this.DGV_CONSULTAS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CONSULTAS_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar edificio a consultar:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TB_BUSCAR);
            this.panel1.Location = new System.Drawing.Point(250, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 35);
            this.panel1.TabIndex = 3;
            // 
            // TB_BUSCAR
            // 
            this.TB_BUSCAR.BackColor = System.Drawing.Color.White;
            this.TB_BUSCAR.Location = new System.Drawing.Point(45, 3);
            this.TB_BUSCAR.Multiline = true;
            this.TB_BUSCAR.Name = "TB_BUSCAR";
            this.TB_BUSCAR.Size = new System.Drawing.Size(344, 29);
            this.TB_BUSCAR.TabIndex = 1;
            this.TB_BUSCAR.TextChanged += new System.EventHandler(this.TB_BUSCAR_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BT_VOLVER
            // 
            this.BT_VOLVER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.BT_VOLVER.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_VOLVER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BT_VOLVER.Location = new System.Drawing.Point(96, 447);
            this.BT_VOLVER.Name = "BT_VOLVER";
            this.BT_VOLVER.Size = new System.Drawing.Size(169, 47);
            this.BT_VOLVER.TabIndex = 25;
            this.BT_VOLVER.Text = "VOLVER A PAGINA ANTERIOR";
            this.BT_VOLVER.UseVisualStyleBackColor = false;
            this.BT_VOLVER.Click += new System.EventHandler(this.BT_VOLVER_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BT_MODIFICAR);
            this.panel2.Location = new System.Drawing.Point(735, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 47);
            this.panel2.TabIndex = 26;
            // 
            // BT_MODIFICAR
            // 
            this.BT_MODIFICAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.BT_MODIFICAR.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_MODIFICAR.ForeColor = System.Drawing.Color.White;
            this.BT_MODIFICAR.Location = new System.Drawing.Point(0, 0);
            this.BT_MODIFICAR.Name = "BT_MODIFICAR";
            this.BT_MODIFICAR.Size = new System.Drawing.Size(169, 47);
            this.BT_MODIFICAR.TabIndex = 2;
            this.BT_MODIFICAR.Text = "Modificar Visita";
            this.BT_MODIFICAR.UseVisualStyleBackColor = false;
            this.BT_MODIFICAR.Click += new System.EventHandler(this.BT_MODIFICAR_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.BT_GUARDAR);
            this.panel3.Location = new System.Drawing.Point(434, 444);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 47);
            this.panel3.TabIndex = 27;
            // 
            // BT_GUARDAR
            // 
            this.BT_GUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.BT_GUARDAR.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_GUARDAR.ForeColor = System.Drawing.Color.White;
            this.BT_GUARDAR.Location = new System.Drawing.Point(0, 0);
            this.BT_GUARDAR.Name = "BT_GUARDAR";
            this.BT_GUARDAR.Size = new System.Drawing.Size(169, 47);
            this.BT_GUARDAR.TabIndex = 1;
            this.BT_GUARDAR.Text = "Guardar Visita";
            this.BT_GUARDAR.UseVisualStyleBackColor = false;
            this.BT_GUARDAR.Click += new System.EventHandler(this.BT_GUARDAR_Click);
            // 
            // MoverTop
            // 
            this.MoverTop.Fixed = true;
            this.MoverTop.Horizontal = true;
            this.MoverTop.TargetControl = this.TOP;
            this.MoverTop.Vertical = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre:";
            // 
            // TB_NOMBRE
            // 
            this.TB_NOMBRE.Location = new System.Drawing.Point(96, 305);
            this.TB_NOMBRE.Name = "TB_NOMBRE";
            this.TB_NOMBRE.Size = new System.Drawing.Size(193, 20);
            this.TB_NOMBRE.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Apellido:";
            // 
            // TB_APELLIDO
            // 
            this.TB_APELLIDO.Location = new System.Drawing.Point(96, 348);
            this.TB_APELLIDO.Name = "TB_APELLIDO";
            this.TB_APELLIDO.Size = new System.Drawing.Size(193, 20);
            this.TB_APELLIDO.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Carrera (opcional):";
            // 
            // TB_CARRERA
            // 
            this.TB_CARRERA.Location = new System.Drawing.Point(169, 393);
            this.TB_CARRERA.Name = "TB_CARRERA";
            this.TB_CARRERA.Size = new System.Drawing.Size(120, 20);
            this.TB_CARRERA.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Correo electrónico:";
            // 
            // TB_CORREO_E
            // 
            this.TB_CORREO_E.Location = new System.Drawing.Point(481, 308);
            this.TB_CORREO_E.Name = "TB_CORREO_E";
            this.TB_CORREO_E.Size = new System.Drawing.Size(202, 20);
            this.TB_CORREO_E.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(712, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Edificio:";
            // 
            // CB_EDIFICIO
            // 
            this.CB_EDIFICIO.FormattingEnabled = true;
            this.CB_EDIFICIO.Items.AddRange(new object[] {
            "Edificio 1",
            "Edificio 2",
            "Edificio 3",
            "Edificio 4"});
            this.CB_EDIFICIO.Location = new System.Drawing.Point(786, 337);
            this.CB_EDIFICIO.Name = "CB_EDIFICIO";
            this.CB_EDIFICIO.Size = new System.Drawing.Size(223, 21);
            this.CB_EDIFICIO.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(712, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Hora de entrada:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(712, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Aula ó lugar al que se dirige:";
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
            this.CB_AD.Location = new System.Drawing.Point(715, 397);
            this.CB_AD.Name = "CB_AD";
            this.CB_AD.Size = new System.Drawing.Size(258, 21);
            this.CB_AD.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(318, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Hora de salida:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(318, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Motivo de la visita:";
            // 
            // TB_MOTIVO
            // 
            this.TB_MOTIVO.BackColor = System.Drawing.Color.White;
            this.TB_MOTIVO.Location = new System.Drawing.Point(481, 393);
            this.TB_MOTIVO.Multiline = true;
            this.TB_MOTIVO.Name = "TB_MOTIVO";
            this.TB_MOTIVO.Size = new System.Drawing.Size(202, 25);
            this.TB_MOTIVO.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.panel4.Location = new System.Drawing.Point(0, 268);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1032, 10);
            this.panel4.TabIndex = 47;
            // 
            // TB_ENTRADA
            // 
            this.TB_ENTRADA.Location = new System.Drawing.Point(446, 345);
            this.TB_ENTRADA.Name = "TB_ENTRADA";
            this.TB_ENTRADA.Size = new System.Drawing.Size(237, 20);
            this.TB_ENTRADA.TabIndex = 48;
            // 
            // TB_SALIDA
            // 
            this.TB_SALIDA.Location = new System.Drawing.Point(863, 302);
            this.TB_SALIDA.Name = "TB_SALIDA";
            this.TB_SALIDA.Size = new System.Drawing.Size(146, 20);
            this.TB_SALIDA.TabIndex = 49;
            // 
            // Pantalla_CONV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1031, 496);
            this.Controls.Add(this.CB_EDIFICIO);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TB_ENTRADA);
            this.Controls.Add(this.TB_SALIDA);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TB_MOTIVO);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CB_AD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_CORREO_E);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_CARRERA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_APELLIDO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_NOMBRE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BT_VOLVER);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_CONSULTAS);
            this.Controls.Add(this.TOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_CONV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla_CONV";
            this.Load += new System.EventHandler(this.Pantalla_CONV_Load);
            this.TOP.ResumeLayout(false);
            this.TOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CERRAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CONSULTAS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_CONSULTAS;
        private System.Windows.Forms.PictureBox CERRAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BT_VOLVER;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_MODIFICAR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_GUARDAR;
        private Bunifu.Framework.UI.BunifuDragControl MoverTop;
        private System.Windows.Forms.TextBox TB_BUSCAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_NOMBRE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_APELLIDO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_CARRERA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TB_CORREO_E;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_EDIFICIO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CB_AD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TB_MOTIVO;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TB_ENTRADA;
        private System.Windows.Forms.TextBox TB_SALIDA;
    }
}