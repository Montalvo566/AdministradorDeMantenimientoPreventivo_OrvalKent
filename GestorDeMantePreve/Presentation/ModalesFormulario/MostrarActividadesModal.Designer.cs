
namespace Presentation.ModalesFormulario
{
    partial class MostrarActividadesModal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarTarea = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbActividad = new Guna.UI.WinForms.GunaTextBox();
            this.panelActividades = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEstatus = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFechaAsignado = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUsuarioAsignado = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRegistro = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFrecuencia = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEquipo = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbArea = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelActividades.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.btnCerrarTarea);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 51);
            this.panel1.TabIndex = 3;
            // 
            // btnCerrarTarea
            // 
            this.btnCerrarTarea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarTarea.AnimationHoverSpeed = 0.07F;
            this.btnCerrarTarea.AnimationSpeed = 0.03F;
            this.btnCerrarTarea.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarTarea.BaseColor = System.Drawing.Color.Red;
            this.btnCerrarTarea.BorderColor = System.Drawing.Color.Black;
            this.btnCerrarTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarTarea.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrarTarea.FocusedColor = System.Drawing.Color.Empty;
            this.btnCerrarTarea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarTarea.ForeColor = System.Drawing.Color.White;
            this.btnCerrarTarea.Image = null;
            this.btnCerrarTarea.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCerrarTarea.Location = new System.Drawing.Point(16, 7);
            this.btnCerrarTarea.Name = "btnCerrarTarea";
            this.btnCerrarTarea.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarTarea.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCerrarTarea.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCerrarTarea.OnHoverImage = null;
            this.btnCerrarTarea.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerrarTarea.Radius = 10;
            this.btnCerrarTarea.Size = new System.Drawing.Size(548, 39);
            this.btnCerrarTarea.TabIndex = 30;
            this.btnCerrarTarea.Text = "Cerrar tarea";
            this.btnCerrarTarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCerrarTarea.Click += new System.EventHandler(this.btnCerrarTarea_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 38);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Información de la actividad";
            // 
            // tbActividad
            // 
            this.tbActividad.BackColor = System.Drawing.Color.Transparent;
            this.tbActividad.BaseColor = System.Drawing.Color.White;
            this.tbActividad.BorderColor = System.Drawing.Color.Silver;
            this.tbActividad.BorderSize = 0;
            this.tbActividad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbActividad.FocusedBaseColor = System.Drawing.Color.White;
            this.tbActividad.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbActividad.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbActividad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActividad.Location = new System.Drawing.Point(121, 59);
            this.tbActividad.Name = "tbActividad";
            this.tbActividad.PasswordChar = '\0';
            this.tbActividad.Radius = 5;
            this.tbActividad.SelectedText = "";
            this.tbActividad.Size = new System.Drawing.Size(443, 90);
            this.tbActividad.TabIndex = 8;
            // 
            // panelActividades
            // 
            this.panelActividades.Controls.Add(this.label10);
            this.panelActividades.Controls.Add(this.tbEstatus);
            this.panelActividades.Controls.Add(this.label9);
            this.panelActividades.Controls.Add(this.tbFechaAsignado);
            this.panelActividades.Controls.Add(this.label7);
            this.panelActividades.Controls.Add(this.tbUsuarioAsignado);
            this.panelActividades.Controls.Add(this.label6);
            this.panelActividades.Controls.Add(this.tbRegistro);
            this.panelActividades.Controls.Add(this.label5);
            this.panelActividades.Controls.Add(this.tbFrecuencia);
            this.panelActividades.Controls.Add(this.label4);
            this.panelActividades.Controls.Add(this.tbEquipo);
            this.panelActividades.Controls.Add(this.label3);
            this.panelActividades.Controls.Add(this.tbArea);
            this.panelActividades.Controls.Add(this.label2);
            this.panelActividades.Controls.Add(this.tbId);
            this.panelActividades.Controls.Add(this.label8);
            this.panelActividades.Controls.Add(this.tbActividad);
            this.panelActividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActividades.Location = new System.Drawing.Point(0, 38);
            this.panelActividades.Name = "panelActividades";
            this.panelActividades.Size = new System.Drawing.Size(583, 488);
            this.panelActividades.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(160, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Estado de la actividad:";
            // 
            // tbEstatus
            // 
            this.tbEstatus.BackColor = System.Drawing.Color.Transparent;
            this.tbEstatus.BaseColor = System.Drawing.Color.White;
            this.tbEstatus.BorderColor = System.Drawing.Color.Silver;
            this.tbEstatus.BorderSize = 0;
            this.tbEstatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEstatus.FocusedBaseColor = System.Drawing.Color.White;
            this.tbEstatus.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbEstatus.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbEstatus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEstatus.Location = new System.Drawing.Point(344, 435);
            this.tbEstatus.Name = "tbEstatus";
            this.tbEstatus.PasswordChar = '\0';
            this.tbEstatus.Radius = 5;
            this.tbEstatus.SelectedText = "";
            this.tbEstatus.Size = new System.Drawing.Size(220, 42);
            this.tbEstatus.TabIndex = 39;
            this.tbEstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(56, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Fecha:";
            // 
            // tbFechaAsignado
            // 
            this.tbFechaAsignado.BackColor = System.Drawing.Color.Transparent;
            this.tbFechaAsignado.BaseColor = System.Drawing.Color.White;
            this.tbFechaAsignado.BorderColor = System.Drawing.Color.Silver;
            this.tbFechaAsignado.BorderSize = 0;
            this.tbFechaAsignado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFechaAsignado.FocusedBaseColor = System.Drawing.Color.White;
            this.tbFechaAsignado.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbFechaAsignado.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbFechaAsignado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaAsignado.Location = new System.Drawing.Point(121, 389);
            this.tbFechaAsignado.Name = "tbFechaAsignado";
            this.tbFechaAsignado.PasswordChar = '\0';
            this.tbFechaAsignado.Radius = 5;
            this.tbFechaAsignado.SelectedText = "";
            this.tbFechaAsignado.Size = new System.Drawing.Size(443, 29);
            this.tbFechaAsignado.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(48, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Usuario:";
            // 
            // tbUsuarioAsignado
            // 
            this.tbUsuarioAsignado.BackColor = System.Drawing.Color.Transparent;
            this.tbUsuarioAsignado.BaseColor = System.Drawing.Color.White;
            this.tbUsuarioAsignado.BorderColor = System.Drawing.Color.Silver;
            this.tbUsuarioAsignado.BorderSize = 0;
            this.tbUsuarioAsignado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsuarioAsignado.FocusedBaseColor = System.Drawing.Color.White;
            this.tbUsuarioAsignado.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbUsuarioAsignado.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbUsuarioAsignado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuarioAsignado.Location = new System.Drawing.Point(121, 343);
            this.tbUsuarioAsignado.Name = "tbUsuarioAsignado";
            this.tbUsuarioAsignado.PasswordChar = '\0';
            this.tbUsuarioAsignado.Radius = 5;
            this.tbUsuarioAsignado.SelectedText = "";
            this.tbUsuarioAsignado.Size = new System.Drawing.Size(443, 29);
            this.tbUsuarioAsignado.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(44, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Registro:";
            // 
            // tbRegistro
            // 
            this.tbRegistro.BackColor = System.Drawing.Color.Transparent;
            this.tbRegistro.BaseColor = System.Drawing.Color.White;
            this.tbRegistro.BorderColor = System.Drawing.Color.Silver;
            this.tbRegistro.BorderSize = 0;
            this.tbRegistro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRegistro.FocusedBaseColor = System.Drawing.Color.White;
            this.tbRegistro.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbRegistro.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbRegistro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegistro.Location = new System.Drawing.Point(121, 298);
            this.tbRegistro.Name = "tbRegistro";
            this.tbRegistro.PasswordChar = '\0';
            this.tbRegistro.Radius = 5;
            this.tbRegistro.SelectedText = "";
            this.tbRegistro.Size = new System.Drawing.Size(443, 29);
            this.tbRegistro.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Frecuencia:";
            // 
            // tbFrecuencia
            // 
            this.tbFrecuencia.BackColor = System.Drawing.Color.Transparent;
            this.tbFrecuencia.BaseColor = System.Drawing.Color.White;
            this.tbFrecuencia.BorderColor = System.Drawing.Color.Silver;
            this.tbFrecuencia.BorderSize = 0;
            this.tbFrecuencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFrecuencia.FocusedBaseColor = System.Drawing.Color.White;
            this.tbFrecuencia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbFrecuencia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbFrecuencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFrecuencia.Location = new System.Drawing.Point(121, 254);
            this.tbFrecuencia.Name = "tbFrecuencia";
            this.tbFrecuencia.PasswordChar = '\0';
            this.tbFrecuencia.Radius = 5;
            this.tbFrecuencia.SelectedText = "";
            this.tbFrecuencia.Size = new System.Drawing.Size(443, 29);
            this.tbFrecuencia.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Equipo:";
            // 
            // tbEquipo
            // 
            this.tbEquipo.BackColor = System.Drawing.Color.Transparent;
            this.tbEquipo.BaseColor = System.Drawing.Color.White;
            this.tbEquipo.BorderColor = System.Drawing.Color.Silver;
            this.tbEquipo.BorderSize = 0;
            this.tbEquipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEquipo.FocusedBaseColor = System.Drawing.Color.White;
            this.tbEquipo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbEquipo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbEquipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEquipo.Location = new System.Drawing.Point(121, 209);
            this.tbEquipo.Name = "tbEquipo";
            this.tbEquipo.PasswordChar = '\0';
            this.tbEquipo.Radius = 5;
            this.tbEquipo.SelectedText = "";
            this.tbEquipo.Size = new System.Drawing.Size(443, 29);
            this.tbEquipo.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Area:";
            // 
            // tbArea
            // 
            this.tbArea.BackColor = System.Drawing.Color.Transparent;
            this.tbArea.BaseColor = System.Drawing.Color.White;
            this.tbArea.BorderColor = System.Drawing.Color.Silver;
            this.tbArea.BorderSize = 0;
            this.tbArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbArea.FocusedBaseColor = System.Drawing.Color.White;
            this.tbArea.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbArea.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbArea.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArea.Location = new System.Drawing.Point(121, 165);
            this.tbArea.Name = "tbArea";
            this.tbArea.PasswordChar = '\0';
            this.tbArea.Radius = 5;
            this.tbArea.SelectedText = "";
            this.tbArea.Size = new System.Drawing.Size(443, 29);
            this.tbArea.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Id actividad:";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.Transparent;
            this.tbId.BaseColor = System.Drawing.Color.White;
            this.tbId.BorderColor = System.Drawing.Color.Silver;
            this.tbId.BorderSize = 0;
            this.tbId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbId.FocusedBaseColor = System.Drawing.Color.White;
            this.tbId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(121, 17);
            this.tbId.Name = "tbId";
            this.tbId.PasswordChar = '\0';
            this.tbId.Radius = 5;
            this.tbId.SelectedText = "";
            this.tbId.Size = new System.Drawing.Size(443, 30);
            this.tbId.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Actividad:";
            // 
            // MostrarActividadesModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(583, 583);
            this.Controls.Add(this.panelActividades);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarActividadesModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarActividadesModal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelActividades.ResumeLayout(false);
            this.panelActividades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnCerrarTarea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelActividades;
        public Guna.UI.WinForms.GunaTextBox tbActividad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaTextBox tbId;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaTextBox tbArea;
        private System.Windows.Forms.Label label4;
        public Guna.UI.WinForms.GunaTextBox tbEquipo;
        private System.Windows.Forms.Label label5;
        public Guna.UI.WinForms.GunaTextBox tbFrecuencia;
        private System.Windows.Forms.Label label6;
        public Guna.UI.WinForms.GunaTextBox tbRegistro;
        private System.Windows.Forms.Label label7;
        public Guna.UI.WinForms.GunaTextBox tbUsuarioAsignado;
        private System.Windows.Forms.Label label9;
        public Guna.UI.WinForms.GunaTextBox tbFechaAsignado;
        private System.Windows.Forms.Label label10;
        public Guna.UI.WinForms.GunaTextBox tbEstatus;
    }
}