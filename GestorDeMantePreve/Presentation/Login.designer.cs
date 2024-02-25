
namespace Presentation
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.header1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinVentana = new FontAwesome.Sharp.IconButton();
            this.btnCerrarVentana = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbErrorInicioSesion = new System.Windows.Forms.Label();
            this.btnMostrarContrasena = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLoginLeft = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIniciarSesion = new Guna.UI.WinForms.GunaButton();
            this.btnSinUso = new FontAwesome.Sharp.IconButton();
            this.header1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLoginLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.header1.Controls.Add(this.label1);
            this.header1.Controls.Add(this.btnMinVentana);
            this.header1.Controls.Add(this.btnCerrarVentana);
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(4);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1244, 57);
            this.header1.TabIndex = 0;
            this.header1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicio de Sesion";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnMinVentana
            // 
            this.btnMinVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnMinVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinVentana.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinVentana.FlatAppearance.BorderSize = 0;
            this.btnMinVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinVentana.ForeColor = System.Drawing.Color.Blue;
            this.btnMinVentana.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinVentana.IconColor = System.Drawing.Color.White;
            this.btnMinVentana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinVentana.IconSize = 30;
            this.btnMinVentana.Location = new System.Drawing.Point(1106, 0);
            this.btnMinVentana.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinVentana.Name = "btnMinVentana";
            this.btnMinVentana.Size = new System.Drawing.Size(66, 57);
            this.btnMinVentana.TabIndex = 1;
            this.btnMinVentana.UseVisualStyleBackColor = false;
            this.btnMinVentana.Click += new System.EventHandler(this.minVentana_Click);
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarVentana.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarVentana.FlatAppearance.BorderSize = 0;
            this.btnCerrarVentana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCerrarVentana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVentana.ForeColor = System.Drawing.Color.Blue;
            this.btnCerrarVentana.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrarVentana.IconColor = System.Drawing.Color.White;
            this.btnCerrarVentana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarVentana.IconSize = 30;
            this.btnCerrarVentana.Location = new System.Drawing.Point(1172, 0);
            this.btnCerrarVentana.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(72, 57);
            this.btnCerrarVentana.TabIndex = 0;
            this.btnCerrarVentana.UseVisualStyleBackColor = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.cerrarVentana_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correro electronico:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(36, 235);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsuario.Multiline = true;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(656, 46);
            this.tbUsuario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Colocar la contraseña";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(36, 379);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(656, 46);
            this.tbPassword.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 684);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 12);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lbErrorInicioSesion
            // 
            this.lbErrorInicioSesion.AutoSize = true;
            this.lbErrorInicioSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorInicioSesion.ForeColor = System.Drawing.Color.Red;
            this.lbErrorInicioSesion.Location = new System.Drawing.Point(171, 486);
            this.lbErrorInicioSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorInicioSesion.Name = "lbErrorInicioSesion";
            this.lbErrorInicioSesion.Size = new System.Drawing.Size(367, 23);
            this.lbErrorInicioSesion.TabIndex = 11;
            this.lbErrorInicioSesion.Text = "Datos incorrectos, ingreselos otraves";
            this.lbErrorInicioSesion.Visible = false;
            // 
            // btnMostrarContrasena
            // 
            this.btnMostrarContrasena.BackColor = System.Drawing.Color.White;
            this.btnMostrarContrasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarContrasena.FlatAppearance.BorderSize = 0;
            this.btnMostrarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContrasena.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnMostrarContrasena.IconColor = System.Drawing.Color.Black;
            this.btnMostrarContrasena.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMostrarContrasena.IconSize = 35;
            this.btnMostrarContrasena.Location = new System.Drawing.Point(647, 385);
            this.btnMostrarContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarContrasena.Name = "btnMostrarContrasena";
            this.btnMostrarContrasena.Size = new System.Drawing.Size(39, 32);
            this.btnMostrarContrasena.TabIndex = 12;
            this.btnMostrarContrasena.UseVisualStyleBackColor = false;
            this.btnMostrarContrasena.Click += new System.EventHandler(this.btnMostrarContrasena_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.UserDeafault;
            this.pictureBox1.Location = new System.Drawing.Point(13, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // panelLoginLeft
            // 
            this.panelLoginLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelLoginLeft.Controls.Add(this.label4);
            this.panelLoginLeft.Controls.Add(this.pictureBox1);
            this.panelLoginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoginLeft.Location = new System.Drawing.Point(0, 57);
            this.panelLoginLeft.Name = "panelLoginLeft";
            this.panelLoginLeft.Size = new System.Drawing.Size(492, 627);
            this.panelLoginLeft.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 576);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Departamento de Mantenimiento";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIniciarSesion);
            this.panel2.Controls.Add(this.btnSinUso);
            this.panel2.Controls.Add(this.btnMostrarContrasena);
            this.panel2.Controls.Add(this.tbUsuario);
            this.panel2.Controls.Add(this.lbErrorInicioSesion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(498, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 627);
            this.panel2.TabIndex = 14;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.AnimationHoverSpeed = 0.07F;
            this.btnIniciarSesion.AnimationSpeed = 0.03F;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.BaseColor = System.Drawing.Color.Blue;
            this.btnIniciarSesion.BorderColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIniciarSesion.FocusedColor = System.Drawing.Color.Empty;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Image = null;
            this.btnIniciarSesion.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIniciarSesion.Location = new System.Drawing.Point(36, 534);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnIniciarSesion.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnIniciarSesion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.OnHoverImage = null;
            this.btnIniciarSesion.OnPressedColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.Radius = 5;
            this.btnIniciarSesion.Size = new System.Drawing.Size(656, 71);
            this.btnIniciarSesion.TabIndex = 14;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnSinUso
            // 
            this.btnSinUso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSinUso.FlatAppearance.BorderSize = 0;
            this.btnSinUso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btnSinUso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btnSinUso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinUso.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnSinUso.IconColor = System.Drawing.Color.White;
            this.btnSinUso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSinUso.IconSize = 110;
            this.btnSinUso.Location = new System.Drawing.Point(0, 0);
            this.btnSinUso.Name = "btnSinUso";
            this.btnSinUso.Size = new System.Drawing.Size(746, 155);
            this.btnSinUso.TabIndex = 13;
            this.btnSinUso.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1244, 696);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLoginLeft);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.header1.ResumeLayout(false);
            this.header1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLoginLeft.ResumeLayout(false);
            this.panelLoginLeft.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header1;
        private FontAwesome.Sharp.IconButton btnCerrarVentana;
        private FontAwesome.Sharp.IconButton btnMinVentana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbErrorInicioSesion;
        private FontAwesome.Sharp.IconButton btnMostrarContrasena;
        private System.Windows.Forms.Panel panelLoginLeft;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnSinUso;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton btnIniciarSesion;
    }
}

