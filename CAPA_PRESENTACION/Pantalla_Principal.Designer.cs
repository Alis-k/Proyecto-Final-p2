namespace CAPA_PRESENTACION
{
    partial class Pantalla_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_Principal));
            this.TOP = new System.Windows.Forms.Panel();
            this.PB_CERRAR = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BT_ACCEDER = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TB_USUARIO = new System.Windows.Forms.TextBox();
            this.TB_CONTRASEÑA = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Mover = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_CERRAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TOP
            // 
            this.TOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.TOP.Controls.Add(this.label2);
            this.TOP.Controls.Add(this.PB_CERRAR);
            this.TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.TOP.ForeColor = System.Drawing.Color.Transparent;
            this.TOP.Location = new System.Drawing.Point(0, 0);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(672, 34);
            this.TOP.TabIndex = 0;
            // 
            // PB_CERRAR
            // 
            this.PB_CERRAR.BackColor = System.Drawing.Color.Red;
            this.PB_CERRAR.Image = ((System.Drawing.Image)(resources.GetObject("PB_CERRAR.Image")));
            this.PB_CERRAR.Location = new System.Drawing.Point(633, 0);
            this.PB_CERRAR.Name = "PB_CERRAR";
            this.PB_CERRAR.Size = new System.Drawing.Size(39, 34);
            this.PB_CERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_CERRAR.TabIndex = 0;
            this.PB_CERRAR.TabStop = false;
            this.PB_CERRAR.Click += new System.EventHandler(this.PB_CERRAR_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 246);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // BT_ACCEDER
            // 
            this.BT_ACCEDER.ActiveBorderThickness = 1;
            this.BT_ACCEDER.ActiveCornerRadius = 20;
            this.BT_ACCEDER.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.BT_ACCEDER.ActiveForecolor = System.Drawing.Color.White;
            this.BT_ACCEDER.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.BT_ACCEDER.BackColor = System.Drawing.Color.White;
            this.BT_ACCEDER.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_ACCEDER.BackgroundImage")));
            this.BT_ACCEDER.ButtonText = "LOGIN";
            this.BT_ACCEDER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_ACCEDER.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ACCEDER.ForeColor = System.Drawing.Color.White;
            this.BT_ACCEDER.IdleBorderThickness = 1;
            this.BT_ACCEDER.IdleCornerRadius = 10;
            this.BT_ACCEDER.IdleFillColor = System.Drawing.Color.Red;
            this.BT_ACCEDER.IdleForecolor = System.Drawing.Color.White;
            this.BT_ACCEDER.IdleLineColor = System.Drawing.Color.Blue;
            this.BT_ACCEDER.Location = new System.Drawing.Point(430, 221);
            this.BT_ACCEDER.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BT_ACCEDER.Name = "BT_ACCEDER";
            this.BT_ACCEDER.Size = new System.Drawing.Size(167, 45);
            this.BT_ACCEDER.TabIndex = 2;
            this.BT_ACCEDER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BT_ACCEDER.Click += new System.EventHandler(this.BT_RV_Click);
            // 
            // TB_USUARIO
            // 
            this.TB_USUARIO.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_USUARIO.ForeColor = System.Drawing.Color.Black;
            this.TB_USUARIO.Location = new System.Drawing.Point(75, 17);
            this.TB_USUARIO.Name = "TB_USUARIO";
            this.TB_USUARIO.Size = new System.Drawing.Size(197, 26);
            this.TB_USUARIO.TabIndex = 3;
            // 
            // TB_CONTRASEÑA
            // 
            this.TB_CONTRASEÑA.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CONTRASEÑA.ForeColor = System.Drawing.Color.Black;
            this.TB_CONTRASEÑA.Location = new System.Drawing.Point(75, 19);
            this.TB_CONTRASEÑA.Name = "TB_CONTRASEÑA";
            this.TB_CONTRASEÑA.Size = new System.Drawing.Size(197, 26);
            this.TB_CONTRASEÑA.TabIndex = 4;
            this.TB_CONTRASEÑA.UseSystemPasswordChar = true;
            this.TB_CONTRASEÑA.TextChanged += new System.EventHandler(this.TB_CONTRASEÑA_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TB_USUARIO);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(355, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 61);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.TB_CONTRASEÑA);
            this.panel2.Location = new System.Drawing.Point(358, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 61);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // Mover
            // 
            this.Mover.Fixed = true;
            this.Mover.Horizontal = true;
            this.Mover.TargetControl = this.TOP;
            this.Mover.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Member login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema de registro de visitas ";
            // 
            // Pantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BT_ACCEDER);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Pantalla_Principal_Load);
            this.TOP.ResumeLayout(false);
            this.TOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_CERRAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TOP;
        private System.Windows.Forms.PictureBox PB_CERRAR;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 BT_ACCEDER;
        private System.Windows.Forms.TextBox TB_USUARIO;
        private System.Windows.Forms.TextBox TB_CONTRASEÑA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuDragControl Mover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

