
namespace Presentation
{
    partial class HistorialActividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialActividades));
            this.panelRAHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerDetalles = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewHistorial = new System.Windows.Forms.ListView();
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFiltrar = new Guna.UI.WinForms.GunaButton();
            this.btnCancelar = new Guna.UI.WinForms.GunaButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbUsuario = new Guna.UI.WinForms.GunaComboBox();
            this.panelRAHeader.SuspendLayout();
            this.panelFiltro.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRAHeader
            // 
            this.panelRAHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelRAHeader.Controls.Add(this.label1);
            this.panelRAHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRAHeader.Location = new System.Drawing.Point(0, 0);
            this.panelRAHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelRAHeader.Name = "panelRAHeader";
            this.panelRAHeader.Size = new System.Drawing.Size(1103, 50);
            this.panelRAHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Historial de actividades terminadas";
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerDetalles.AnimationHoverSpeed = 0.07F;
            this.btnVerDetalles.AnimationSpeed = 0.03F;
            this.btnVerDetalles.BackColor = System.Drawing.Color.Transparent;
            this.btnVerDetalles.BaseColor = System.Drawing.Color.Green;
            this.btnVerDetalles.BorderColor = System.Drawing.Color.Black;
            this.btnVerDetalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerDetalles.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVerDetalles.FocusedColor = System.Drawing.Color.Empty;
            this.btnVerDetalles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalles.ForeColor = System.Drawing.Color.White;
            this.btnVerDetalles.Image = null;
            this.btnVerDetalles.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVerDetalles.Location = new System.Drawing.Point(4, 6);
            this.btnVerDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.OnHoverBaseColor = System.Drawing.Color.DarkGreen;
            this.btnVerDetalles.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVerDetalles.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVerDetalles.OnHoverImage = null;
            this.btnVerDetalles.OnPressedColor = System.Drawing.Color.Black;
            this.btnVerDetalles.Radius = 10;
            this.btnVerDetalles.Size = new System.Drawing.Size(270, 60);
            this.btnVerDetalles.TabIndex = 30;
            this.btnVerDetalles.Text = "Ver detalles del historial";
            this.btnVerDetalles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 732);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 22);
            this.panel1.TabIndex = 1;
            // 
            // listViewHistorial
            // 
            this.listViewHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewHistorial.BackColor = System.Drawing.Color.White;
            this.listViewHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewHistorial.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listViewHistorial.FullRowSelect = true;
            this.listViewHistorial.HideSelection = false;
            this.listViewHistorial.Location = new System.Drawing.Point(12, 195);
            this.listViewHistorial.Name = "listViewHistorial";
            this.listViewHistorial.Size = new System.Drawing.Size(1079, 530);
            this.listViewHistorial.TabIndex = 2;
            this.listViewHistorial.UseCompatibleStateImageBehavior = false;
            // 
            // panelFiltro
            // 
            this.panelFiltro.Controls.Add(this.panel3);
            this.panelFiltro.Controls.Add(this.panel2);
            this.panelFiltro.Controls.Add(this.panel4);
            this.panelFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltro.Location = new System.Drawing.Point(0, 50);
            this.panelFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(1103, 138);
            this.panelFiltro.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnVerDetalles);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(547, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 138);
            this.panel3.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(825, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 138);
            this.panel2.TabIndex = 24;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.AnimationHoverSpeed = 0.07F;
            this.btnFiltrar.AnimationSpeed = 0.03F;
            this.btnFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrar.BaseColor = System.Drawing.Color.Blue;
            this.btnFiltrar.BorderColor = System.Drawing.Color.Black;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFiltrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Image = null;
            this.btnFiltrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFiltrar.Location = new System.Drawing.Point(4, 6);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFiltrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFiltrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFiltrar.OnHoverImage = null;
            this.btnFiltrar.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnFiltrar.Radius = 10;
            this.btnFiltrar.Size = new System.Drawing.Size(270, 60);
            this.btnFiltrar.TabIndex = 28;
            this.btnFiltrar.Text = "Filtrar tareas";
            this.btnFiltrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AnimationHoverSpeed = 0.07F;
            this.btnCancelar.AnimationSpeed = 0.03F;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BaseColor = System.Drawing.Color.Red;
            this.btnCancelar.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancelar.Location = new System.Drawing.Point(4, 73);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnHoverImage = null;
            this.btnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancelar.Radius = 10;
            this.btnCancelar.Size = new System.Drawing.Size(270, 60);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.cmbUsuario);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(541, 138);
            this.panel4.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(273, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Usuario que termino la tarea:";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cmbUsuario.BaseColor = System.Drawing.Color.White;
            this.cmbUsuario.BorderColor = System.Drawing.Color.Silver;
            this.cmbUsuario.BorderSize = 0;
            this.cmbUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FocusedColor = System.Drawing.Color.Empty;
            this.cmbUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbUsuario.ForeColor = System.Drawing.Color.Black;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(12, 35);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbUsuario.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbUsuario.Radius = 5;
            this.cmbUsuario.Size = new System.Drawing.Size(525, 31);
            this.cmbUsuario.TabIndex = 22;
            // 
            // HistorialActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1103, 754);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.listViewHistorial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRAHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HistorialActividades";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.HistorialActividades_Load);
            this.panelRAHeader.ResumeLayout(false);
            this.panelRAHeader.PerformLayout();
            this.panelFiltro.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRAHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewHistorial;
        private Guna.UI.WinForms.GunaButton btnVerDetalles;
        private System.Windows.Forms.Panel panelFiltro;
        private Guna.UI.WinForms.GunaButton btnCancelar;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaButton btnFiltrar;
        private Guna.UI.WinForms.GunaComboBox cmbUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}