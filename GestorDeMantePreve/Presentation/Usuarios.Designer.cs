﻿
namespace Presentation
{
    partial class Usuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCrudUser = new System.Windows.Forms.Panel();
            this.gcmbPuesto = new Guna.UI.WinForms.GunaComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gtbFoto = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gtbPassword = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gtbCorreo = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gcmbArea = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gcmbDepartamento = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gtbNumeroTrabajador = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gtbNombreCompleto = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAbriModalEdit = new Guna.UI.WinForms.GunaButton();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUsuariosTabla = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1.SuspendLayout();
            this.panelCrudUser.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.panelCrudUser);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 265);
            this.panel1.TabIndex = 3;
            // 
            // panelCrudUser
            // 
            this.panelCrudUser.Controls.Add(this.gcmbPuesto);
            this.panelCrudUser.Controls.Add(this.label10);
            this.panelCrudUser.Controls.Add(this.gtbFoto);
            this.panelCrudUser.Controls.Add(this.label9);
            this.panelCrudUser.Controls.Add(this.gtbPassword);
            this.panelCrudUser.Controls.Add(this.label8);
            this.panelCrudUser.Controls.Add(this.gtbCorreo);
            this.panelCrudUser.Controls.Add(this.label7);
            this.panelCrudUser.Controls.Add(this.gcmbArea);
            this.panelCrudUser.Controls.Add(this.label6);
            this.panelCrudUser.Controls.Add(this.gcmbDepartamento);
            this.panelCrudUser.Controls.Add(this.label5);
            this.panelCrudUser.Controls.Add(this.gtbNumeroTrabajador);
            this.panelCrudUser.Controls.Add(this.label4);
            this.panelCrudUser.Controls.Add(this.gtbNombreCompleto);
            this.panelCrudUser.Controls.Add(this.label3);
            this.panelCrudUser.Controls.Add(this.label1);
            this.panelCrudUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCrudUser.Location = new System.Drawing.Point(0, 0);
            this.panelCrudUser.Name = "panelCrudUser";
            this.panelCrudUser.Size = new System.Drawing.Size(666, 265);
            this.panelCrudUser.TabIndex = 20;
            // 
            // gcmbPuesto
            // 
            this.gcmbPuesto.BackColor = System.Drawing.Color.Transparent;
            this.gcmbPuesto.BaseColor = System.Drawing.Color.White;
            this.gcmbPuesto.BorderColor = System.Drawing.Color.Silver;
            this.gcmbPuesto.BorderSize = 0;
            this.gcmbPuesto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcmbPuesto.FocusedColor = System.Drawing.Color.Empty;
            this.gcmbPuesto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.gcmbPuesto.ForeColor = System.Drawing.Color.Black;
            this.gcmbPuesto.FormattingEnabled = true;
            this.gcmbPuesto.Location = new System.Drawing.Point(243, 151);
            this.gcmbPuesto.Name = "gcmbPuesto";
            this.gcmbPuesto.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gcmbPuesto.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcmbPuesto.Radius = 5;
            this.gcmbPuesto.Size = new System.Drawing.Size(195, 27);
            this.gcmbPuesto.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(239, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Puesto:";
            // 
            // gtbFoto
            // 
            this.gtbFoto.BackColor = System.Drawing.Color.Transparent;
            this.gtbFoto.BaseColor = System.Drawing.Color.White;
            this.gtbFoto.BorderColor = System.Drawing.Color.Silver;
            this.gtbFoto.BorderSize = 0;
            this.gtbFoto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbFoto.FocusedBaseColor = System.Drawing.Color.White;
            this.gtbFoto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtbFoto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtbFoto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbFoto.Location = new System.Drawing.Point(243, 223);
            this.gtbFoto.Name = "gtbFoto";
            this.gtbFoto.PasswordChar = '\0';
            this.gtbFoto.Radius = 5;
            this.gtbFoto.SelectedText = "";
            this.gtbFoto.Size = new System.Drawing.Size(195, 30);
            this.gtbFoto.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(239, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Foto del usuario:";
            // 
            // gtbPassword
            // 
            this.gtbPassword.BackColor = System.Drawing.Color.Transparent;
            this.gtbPassword.BaseColor = System.Drawing.Color.White;
            this.gtbPassword.BorderColor = System.Drawing.Color.Silver;
            this.gtbPassword.BorderSize = 0;
            this.gtbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.gtbPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtbPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtbPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbPassword.Location = new System.Drawing.Point(16, 223);
            this.gtbPassword.Name = "gtbPassword";
            this.gtbPassword.PasswordChar = '\0';
            this.gtbPassword.Radius = 5;
            this.gtbPassword.SelectedText = "";
            this.gtbPassword.Size = new System.Drawing.Size(195, 30);
            this.gtbPassword.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Contraseña:";
            // 
            // gtbCorreo
            // 
            this.gtbCorreo.BackColor = System.Drawing.Color.Transparent;
            this.gtbCorreo.BaseColor = System.Drawing.Color.White;
            this.gtbCorreo.BorderColor = System.Drawing.Color.Silver;
            this.gtbCorreo.BorderSize = 0;
            this.gtbCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbCorreo.FocusedBaseColor = System.Drawing.Color.White;
            this.gtbCorreo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtbCorreo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtbCorreo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbCorreo.Location = new System.Drawing.Point(468, 151);
            this.gtbCorreo.Name = "gtbCorreo";
            this.gtbCorreo.PasswordChar = '\0';
            this.gtbCorreo.Radius = 5;
            this.gtbCorreo.SelectedText = "";
            this.gtbCorreo.Size = new System.Drawing.Size(195, 30);
            this.gtbCorreo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(464, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Correo electronico:";
            // 
            // gcmbArea
            // 
            this.gcmbArea.BackColor = System.Drawing.Color.Transparent;
            this.gcmbArea.BaseColor = System.Drawing.Color.White;
            this.gcmbArea.BorderColor = System.Drawing.Color.Silver;
            this.gcmbArea.BorderSize = 0;
            this.gcmbArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcmbArea.FocusedColor = System.Drawing.Color.Empty;
            this.gcmbArea.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.gcmbArea.ForeColor = System.Drawing.Color.Black;
            this.gcmbArea.FormattingEnabled = true;
            this.gcmbArea.Location = new System.Drawing.Point(16, 151);
            this.gcmbArea.Name = "gcmbArea";
            this.gcmbArea.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gcmbArea.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcmbArea.Radius = 5;
            this.gcmbArea.Size = new System.Drawing.Size(195, 27);
            this.gcmbArea.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Area:";
            // 
            // gcmbDepartamento
            // 
            this.gcmbDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.gcmbDepartamento.BaseColor = System.Drawing.Color.White;
            this.gcmbDepartamento.BorderColor = System.Drawing.Color.Silver;
            this.gcmbDepartamento.BorderSize = 0;
            this.gcmbDepartamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcmbDepartamento.FocusedColor = System.Drawing.Color.Empty;
            this.gcmbDepartamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcmbDepartamento.ForeColor = System.Drawing.Color.Black;
            this.gcmbDepartamento.FormattingEnabled = true;
            this.gcmbDepartamento.Location = new System.Drawing.Point(468, 78);
            this.gcmbDepartamento.Name = "gcmbDepartamento";
            this.gcmbDepartamento.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gcmbDepartamento.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcmbDepartamento.Radius = 5;
            this.gcmbDepartamento.Size = new System.Drawing.Size(195, 27);
            this.gcmbDepartamento.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(464, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Departamento:";
            // 
            // gtbNumeroTrabajador
            // 
            this.gtbNumeroTrabajador.BackColor = System.Drawing.Color.Transparent;
            this.gtbNumeroTrabajador.BaseColor = System.Drawing.Color.White;
            this.gtbNumeroTrabajador.BorderColor = System.Drawing.Color.Silver;
            this.gtbNumeroTrabajador.BorderSize = 0;
            this.gtbNumeroTrabajador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbNumeroTrabajador.FocusedBaseColor = System.Drawing.Color.White;
            this.gtbNumeroTrabajador.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtbNumeroTrabajador.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtbNumeroTrabajador.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbNumeroTrabajador.Location = new System.Drawing.Point(16, 74);
            this.gtbNumeroTrabajador.Name = "gtbNumeroTrabajador";
            this.gtbNumeroTrabajador.PasswordChar = '\0';
            this.gtbNumeroTrabajador.Radius = 5;
            this.gtbNumeroTrabajador.SelectedText = "";
            this.gtbNumeroTrabajador.Size = new System.Drawing.Size(195, 30);
            this.gtbNumeroTrabajador.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero trabajador:";
            // 
            // gtbNombreCompleto
            // 
            this.gtbNombreCompleto.BackColor = System.Drawing.Color.Transparent;
            this.gtbNombreCompleto.BaseColor = System.Drawing.Color.White;
            this.gtbNombreCompleto.BorderColor = System.Drawing.Color.Silver;
            this.gtbNombreCompleto.BorderSize = 0;
            this.gtbNombreCompleto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbNombreCompleto.FocusedBaseColor = System.Drawing.Color.White;
            this.gtbNombreCompleto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtbNombreCompleto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtbNombreCompleto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbNombreCompleto.Location = new System.Drawing.Point(243, 74);
            this.gtbNombreCompleto.Name = "gtbNombreCompleto";
            this.gtbNombreCompleto.PasswordChar = '\0';
            this.gtbNombreCompleto.Radius = 5;
            this.gtbNombreCompleto.SelectedText = "";
            this.gtbNombreCompleto.Size = new System.Drawing.Size(195, 30);
            this.gtbNombreCompleto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(239, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre completo:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar Usuarios";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAbriModalEdit);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnNuevo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(672, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 265);
            this.panel3.TabIndex = 19;
            // 
            // btnAbriModalEdit
            // 
            this.btnAbriModalEdit.AnimationHoverSpeed = 0.07F;
            this.btnAbriModalEdit.AnimationSpeed = 0.03F;
            this.btnAbriModalEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnAbriModalEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAbriModalEdit.BorderColor = System.Drawing.Color.Black;
            this.btnAbriModalEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbriModalEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAbriModalEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnAbriModalEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbriModalEdit.ForeColor = System.Drawing.Color.White;
            this.btnAbriModalEdit.Image = null;
            this.btnAbriModalEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAbriModalEdit.Location = new System.Drawing.Point(3, 98);
            this.btnAbriModalEdit.Name = "btnAbriModalEdit";
            this.btnAbriModalEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAbriModalEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAbriModalEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAbriModalEdit.OnHoverImage = null;
            this.btnAbriModalEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnAbriModalEdit.Radius = 10;
            this.btnAbriModalEdit.Size = new System.Drawing.Size(138, 62);
            this.btnAbriModalEdit.TabIndex = 3;
            this.btnAbriModalEdit.Text = "Editar";
            this.btnAbriModalEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAbriModalEdit.Click += new System.EventHandler(this.btnAbriModalEdit_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AnimationHoverSpeed = 0.07F;
            this.btnEliminar.AnimationSpeed = 0.03F;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(3, 191);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Radius = 10;
            this.btnEliminar.Size = new System.Drawing.Size(138, 62);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AnimationHoverSpeed = 0.07F;
            this.btnNuevo.AnimationSpeed = 0.03F;
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNuevo.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevo.FocusedColor = System.Drawing.Color.Empty;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = null;
            this.btnNuevo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNuevo.Location = new System.Drawing.Point(3, 14);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNuevo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNuevo.OnHoverImage = null;
            this.btnNuevo.OnPressedColor = System.Drawing.Color.Black;
            this.btnNuevo.Radius = 10;
            this.btnNuevo.Size = new System.Drawing.Size(138, 62);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 36);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tabla de usuarios";
            // 
            // dgvUsuariosTabla
            // 
            this.dgvUsuariosTabla.AllowUserToAddRows = false;
            this.dgvUsuariosTabla.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvUsuariosTabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuariosTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuariosTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuariosTabla.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuariosTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuariosTabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuariosTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuariosTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsuariosTabla.ColumnHeadersHeight = 50;
            this.dgvUsuariosTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuariosTabla.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUsuariosTabla.EnableHeadersVisualStyles = false;
            this.dgvUsuariosTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsuariosTabla.Location = new System.Drawing.Point(17, 307);
            this.dgvUsuariosTabla.MultiSelect = false;
            this.dgvUsuariosTabla.Name = "dgvUsuariosTabla";
            this.dgvUsuariosTabla.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuariosTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUsuariosTabla.RowHeadersVisible = false;
            this.dgvUsuariosTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuariosTabla.ShowCellErrors = false;
            this.dgvUsuariosTabla.ShowCellToolTips = false;
            this.dgvUsuariosTabla.ShowEditingIcon = false;
            this.dgvUsuariosTabla.ShowRowErrors = false;
            this.dgvUsuariosTabla.Size = new System.Drawing.Size(793, 294);
            this.dgvUsuariosTabla.TabIndex = 5;
            this.dgvUsuariosTabla.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvUsuariosTabla.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsuariosTabla.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUsuariosTabla.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUsuariosTabla.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUsuariosTabla.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUsuariosTabla.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsuariosTabla.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsuariosTabla.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUsuariosTabla.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsuariosTabla.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuariosTabla.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsuariosTabla.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsuariosTabla.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvUsuariosTabla.ThemeStyle.ReadOnly = true;
            this.dgvUsuariosTabla.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsuariosTabla.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuariosTabla.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuariosTabla.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsuariosTabla.ThemeStyle.RowsStyle.Height = 22;
            this.dgvUsuariosTabla.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsuariosTabla.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(825, 613);
            this.Controls.Add(this.dgvUsuariosTabla);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panelCrudUser.ResumeLayout(false);
            this.panelCrudUser.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaButton btnNuevo;
        private Guna.UI.WinForms.GunaDataGridView dgvUsuariosTabla;
        private System.Windows.Forms.Panel panelCrudUser;
        private Guna.UI.WinForms.GunaComboBox gcmbPuesto;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaTextBox gtbFoto;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox gtbPassword;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox gtbCorreo;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaComboBox gcmbArea;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaComboBox gcmbDepartamento;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox gtbNumeroTrabajador;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox gtbNombreCompleto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnAbriModalEdit;
    }
}