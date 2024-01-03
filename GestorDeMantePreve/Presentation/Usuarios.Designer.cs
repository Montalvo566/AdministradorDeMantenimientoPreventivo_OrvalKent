
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbtnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.gbtnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.gbtnGuardarCambios = new Guna.UI2.WinForms.Guna2Button();
            this.gbtnNuevo = new Guna.UI2.WinForms.Guna2Button();
            this.tbCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbApMaterno = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbApPaterno = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNombres = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gdgvUsuariosTabla = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdgvUsuariosTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tbCorreo);
            this.panel1.Controls.Add(this.tbPass);
            this.panel1.Controls.Add(this.tbApMaterno);
            this.panel1.Controls.Add(this.tbApPaterno);
            this.panel1.Controls.Add(this.tbNombres);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 284);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbtnEditar);
            this.panel3.Controls.Add(this.gbtnEliminar);
            this.panel3.Controls.Add(this.gbtnGuardarCambios);
            this.panel3.Controls.Add(this.gbtnNuevo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(643, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 284);
            this.panel3.TabIndex = 19;
            // 
            // gbtnEditar
            // 
            this.gbtnEditar.BorderRadius = 5;
            this.gbtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnEditar.FillColor = System.Drawing.Color.Lime;
            this.gbtnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.gbtnEditar.ForeColor = System.Drawing.Color.White;
            this.gbtnEditar.Location = new System.Drawing.Point(6, 150);
            this.gbtnEditar.Name = "gbtnEditar";
            this.gbtnEditar.Size = new System.Drawing.Size(173, 57);
            this.gbtnEditar.TabIndex = 23;
            this.gbtnEditar.Text = "Editar usuario";
            this.gbtnEditar.Click += new System.EventHandler(this.gbtnEditar_Click);
            // 
            // gbtnEliminar
            // 
            this.gbtnEliminar.BorderRadius = 5;
            this.gbtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnEliminar.FillColor = System.Drawing.Color.Red;
            this.gbtnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.gbtnEliminar.ForeColor = System.Drawing.Color.White;
            this.gbtnEliminar.Location = new System.Drawing.Point(6, 221);
            this.gbtnEliminar.Name = "gbtnEliminar";
            this.gbtnEliminar.Size = new System.Drawing.Size(173, 57);
            this.gbtnEliminar.TabIndex = 22;
            this.gbtnEliminar.Text = "Eliminar usuario";
            // 
            // gbtnGuardarCambios
            // 
            this.gbtnGuardarCambios.BorderRadius = 5;
            this.gbtnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnGuardarCambios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnGuardarCambios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnGuardarCambios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnGuardarCambios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnGuardarCambios.FillColor = System.Drawing.Color.White;
            this.gbtnGuardarCambios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.gbtnGuardarCambios.ForeColor = System.Drawing.Color.Black;
            this.gbtnGuardarCambios.Location = new System.Drawing.Point(6, 78);
            this.gbtnGuardarCambios.Name = "gbtnGuardarCambios";
            this.gbtnGuardarCambios.Size = new System.Drawing.Size(173, 57);
            this.gbtnGuardarCambios.TabIndex = 21;
            this.gbtnGuardarCambios.Text = "Guardar";
            // 
            // gbtnNuevo
            // 
            this.gbtnNuevo.BorderRadius = 5;
            this.gbtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnNuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnNuevo.ForeColor = System.Drawing.Color.White;
            this.gbtnNuevo.Location = new System.Drawing.Point(6, 9);
            this.gbtnNuevo.Name = "gbtnNuevo";
            this.gbtnNuevo.Size = new System.Drawing.Size(173, 57);
            this.gbtnNuevo.TabIndex = 20;
            this.gbtnNuevo.Text = "Nuevo usuario";
            this.gbtnNuevo.Click += new System.EventHandler(this.gbtnNuevo_Click);
            // 
            // tbCorreo
            // 
            this.tbCorreo.BorderRadius = 7;
            this.tbCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCorreo.DefaultText = "";
            this.tbCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCorreo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCorreo.Location = new System.Drawing.Point(338, 150);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.PasswordChar = '\0';
            this.tbCorreo.PlaceholderText = "Correo electronico";
            this.tbCorreo.SelectedText = "";
            this.tbCorreo.Size = new System.Drawing.Size(299, 29);
            this.tbCorreo.TabIndex = 17;
            // 
            // tbPass
            // 
            this.tbPass.BorderRadius = 7;
            this.tbPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPass.DefaultText = "";
            this.tbPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPass.Location = new System.Drawing.Point(17, 222);
            this.tbPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '\0';
            this.tbPass.PlaceholderText = "Contraseña";
            this.tbPass.SelectedText = "";
            this.tbPass.Size = new System.Drawing.Size(299, 29);
            this.tbPass.TabIndex = 18;
            // 
            // tbApMaterno
            // 
            this.tbApMaterno.BorderRadius = 7;
            this.tbApMaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbApMaterno.DefaultText = "";
            this.tbApMaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbApMaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbApMaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbApMaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbApMaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbApMaterno.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApMaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbApMaterno.Location = new System.Drawing.Point(17, 150);
            this.tbApMaterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbApMaterno.Name = "tbApMaterno";
            this.tbApMaterno.PasswordChar = '\0';
            this.tbApMaterno.PlaceholderText = "Apellido materno";
            this.tbApMaterno.SelectedText = "";
            this.tbApMaterno.Size = new System.Drawing.Size(299, 29);
            this.tbApMaterno.TabIndex = 16;
            // 
            // tbApPaterno
            // 
            this.tbApPaterno.BorderRadius = 7;
            this.tbApPaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbApPaterno.DefaultText = "";
            this.tbApPaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbApPaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbApPaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbApPaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbApPaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbApPaterno.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApPaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbApPaterno.Location = new System.Drawing.Point(338, 77);
            this.tbApPaterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbApPaterno.Name = "tbApPaterno";
            this.tbApPaterno.PasswordChar = '\0';
            this.tbApPaterno.PlaceholderText = "Apellido paterno";
            this.tbApPaterno.SelectedText = "";
            this.tbApPaterno.Size = new System.Drawing.Size(299, 29);
            this.tbApPaterno.TabIndex = 15;
            // 
            // tbNombres
            // 
            this.tbNombres.BorderRadius = 7;
            this.tbNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNombres.DefaultText = "";
            this.tbNombres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNombres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNombres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNombres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNombres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNombres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombres.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNombres.Location = new System.Drawing.Point(17, 77);
            this.tbNombres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.PasswordChar = '\0';
            this.tbNombres.PlaceholderText = "Nombre completo";
            this.tbNombres.SelectedText = "";
            this.tbNombres.Size = new System.Drawing.Size(299, 29);
            this.tbNombres.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(335, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Apellido materno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(335, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar Usuarios";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 40);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tabla de usuarios";
            // 
            // gdgvUsuariosTabla
            // 
            this.gdgvUsuariosTabla.AllowUserToAddRows = false;
            this.gdgvUsuariosTabla.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gdgvUsuariosTabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdgvUsuariosTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdgvUsuariosTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdgvUsuariosTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdgvUsuariosTabla.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdgvUsuariosTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvUsuariosTabla.Location = new System.Drawing.Point(12, 330);
            this.gdgvUsuariosTabla.Name = "gdgvUsuariosTabla";
            this.gdgvUsuariosTabla.ReadOnly = true;
            this.gdgvUsuariosTabla.RowHeadersVisible = false;
            this.gdgvUsuariosTabla.Size = new System.Drawing.Size(801, 271);
            this.gdgvUsuariosTabla.TabIndex = 5;
            this.gdgvUsuariosTabla.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgvUsuariosTabla.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdgvUsuariosTabla.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdgvUsuariosTabla.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdgvUsuariosTabla.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdgvUsuariosTabla.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdgvUsuariosTabla.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvUsuariosTabla.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdgvUsuariosTabla.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdgvUsuariosTabla.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdgvUsuariosTabla.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdgvUsuariosTabla.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdgvUsuariosTabla.ThemeStyle.HeaderStyle.Height = 4;
            this.gdgvUsuariosTabla.ThemeStyle.ReadOnly = true;
            this.gdgvUsuariosTabla.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgvUsuariosTabla.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgvUsuariosTabla.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdgvUsuariosTabla.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdgvUsuariosTabla.ThemeStyle.RowsStyle.Height = 22;
            this.gdgvUsuariosTabla.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvUsuariosTabla.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(825, 613);
            this.Controls.Add(this.gdgvUsuariosTabla);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdgvUsuariosTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox tbNombres;
        private Guna.UI2.WinForms.Guna2TextBox tbApPaterno;
        private Guna.UI2.WinForms.Guna2TextBox tbPass;
        private Guna.UI2.WinForms.Guna2TextBox tbCorreo;
        private Guna.UI2.WinForms.Guna2TextBox tbApMaterno;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button gbtnNuevo;
        private Guna.UI2.WinForms.Guna2Button gbtnEditar;
        private Guna.UI2.WinForms.Guna2Button gbtnEliminar;
        private Guna.UI2.WinForms.Guna2Button gbtnGuardarCambios;
        private Guna.UI2.WinForms.Guna2DataGridView gdgvUsuariosTabla;
    }
}