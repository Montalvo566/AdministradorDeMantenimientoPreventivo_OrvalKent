
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
            this.pActividades = new System.Windows.Forms.Panel();
            this.btnSeccion = new FontAwesome.Sharp.IconButton();
            this.btnActividades = new FontAwesome.Sharp.IconButton();
            this.btnMenuPrincipal = new FontAwesome.Sharp.IconButton();
            this.pLogo = new System.Windows.Forms.Panel();
            this.pMenuLateral.SuspendLayout();
            this.pActividades.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenuLateral
            // 
            this.pMenuLateral.BackColor = System.Drawing.Color.Blue;
            this.pMenuLateral.Controls.Add(this.pActividades);
            this.pMenuLateral.Controls.Add(this.btnActividades);
            this.pMenuLateral.Controls.Add(this.btnMenuPrincipal);
            this.pMenuLateral.Controls.Add(this.pLogo);
            this.pMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pMenuLateral.Name = "pMenuLateral";
            this.pMenuLateral.Size = new System.Drawing.Size(250, 588);
            this.pMenuLateral.TabIndex = 0;
            // 
            // pActividades
            // 
            this.pActividades.BackColor = System.Drawing.Color.Navy;
            this.pActividades.Controls.Add(this.btnSeccion);
            this.pActividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.pActividades.Location = new System.Drawing.Point(0, 190);
            this.pActividades.Name = "pActividades";
            this.pActividades.Size = new System.Drawing.Size(250, 50);
            this.pActividades.TabIndex = 3;
            // 
            // btnSeccion
            // 
            this.btnSeccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeccion.FlatAppearance.BorderSize = 0;
            this.btnSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeccion.ForeColor = System.Drawing.Color.White;
            this.btnSeccion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSeccion.IconColor = System.Drawing.Color.Black;
            this.btnSeccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeccion.Location = new System.Drawing.Point(0, 0);
            this.btnSeccion.Name = "btnSeccion";
            this.btnSeccion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSeccion.Size = new System.Drawing.Size(250, 40);
            this.btnSeccion.TabIndex = 0;
            this.btnSeccion.Text = "Seccion";
            this.btnSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeccion.UseVisualStyleBackColor = true;
            // 
            // btnActividades
            // 
            this.btnActividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActividades.FlatAppearance.BorderSize = 0;
            this.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActividades.ForeColor = System.Drawing.Color.White;
            this.btnActividades.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnActividades.IconColor = System.Drawing.Color.Black;
            this.btnActividades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActividades.Location = new System.Drawing.Point(0, 145);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnActividades.Size = new System.Drawing.Size(250, 45);
            this.btnActividades.TabIndex = 2;
            this.btnActividades.Text = "Actividades";
            this.btnActividades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActividades.UseVisualStyleBackColor = true;
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
            this.btnMenuPrincipal.Location = new System.Drawing.Point(0, 100);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuPrincipal.Size = new System.Drawing.Size(250, 45);
            this.btnMenuPrincipal.TabIndex = 1;
            this.btnMenuPrincipal.Text = "Menú Principal";
            this.btnMenuPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // pLogo
            // 
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(250, 100);
            this.pLogo.TabIndex = 0;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.pMenuLateral);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.pMenuLateral.ResumeLayout(false);
            this.pActividades.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenuLateral;
        private System.Windows.Forms.Panel pActividades;
        private FontAwesome.Sharp.IconButton btnActividades;
        private FontAwesome.Sharp.IconButton btnMenuPrincipal;
        private System.Windows.Forms.Panel pLogo;
        private FontAwesome.Sharp.IconButton btnSeccion;
    }
}

