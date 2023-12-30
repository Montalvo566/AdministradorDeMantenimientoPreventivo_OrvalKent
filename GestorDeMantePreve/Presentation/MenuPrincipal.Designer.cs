
namespace Presentation
{
    partial class MenuPrincipal
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
            this.pMenuLateral = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.panelSeccionTareas = new System.Windows.Forms.Panel();
            this.btnSeccionTareas = new FontAwesome.Sharp.IconButton();
            this.btnTareasAsignadas = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnActividades = new FontAwesome.Sharp.IconButton();
            this.btnMenuPrincipal = new FontAwesome.Sharp.IconButton();
            this.pLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFormularioHijo = new System.Windows.Forms.Panel();
            this.lbNombreInicioSesion = new System.Windows.Forms.Label();
            this.lbCorreoInicioSesion = new System.Windows.Forms.Label();
            this.pMenuLateral.SuspendLayout();
            this.panelSeccionTareas.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenuLateral
            // 
            this.pMenuLateral.AutoScroll = true;
            this.pMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pMenuLateral.Controls.Add(this.btnCerrarSesion);
            this.pMenuLateral.Controls.Add(this.panelSeccionTareas);
            this.pMenuLateral.Controls.Add(this.btnTareasAsignadas);
            this.pMenuLateral.Controls.Add(this.btnUsuarios);
            this.pMenuLateral.Controls.Add(this.btnActividades);
            this.pMenuLateral.Controls.Add(this.btnMenuPrincipal);
            this.pMenuLateral.Controls.Add(this.pLogo);
            this.pMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pMenuLateral.Name = "pMenuLateral";
            this.pMenuLateral.Size = new System.Drawing.Size(244, 613);
            this.pMenuLateral.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.IconSize = 30;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 553);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(244, 60);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelSeccionTareas
            // 
            this.panelSeccionTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelSeccionTareas.Controls.Add(this.btnSeccionTareas);
            this.panelSeccionTareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeccionTareas.Location = new System.Drawing.Point(0, 399);
            this.panelSeccionTareas.Name = "panelSeccionTareas";
            this.panelSeccionTareas.Size = new System.Drawing.Size(244, 93);
            this.panelSeccionTareas.TabIndex = 2;
            // 
            // btnSeccionTareas
            // 
            this.btnSeccionTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btnSeccionTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeccionTareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeccionTareas.FlatAppearance.BorderSize = 0;
            this.btnSeccionTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeccionTareas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeccionTareas.ForeColor = System.Drawing.Color.White;
            this.btnSeccionTareas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSeccionTareas.IconColor = System.Drawing.Color.Black;
            this.btnSeccionTareas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeccionTareas.Location = new System.Drawing.Point(0, 0);
            this.btnSeccionTareas.Name = "btnSeccionTareas";
            this.btnSeccionTareas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSeccionTareas.Size = new System.Drawing.Size(244, 55);
            this.btnSeccionTareas.TabIndex = 0;
            this.btnSeccionTareas.Text = "Seccion";
            this.btnSeccionTareas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeccionTareas.UseVisualStyleBackColor = false;
            this.btnSeccionTareas.Click += new System.EventHandler(this.btnSeccionTareas_Click);
            // 
            // btnTareasAsignadas
            // 
            this.btnTareasAsignadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnTareasAsignadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTareasAsignadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTareasAsignadas.FlatAppearance.BorderSize = 0;
            this.btnTareasAsignadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareasAsignadas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareasAsignadas.ForeColor = System.Drawing.Color.White;
            this.btnTareasAsignadas.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.btnTareasAsignadas.IconColor = System.Drawing.Color.White;
            this.btnTareasAsignadas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTareasAsignadas.IconSize = 30;
            this.btnTareasAsignadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareasAsignadas.Location = new System.Drawing.Point(0, 339);
            this.btnTareasAsignadas.Name = "btnTareasAsignadas";
            this.btnTareasAsignadas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTareasAsignadas.Size = new System.Drawing.Size(244, 60);
            this.btnTareasAsignadas.TabIndex = 2;
            this.btnTareasAsignadas.Text = "Tareas Asignadas";
            this.btnTareasAsignadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareasAsignadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTareasAsignadas.UseVisualStyleBackColor = false;
            this.btnTareasAsignadas.Click += new System.EventHandler(this.btnTareasAsignadas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 30;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 279);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(244, 60);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnActividades
            // 
            this.btnActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActividades.FlatAppearance.BorderSize = 0;
            this.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActividades.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActividades.ForeColor = System.Drawing.Color.White;
            this.btnActividades.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnActividades.IconColor = System.Drawing.Color.White;
            this.btnActividades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActividades.IconSize = 30;
            this.btnActividades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActividades.Location = new System.Drawing.Point(0, 219);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnActividades.Size = new System.Drawing.Size(244, 60);
            this.btnActividades.TabIndex = 2;
            this.btnActividades.Text = "Actividades";
            this.btnActividades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActividades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActividades.UseVisualStyleBackColor = false;
            this.btnActividades.Click += new System.EventHandler(this.btnActividades_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuPrincipal.FlatAppearance.BorderSize = 0;
            this.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnMenuPrincipal.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnMenuPrincipal.IconColor = System.Drawing.Color.White;
            this.btnMenuPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuPrincipal.IconSize = 30;
            this.btnMenuPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPrincipal.Location = new System.Drawing.Point(0, 159);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuPrincipal.Size = new System.Drawing.Size(244, 60);
            this.btnMenuPrincipal.TabIndex = 1;
            this.btnMenuPrincipal.Text = "Menú Principal";
            this.btnMenuPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuPrincipal.UseVisualStyleBackColor = false;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // pLogo
            // 
            this.pLogo.Controls.Add(this.lbCorreoInicioSesion);
            this.pLogo.Controls.Add(this.pictureBox1);
            this.pLogo.Controls.Add(this.lbNombreInicioSesion);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(244, 159);
            this.pLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Presentation.Properties.Resources.OrvalKentLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelFormularioHijo
            // 
            this.panelFormularioHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelFormularioHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularioHijo.Location = new System.Drawing.Point(244, 0);
            this.panelFormularioHijo.Name = "panelFormularioHijo";
            this.panelFormularioHijo.Size = new System.Drawing.Size(825, 613);
            this.panelFormularioHijo.TabIndex = 2;
            // 
            // lbNombreInicioSesion
            // 
            this.lbNombreInicioSesion.AutoSize = true;
            this.lbNombreInicioSesion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreInicioSesion.ForeColor = System.Drawing.Color.White;
            this.lbNombreInicioSesion.Location = new System.Drawing.Point(12, 128);
            this.lbNombreInicioSesion.Name = "lbNombreInicioSesion";
            this.lbNombreInicioSesion.Size = new System.Drawing.Size(51, 16);
            this.lbNombreInicioSesion.TabIndex = 1;
            this.lbNombreInicioSesion.Text = "Nombre";
            // 
            // lbCorreoInicioSesion
            // 
            this.lbCorreoInicioSesion.AutoSize = true;
            this.lbCorreoInicioSesion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreoInicioSesion.ForeColor = System.Drawing.Color.White;
            this.lbCorreoInicioSesion.Location = new System.Drawing.Point(126, 128);
            this.lbCorreoInicioSesion.Name = "lbCorreoInicioSesion";
            this.lbCorreoInicioSesion.Size = new System.Drawing.Size(44, 16);
            this.lbCorreoInicioSesion.TabIndex = 2;
            this.lbCorreoInicioSesion.Text = "Correo";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 613);
            this.Controls.Add(this.panelFormularioHijo);
            this.Controls.Add(this.pMenuLateral);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.pMenuLateral.ResumeLayout(false);
            this.panelSeccionTareas.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenuLateral;
        private FontAwesome.Sharp.IconButton btnActividades;
        private FontAwesome.Sharp.IconButton btnMenuPrincipal;
        private System.Windows.Forms.Panel pLogo;
        private FontAwesome.Sharp.IconButton btnSeccionTareas;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private System.Windows.Forms.Panel panelSeccionTareas;
        private System.Windows.Forms.Panel panelFormularioHijo;
        private FontAwesome.Sharp.IconButton btnTareasAsignadas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private System.Windows.Forms.Label lbCorreoInicioSesion;
        private System.Windows.Forms.Label lbNombreInicioSesion;
    }
}

