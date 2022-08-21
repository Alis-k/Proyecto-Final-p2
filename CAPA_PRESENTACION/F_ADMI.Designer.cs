namespace CAPA_PRESENTACION
{
    partial class F_ADMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ADMI));
            this.TOP = new System.Windows.Forms.Panel();
            this.CERRAR = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MoverTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Btconsultar = new System.Windows.Forms.Button();
            this.Btvisitas = new System.Windows.Forms.Button();
            this.Btusuarios = new System.Windows.Forms.Button();
            this.Btprincipal = new System.Windows.Forms.Button();
            this.TOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CERRAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TOP
            // 
            this.TOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.TOP.Controls.Add(this.CERRAR);
            this.TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.TOP.Location = new System.Drawing.Point(0, 0);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(668, 41);
            this.TOP.TabIndex = 0;
            // 
            // CERRAR
            // 
            this.CERRAR.BackColor = System.Drawing.Color.Red;
            this.CERRAR.Image = ((System.Drawing.Image)(resources.GetObject("CERRAR.Image")));
            this.CERRAR.Location = new System.Drawing.Point(625, 0);
            this.CERRAR.Name = "CERRAR";
            this.CERRAR.Size = new System.Drawing.Size(43, 41);
            this.CERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CERRAR.TabIndex = 0;
            this.CERRAR.TabStop = false;
            this.CERRAR.Click += new System.EventHandler(this.CERRAR_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(342, 234);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // MoverTop
            // 
            this.MoverTop.Fixed = true;
            this.MoverTop.Horizontal = true;
            this.MoverTop.TargetControl = this.TOP;
            this.MoverTop.Vertical = true;
            // 
            // Btconsultar
            // 
            this.Btconsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.Btconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btconsultar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btconsultar.Location = new System.Drawing.Point(366, 85);
            this.Btconsultar.Name = "Btconsultar";
            this.Btconsultar.Size = new System.Drawing.Size(137, 58);
            this.Btconsultar.TabIndex = 28;
            this.Btconsultar.Text = "Consultar visitas";
            this.Btconsultar.UseVisualStyleBackColor = false;
            this.Btconsultar.Click += new System.EventHandler(this.Btconsultar_Click);
            // 
            // Btvisitas
            // 
            this.Btvisitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.Btvisitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btvisitas.ForeColor = System.Drawing.Color.White;
            this.Btvisitas.Location = new System.Drawing.Point(519, 85);
            this.Btvisitas.Name = "Btvisitas";
            this.Btvisitas.Size = new System.Drawing.Size(137, 58);
            this.Btvisitas.TabIndex = 29;
            this.Btvisitas.Text = "Registrar  visitas";
            this.Btvisitas.UseVisualStyleBackColor = false;
            this.Btvisitas.Click += new System.EventHandler(this.Btvisitas_Click);
            // 
            // Btusuarios
            // 
            this.Btusuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.Btusuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btusuarios.ForeColor = System.Drawing.Color.White;
            this.Btusuarios.Location = new System.Drawing.Point(366, 177);
            this.Btusuarios.Name = "Btusuarios";
            this.Btusuarios.Size = new System.Drawing.Size(137, 58);
            this.Btusuarios.TabIndex = 30;
            this.Btusuarios.Text = "Registrar nuevos usuarios";
            this.Btusuarios.UseVisualStyleBackColor = false;
            this.Btusuarios.Click += new System.EventHandler(this.Btusuarios_Click);
            // 
            // Btprincipal
            // 
            this.Btprincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.Btprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btprincipal.ForeColor = System.Drawing.Color.White;
            this.Btprincipal.Location = new System.Drawing.Point(519, 177);
            this.Btprincipal.Name = "Btprincipal";
            this.Btprincipal.Size = new System.Drawing.Size(137, 58);
            this.Btprincipal.TabIndex = 31;
            this.Btprincipal.Text = "Pantalla principal";
            this.Btprincipal.UseVisualStyleBackColor = false;
            this.Btprincipal.Click += new System.EventHandler(this.Btprincipal_Click);
            // 
            // Pantalla_ADMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 277);
            this.Controls.Add(this.Btprincipal);
            this.Controls.Add(this.Btusuarios);
            this.Controls.Add(this.Btvisitas);
            this.Controls.Add(this.Btconsultar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_ADMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla3";
            this.TOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CERRAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TOP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl MoverTop;
        private System.Windows.Forms.PictureBox CERRAR;
        private System.Windows.Forms.Button Btconsultar;
        private System.Windows.Forms.Button Btvisitas;
        private System.Windows.Forms.Button Btusuarios;
        private System.Windows.Forms.Button Btprincipal;
    }
}