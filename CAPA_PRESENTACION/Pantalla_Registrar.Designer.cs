namespace CAPA_PRESENTACION
{
    partial class Pantalla_Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_Registrar));
            this.TOP = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CERRAR = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_NOMBRE = new System.Windows.Forms.TextBox();
            this.TB_APELLIDO = new System.Windows.Forms.TextBox();
            this.DT_FN = new System.Windows.Forms.DateTimePicker();
            this.CB_TU = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_GUARDAR = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_NUEVO = new System.Windows.Forms.Button();
            this.BT_VOLVER = new System.Windows.Forms.Button();
            this.MoverTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CERRAR)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TOP
            // 
            this.TOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.TOP.Controls.Add(this.label1);
            this.TOP.Controls.Add(this.CERRAR);
            this.TOP.Location = new System.Drawing.Point(0, 0);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(633, 63);
            this.TOP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Formulario de nuevos usuarios";
            // 
            // CERRAR
            // 
            this.CERRAR.BackColor = System.Drawing.Color.Red;
            this.CERRAR.Image = ((System.Drawing.Image)(resources.GetObject("CERRAR.Image")));
            this.CERRAR.Location = new System.Drawing.Point(533, 0);
            this.CERRAR.Name = "CERRAR";
            this.CERRAR.Size = new System.Drawing.Size(73, 63);
            this.CERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CERRAR.TabIndex = 4;
            this.CERRAR.TabStop = false;
            this.CERRAR.Click += new System.EventHandler(this.CERRAR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de usuario:";
            // 
            // TB_NOMBRE
            // 
            this.TB_NOMBRE.Location = new System.Drawing.Point(115, 92);
            this.TB_NOMBRE.Multiline = true;
            this.TB_NOMBRE.Name = "TB_NOMBRE";
            this.TB_NOMBRE.Size = new System.Drawing.Size(254, 27);
            this.TB_NOMBRE.TabIndex = 6;
            // 
            // TB_APELLIDO
            // 
            this.TB_APELLIDO.Location = new System.Drawing.Point(116, 141);
            this.TB_APELLIDO.Multiline = true;
            this.TB_APELLIDO.Name = "TB_APELLIDO";
            this.TB_APELLIDO.Size = new System.Drawing.Size(253, 27);
            this.TB_APELLIDO.TabIndex = 7;
            // 
            // DT_FN
            // 
            this.DT_FN.Location = new System.Drawing.Point(212, 234);
            this.DT_FN.Name = "DT_FN";
            this.DT_FN.Size = new System.Drawing.Size(156, 20);
            this.DT_FN.TabIndex = 11;
            // 
            // CB_TU
            // 
            this.CB_TU.FormattingEnabled = true;
            this.CB_TU.Items.AddRange(new object[] {
            "General",
            "Administrador"});
            this.CB_TU.Location = new System.Drawing.Point(173, 193);
            this.CB_TU.Name = "CB_TU";
            this.CB_TU.Size = new System.Drawing.Size(195, 21);
            this.CB_TU.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BT_GUARDAR);
            this.panel2.Location = new System.Drawing.Point(404, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 47);
            this.panel2.TabIndex = 22;
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
            this.BT_GUARDAR.Text = "Guardar Usuario";
            this.BT_GUARDAR.UseVisualStyleBackColor = false;
            this.BT_GUARDAR.Click += new System.EventHandler(this.BT_GUARDAR_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BT_NUEVO);
            this.panel3.Location = new System.Drawing.Point(404, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 47);
            this.panel3.TabIndex = 23;
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
            this.BT_NUEVO.Text = "Nuevo Usuario";
            this.BT_NUEVO.UseVisualStyleBackColor = false;
            this.BT_NUEVO.Click += new System.EventHandler(this.BT_NUEVO_Click);
            // 
            // BT_VOLVER
            // 
            this.BT_VOLVER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.BT_VOLVER.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_VOLVER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BT_VOLVER.Location = new System.Drawing.Point(404, 92);
            this.BT_VOLVER.Name = "BT_VOLVER";
            this.BT_VOLVER.Size = new System.Drawing.Size(169, 47);
            this.BT_VOLVER.TabIndex = 24;
            this.BT_VOLVER.Text = "Pagina Anterior";
            this.BT_VOLVER.UseVisualStyleBackColor = false;
            this.BT_VOLVER.Click += new System.EventHandler(this.BT_VOLVER_Click);
            // 
            // MoverTop
            // 
            this.MoverTop.Fixed = true;
            this.MoverTop.Horizontal = true;
            this.MoverTop.TargetControl = this.TOP;
            this.MoverTop.Vertical = true;
            // 
            // Pantalla_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(609, 282);
            this.Controls.Add(this.BT_VOLVER);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CB_TU);
            this.Controls.Add(this.DT_FN);
            this.Controls.Add(this.TB_APELLIDO);
            this.Controls.Add(this.TB_NOMBRE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_Registrar";
            this.Text = "Pantalla_Registrar";
            this.Load += new System.EventHandler(this.Pantalla_Registrar_Load);
            this.TOP.ResumeLayout(false);
            this.TOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CERRAR)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TOP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_NOMBRE;
        private System.Windows.Forms.TextBox TB_APELLIDO;
        private System.Windows.Forms.DateTimePicker DT_FN;
        private System.Windows.Forms.ComboBox CB_TU;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_GUARDAR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_NUEVO;
        private System.Windows.Forms.Button BT_VOLVER;
        private Bunifu.Framework.UI.BunifuDragControl MoverTop;
        private System.Windows.Forms.PictureBox CERRAR;
        private System.Windows.Forms.Label label1;
    }
}