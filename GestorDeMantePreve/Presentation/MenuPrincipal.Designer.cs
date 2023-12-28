
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
            this.pLogo = new System.Windows.Forms.Panel();
            this.panelFormularioHijo = new System.Windows.Forms.Panel();
            this.btnSeccionMenu = new FontAwesome.Sharp.IconButton();
            this.btnSecciones = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnActividades = new FontAwesome.Sharp.IconButton();
            this.btnMenuPrincipal = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarVentana = new FontAwesome.Sharp.IconButton();
            this.btnMinimizarVentana = new FontAwesome.Sharp.IconButton();
            this.btnMaximizarVentana = new FontAwesome.Sharp.IconButton();
            this.pMenuLateral.SuspendLayout();
            this.panelSecciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenuLateral
            // 
            this.pMenuLateral.AutoScroll = true;
            this.pMenuLateral.BackColor = System.Drawing.Color.Blue;
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
            this.panelSecciones.BackColor = System.Drawing.Color.Navy;
            this.panelSecciones.Controls.Add(this.btnSeccionMenu);
            this.panelSecciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSecciones.Location = new System.Drawing.Point(0, 293);
            this.panelSecciones.Name = "panelSecciones";
            this.panelSecciones.Size = new System.Drawing.Size(244, 67);
            this.panelSecciones.TabIndex = 2;
            // 
            // pLogo
            // 
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(244, 113);
            this.pLogo.TabIndex = 0;
            // 
            // panelFormularioHijo
            // 
            this.panelFormularioHijo.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelFormularioHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularioHijo.Location = new System.Drawing.Point(244, 0);
            this.panelFormularioHijo.Name = "panelFormularioHijo";
            this.panelFormularioHijo.Size = new System.Drawing.Size(825, 613);
            this.panelFormularioHijo.TabIndex = 2;
            // 
            // btnSeccionMenu
            // 
            this.btnSeccionMenu.BackColor = System.Drawing.Color.Transparent;
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
            this.btnSecciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecciones.FlatAppearance.BorderSize = 0;
            this.btnSecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecciones.ForeColor = System.Drawing.Color.White;
            this.btnSecciones.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSecciones.IconColor = System.Drawing.Color.Black;
            this.btnSecciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSecciones.Location = new System.Drawing.Point(0, 248);
            this.btnSecciones.Name = "btnSecciones";
            this.btnSecciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSecciones.Size = new System.Drawing.Size(244, 45);
            this.btnSecciones.TabIndex = 2;
            this.btnSecciones.Text = "Secciones";
            this.btnSecciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecciones.UseVisualStyleBackColor = true;
            this.btnSecciones.Click += new System.EventHandler(this.btnSecciones_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Blue;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUsuarios.IconColor = System.Drawing.Color.Black;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 203);
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
            this.btnActividades.BackColor = System.Drawing.Color.Blue;
            this.btnActividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActividades.FlatAppearance.BorderSize = 0;
            this.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActividades.ForeColor = System.Drawing.Color.White;
            this.btnActividades.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnActividades.IconColor = System.Drawing.Color.Black;
            this.btnActividades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActividades.Location = new System.Drawing.Point(0, 158);
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
            this.btnMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuPrincipal.FlatAppearance.BorderSize = 0;
            this.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnMenuPrincipal.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMenuPrincipal.IconColor = System.Drawing.Color.Black;
            this.btnMenuPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuPrincipal.Location = new System.Drawing.Point(0, 113);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuPrincipal.Size = new System.Drawing.Size(244, 45);
            this.btnMenuPrincipal.TabIndex = 1;
            this.btnMenuPrincipal.Text = "Menú Principal";
            this.btnMenuPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btnMinimizarVentana);
            this.panel1.Controls.Add(this.btnMaximizarVentana);
            this.panel1.Controls.Add(this.btnCerrarVentana);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(244, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 24);
            this.panel1.TabIndex = 3;
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.BackColor = System.Drawing.Color.Blue;
            this.btnCerrarVentana.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarVentana.FlatAppearance.BorderSize = 0;
            this.btnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVentana.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrarVentana.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrarVentana.IconColor = System.Drawing.Color.White;
            this.btnCerrarVentana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarVentana.IconSize = 20;
            this.btnCerrarVentana.Location = new System.Drawing.Point(777, 0);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(48, 24);
            this.btnCerrarVentana.TabIndex = 0;
            this.btnCerrarVentana.UseVisualStyleBackColor = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // btnMinimizarVentana
            // 
            this.btnMinimizarVentana.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizarVentana.FlatAppearance.BorderSize = 0;
            this.btnMinimizarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarVentana.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimizarVentana.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizarVentana.IconColor = System.Drawing.Color.White;
            this.btnMinimizarVentana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizarVentana.IconSize = 20;
            this.btnMinimizarVentana.Location = new System.Drawing.Point(681, 0);
            this.btnMinimizarVentana.Name = "btnMinimizarVentana";
            this.btnMinimizarVentana.Size = new System.Drawing.Size(48, 24);
            this.btnMinimizarVentana.TabIndex = 1;
            this.btnMinimizarVentana.UseVisualStyleBackColor = true;
            this.btnMinimizarVentana.Click += new System.EventHandler(this.btnMinimizarVentana_Click);
            // 
            // btnMaximizarVentana
            // 
            this.btnMaximizarVentana.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizarVentana.FlatAppearance.BorderSize = 0;
            this.btnMaximizarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizarVentana.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaximizarVentana.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizarVentana.IconColor = System.Drawing.Color.White;
            this.btnMaximizarVentana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizarVentana.IconSize = 20;
            this.btnMaximizarVentana.Location = new System.Drawing.Point(729, 0);
            this.btnMaximizarVentana.Name = "btnMaximizarVentana";
            this.btnMaximizarVentana.Size = new System.Drawing.Size(48, 24);
            this.btnMaximizarVentana.TabIndex = 2;
            this.btnMaximizarVentana.UseVisualStyleBackColor = true;
            this.btnMaximizarVentana.Click += new System.EventHandler(this.btnMaximizarVentana_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFormularioHijo);
            this.Controls.Add(this.pMenuLateral);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.pMenuLateral.ResumeLayout(false);
            this.panelSecciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCerrarVentana;
        private FontAwesome.Sharp.IconButton btnMinimizarVentana;
        private FontAwesome.Sharp.IconButton btnMaximizarVentana;
    }
}

