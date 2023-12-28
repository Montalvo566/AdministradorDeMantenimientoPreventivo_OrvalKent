
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
            this.panelSecciones = new System.Windows.Forms.Panel();
            this.btnSeccionMenu = new FontAwesome.Sharp.IconButton();
            this.btnSecciones = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnActividades = new FontAwesome.Sharp.IconButton();
            this.btnMenuPrincipal = new FontAwesome.Sharp.IconButton();
            this.pLogo = new System.Windows.Forms.Panel();
            this.panelFormularioHijo = new System.Windows.Forms.Panel();
            this.pMenuLateral.SuspendLayout();
            this.panelSecciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenuLateral
            // 
            this.pMenuLateral.AutoScroll = true;
            this.pMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pMenuLateral.Controls.Add(this.panelSecciones);
            this.pMenuLateral.Controls.Add(this.btnSecciones);
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
            // panelSecciones
            // 
            this.panelSecciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSecciones.Controls.Add(this.btnSeccionMenu);
            this.panelSecciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSecciones.Location = new System.Drawing.Point(0, 326);
            this.panelSecciones.Name = "panelSecciones";
            this.panelSecciones.Size = new System.Drawing.Size(244, 67);
            this.panelSecciones.TabIndex = 2;
            // 
            // btnSeccionMenu
            // 
            this.btnSeccionMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnSeccionMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeccionMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeccionMenu.FlatAppearance.BorderSize = 0;
            this.btnSeccionMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeccionMenu.ForeColor = System.Drawing.Color.White;
            this.btnSeccionMenu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSeccionMenu.IconColor = System.Drawing.Color.Black;
            this.btnSeccionMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeccionMenu.Location = new System.Drawing.Point(0, 0);
            this.btnSeccionMenu.Name = "btnSeccionMenu";
            this.btnSeccionMenu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSeccionMenu.Size = new System.Drawing.Size(244, 40);
            this.btnSeccionMenu.TabIndex = 0;
            this.btnSeccionMenu.Text = "Seccion";
            this.btnSeccionMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeccionMenu.UseVisualStyleBackColor = false;
            this.btnSeccionMenu.Click += new System.EventHandler(this.btnSeccionMenu_Click);
            // 
            // btnSecciones
            // 
            this.btnSecciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSecciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecciones.FlatAppearance.BorderSize = 0;
            this.btnSecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecciones.ForeColor = System.Drawing.Color.White;
            this.btnSecciones.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSecciones.IconColor = System.Drawing.Color.Black;
            this.btnSecciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSecciones.Location = new System.Drawing.Point(0, 281);
            this.btnSecciones.Name = "btnSecciones";
            this.btnSecciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSecciones.Size = new System.Drawing.Size(244, 45);
            this.btnSecciones.TabIndex = 2;
            this.btnSecciones.Text = "Secciones";
            this.btnSecciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecciones.UseVisualStyleBackColor = false;
            this.btnSecciones.Click += new System.EventHandler(this.btnSecciones_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUsuarios.IconColor = System.Drawing.Color.Black;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 236);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(244, 45);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnActividades
            // 
            this.btnActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActividades.FlatAppearance.BorderSize = 0;
            this.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActividades.ForeColor = System.Drawing.Color.White;
            this.btnActividades.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnActividades.IconColor = System.Drawing.Color.Black;
            this.btnActividades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActividades.Location = new System.Drawing.Point(0, 191);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnActividades.Size = new System.Drawing.Size(244, 45);
            this.btnActividades.TabIndex = 2;
            this.btnActividades.Text = "Actividades";
            this.btnActividades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActividades.UseVisualStyleBackColor = false;
            this.btnActividades.Click += new System.EventHandler(this.btnActividades_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuPrincipal.FlatAppearance.BorderSize = 0;
            this.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnMenuPrincipal.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMenuPrincipal.IconColor = System.Drawing.Color.Black;
            this.btnMenuPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuPrincipal.Location = new System.Drawing.Point(0, 146);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuPrincipal.Size = new System.Drawing.Size(244, 45);
            this.btnMenuPrincipal.TabIndex = 1;
            this.btnMenuPrincipal.Text = "Menú Principal";
            this.btnMenuPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // pLogo
            // 
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(244, 146);
            this.pLogo.TabIndex = 0;
            // 
            // panelFormularioHijo
            // 
            this.panelFormularioHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelFormularioHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularioHijo.Location = new System.Drawing.Point(244, 0);
            this.panelFormularioHijo.Name = "panelFormularioHijo";
            this.panelFormularioHijo.Size = new System.Drawing.Size(825, 613);
            this.panelFormularioHijo.TabIndex = 2;
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
            this.pMenuLateral.ResumeLayout(false);
            this.panelSecciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenuLateral;
        private FontAwesome.Sharp.IconButton btnActividades;
        private FontAwesome.Sharp.IconButton btnMenuPrincipal;
        private System.Windows.Forms.Panel pLogo;
        private FontAwesome.Sharp.IconButton btnSeccionMenu;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private System.Windows.Forms.Panel panelSecciones;
        private System.Windows.Forms.Panel panelFormularioHijo;
        private FontAwesome.Sharp.IconButton btnSecciones;
    }
}

