
namespace Presentation
{
    partial class Actividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actividades));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAbriModalEdit = new Guna.UI.WinForms.GunaButton();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaButton();
            this.panelCrudActividad = new System.Windows.Forms.Panel();
            this.dtpFechaAsignacion = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUsuarioAsignado = new Guna.UI.WinForms.GunaComboBox();
            this.cmbUsuarioRegistra = new Guna.UI.WinForms.GunaComboBox();
            this.cmbFrecuencia = new Guna.UI.WinForms.GunaComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEquipo = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbArea = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbActividad = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRegistro = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvActividadesTabla = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelCrudActividad.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividadesTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelCrudActividad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 330);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAbriModalEdit);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnNuevo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(899, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 330);
            this.panel3.TabIndex = 29;
            // 
            // btnAbriModalEdit
            // 
            this.btnAbriModalEdit.AnimationHoverSpeed = 0.07F;
            this.btnAbriModalEdit.AnimationSpeed = 0.03F;
            this.btnAbriModalEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnAbriModalEdit.BaseColor = System.Drawing.Color.Blue;
            this.btnAbriModalEdit.BorderColor = System.Drawing.Color.Black;
            this.btnAbriModalEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbriModalEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAbriModalEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnAbriModalEdit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbriModalEdit.ForeColor = System.Drawing.Color.White;
            this.btnAbriModalEdit.Image = null;
            this.btnAbriModalEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAbriModalEdit.Location = new System.Drawing.Point(4, 124);
            this.btnAbriModalEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbriModalEdit.Name = "btnAbriModalEdit";
            this.btnAbriModalEdit.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnAbriModalEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAbriModalEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAbriModalEdit.OnHoverImage = null;
            this.btnAbriModalEdit.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnAbriModalEdit.Radius = 10;
            this.btnAbriModalEdit.Size = new System.Drawing.Size(184, 76);
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
            this.btnEliminar.BaseColor = System.Drawing.Color.Red;
            this.btnEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(4, 235);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Radius = 10;
            this.btnEliminar.Size = new System.Drawing.Size(184, 76);
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
            this.btnNuevo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNuevo.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevo.FocusedColor = System.Drawing.Color.Empty;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = null;
            this.btnNuevo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNuevo.Location = new System.Drawing.Point(4, 20);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNuevo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNuevo.OnHoverImage = null;
            this.btnNuevo.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Radius = 10;
            this.btnNuevo.Size = new System.Drawing.Size(184, 76);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // panelCrudActividad
            // 
            this.panelCrudActividad.Controls.Add(this.dtpFechaAsignacion);
            this.panelCrudActividad.Controls.Add(this.label1);
            this.panelCrudActividad.Controls.Add(this.cmbUsuarioAsignado);
            this.panelCrudActividad.Controls.Add(this.cmbUsuarioRegistra);
            this.panelCrudActividad.Controls.Add(this.cmbFrecuencia);
            this.panelCrudActividad.Controls.Add(this.label10);
            this.panelCrudActividad.Controls.Add(this.label9);
            this.panelCrudActividad.Controls.Add(this.label8);
            this.panelCrudActividad.Controls.Add(this.label7);
            this.panelCrudActividad.Controls.Add(this.cmbEquipo);
            this.panelCrudActividad.Controls.Add(this.label6);
            this.panelCrudActividad.Controls.Add(this.cmbArea);
            this.panelCrudActividad.Controls.Add(this.label5);
            this.panelCrudActividad.Controls.Add(this.tbActividad);
            this.panelCrudActividad.Controls.Add(this.label4);
            this.panelCrudActividad.Controls.Add(this.tbRegistro);
            this.panelCrudActividad.Controls.Add(this.label3);
            this.panelCrudActividad.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCrudActividad.Location = new System.Drawing.Point(0, 0);
            this.panelCrudActividad.Margin = new System.Windows.Forms.Padding(4);
            this.panelCrudActividad.Name = "panelCrudActividad";
            this.panelCrudActividad.Size = new System.Drawing.Size(888, 330);
            this.panelCrudActividad.TabIndex = 28;
            // 
            // dtpFechaAsignacion
            // 
            this.dtpFechaAsignacion.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaAsignacion.BaseColor = System.Drawing.Color.White;
            this.dtpFechaAsignacion.BorderColor = System.Drawing.Color.Black;
            this.dtpFechaAsignacion.BorderSize = 0;
            this.dtpFechaAsignacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaAsignacion.CustomFormat = null;
            this.dtpFechaAsignacion.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaAsignacion.FocusedColor = System.Drawing.Color.White;
            this.dtpFechaAsignacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAsignacion.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaAsignacion.Location = new System.Drawing.Point(324, 274);
            this.dtpFechaAsignacion.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaAsignacion.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaAsignacion.Name = "dtpFechaAsignacion";
            this.dtpFechaAsignacion.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFechaAsignacion.OnHoverBorderColor = System.Drawing.Color.Blue;
            this.dtpFechaAsignacion.OnHoverForeColor = System.Drawing.Color.Blue;
            this.dtpFechaAsignacion.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFechaAsignacion.Radius = 5;
            this.dtpFechaAsignacion.Size = new System.Drawing.Size(559, 31);
            this.dtpFechaAsignacion.TabIndex = 22;
            this.dtpFechaAsignacion.Text = "jueves, 29 de febrero de 2024";
            this.dtpFechaAsignacion.Value = new System.DateTime(2024, 2, 29, 23, 37, 17, 999);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar Actividad";
            // 
            // cmbUsuarioAsignado
            // 
            this.cmbUsuarioAsignado.BackColor = System.Drawing.Color.Transparent;
            this.cmbUsuarioAsignado.BaseColor = System.Drawing.Color.White;
            this.cmbUsuarioAsignado.BorderColor = System.Drawing.Color.Silver;
            this.cmbUsuarioAsignado.BorderSize = 0;
            this.cmbUsuarioAsignado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUsuarioAsignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioAsignado.FocusedColor = System.Drawing.Color.Empty;
            this.cmbUsuarioAsignado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbUsuarioAsignado.ForeColor = System.Drawing.Color.Black;
            this.cmbUsuarioAsignado.FormattingEnabled = true;
            this.cmbUsuarioAsignado.Location = new System.Drawing.Point(21, 274);
            this.cmbUsuarioAsignado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUsuarioAsignado.Name = "cmbUsuarioAsignado";
            this.cmbUsuarioAsignado.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbUsuarioAsignado.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbUsuarioAsignado.Radius = 5;
            this.cmbUsuarioAsignado.Size = new System.Drawing.Size(259, 31);
            this.cmbUsuarioAsignado.TabIndex = 21;
            // 
            // cmbUsuarioRegistra
            // 
            this.cmbUsuarioRegistra.BackColor = System.Drawing.Color.Transparent;
            this.cmbUsuarioRegistra.BaseColor = System.Drawing.Color.White;
            this.cmbUsuarioRegistra.BorderColor = System.Drawing.Color.Silver;
            this.cmbUsuarioRegistra.BorderSize = 0;
            this.cmbUsuarioRegistra.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUsuarioRegistra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioRegistra.FocusedColor = System.Drawing.Color.Empty;
            this.cmbUsuarioRegistra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbUsuarioRegistra.ForeColor = System.Drawing.Color.Black;
            this.cmbUsuarioRegistra.FormattingEnabled = true;
            this.cmbUsuarioRegistra.Location = new System.Drawing.Point(624, 186);
            this.cmbUsuarioRegistra.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUsuarioRegistra.Name = "cmbUsuarioRegistra";
            this.cmbUsuarioRegistra.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbUsuarioRegistra.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbUsuarioRegistra.Radius = 5;
            this.cmbUsuarioRegistra.Size = new System.Drawing.Size(259, 31);
            this.cmbUsuarioRegistra.TabIndex = 20;
            // 
            // cmbFrecuencia
            // 
            this.cmbFrecuencia.BackColor = System.Drawing.Color.Transparent;
            this.cmbFrecuencia.BaseColor = System.Drawing.Color.White;
            this.cmbFrecuencia.BorderColor = System.Drawing.Color.Silver;
            this.cmbFrecuencia.BorderSize = 0;
            this.cmbFrecuencia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFrecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrecuencia.FocusedColor = System.Drawing.Color.Empty;
            this.cmbFrecuencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbFrecuencia.ForeColor = System.Drawing.Color.Black;
            this.cmbFrecuencia.FormattingEnabled = true;
            this.cmbFrecuencia.Location = new System.Drawing.Point(324, 186);
            this.cmbFrecuencia.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFrecuencia.Name = "cmbFrecuencia";
            this.cmbFrecuencia.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbFrecuencia.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbFrecuencia.Radius = 5;
            this.cmbFrecuencia.Size = new System.Drawing.Size(259, 31);
            this.cmbFrecuencia.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(320, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "Frecuencia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(320, 246);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha de asignación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Usuario Asignado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(620, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Usuario Registra:";
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.BackColor = System.Drawing.Color.Transparent;
            this.cmbEquipo.BaseColor = System.Drawing.Color.White;
            this.cmbEquipo.BorderColor = System.Drawing.Color.Silver;
            this.cmbEquipo.BorderSize = 0;
            this.cmbEquipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipo.FocusedColor = System.Drawing.Color.Empty;
            this.cmbEquipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbEquipo.ForeColor = System.Drawing.Color.Black;
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(21, 186);
            this.cmbEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbEquipo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbEquipo.Radius = 5;
            this.cmbEquipo.Size = new System.Drawing.Size(259, 31);
            this.cmbEquipo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Equipo:";
            // 
            // cmbArea
            // 
            this.cmbArea.BackColor = System.Drawing.Color.Transparent;
            this.cmbArea.BaseColor = System.Drawing.Color.White;
            this.cmbArea.BorderColor = System.Drawing.Color.Silver;
            this.cmbArea.BorderSize = 0;
            this.cmbArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FocusedColor = System.Drawing.Color.Empty;
            this.cmbArea.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArea.ForeColor = System.Drawing.Color.Black;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(624, 96);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(4);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbArea.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbArea.Radius = 5;
            this.cmbArea.Size = new System.Drawing.Size(259, 31);
            this.cmbArea.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(620, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Area:";
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
            this.tbActividad.Location = new System.Drawing.Point(21, 91);
            this.tbActividad.Margin = new System.Windows.Forms.Padding(4);
            this.tbActividad.Name = "tbActividad";
            this.tbActividad.PasswordChar = '\0';
            this.tbActividad.Radius = 5;
            this.tbActividad.SelectedText = "";
            this.tbActividad.Size = new System.Drawing.Size(260, 41);
            this.tbActividad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Actividad:";
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
            this.tbRegistro.Location = new System.Drawing.Point(324, 91);
            this.tbRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.tbRegistro.Name = "tbRegistro";
            this.tbRegistro.PasswordChar = '\0';
            this.tbRegistro.Radius = 5;
            this.tbRegistro.SelectedText = "";
            this.tbRegistro.Size = new System.Drawing.Size(260, 41);
            this.tbRegistro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(320, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Registro:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 330);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 44);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tabla de actividades";
            // 
            // dgvActividadesTabla
            // 
            this.dgvActividadesTabla.AllowUserToAddRows = false;
            this.dgvActividadesTabla.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvActividadesTabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActividadesTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActividadesTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActividadesTabla.BackgroundColor = System.Drawing.Color.White;
            this.dgvActividadesTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActividadesTabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvActividadesTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActividadesTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActividadesTabla.ColumnHeadersHeight = 50;
            this.dgvActividadesTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActividadesTabla.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActividadesTabla.EnableHeadersVisualStyles = false;
            this.dgvActividadesTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvActividadesTabla.Location = new System.Drawing.Point(23, 382);
            this.dgvActividadesTabla.Margin = new System.Windows.Forms.Padding(4);
            this.dgvActividadesTabla.MultiSelect = false;
            this.dgvActividadesTabla.Name = "dgvActividadesTabla";
            this.dgvActividadesTabla.ReadOnly = true;
            this.dgvActividadesTabla.RowHeadersVisible = false;
            this.dgvActividadesTabla.RowHeadersWidth = 51;
            this.dgvActividadesTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActividadesTabla.ShowCellErrors = false;
            this.dgvActividadesTabla.ShowCellToolTips = false;
            this.dgvActividadesTabla.ShowEditingIcon = false;
            this.dgvActividadesTabla.ShowRowErrors = false;
            this.dgvActividadesTabla.Size = new System.Drawing.Size(1064, 358);
            this.dgvActividadesTabla.TabIndex = 6;
            this.dgvActividadesTabla.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvActividadesTabla.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActividadesTabla.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvActividadesTabla.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvActividadesTabla.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvActividadesTabla.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvActividadesTabla.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvActividadesTabla.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvActividadesTabla.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvActividadesTabla.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvActividadesTabla.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvActividadesTabla.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvActividadesTabla.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvActividadesTabla.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvActividadesTabla.ThemeStyle.ReadOnly = true;
            this.dgvActividadesTabla.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActividadesTabla.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvActividadesTabla.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvActividadesTabla.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvActividadesTabla.ThemeStyle.RowsStyle.Height = 22;
            this.dgvActividadesTabla.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvActividadesTabla.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1103, 754);
            this.Controls.Add(this.dgvActividadesTabla);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Actividades";
            this.Text = "Actividades";
            this.Load += new System.EventHandler(this.Actividades_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelCrudActividad.ResumeLayout(false);
            this.panelCrudActividad.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividadesTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDataGridView dgvActividadesTabla;
        private System.Windows.Forms.Panel panelCrudActividad;
        private Guna.UI.WinForms.GunaComboBox cmbFrecuencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaComboBox cmbEquipo;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaComboBox cmbArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox tbRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaButton btnAbriModalEdit;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaButton btnNuevo;
        private Guna.UI.WinForms.GunaTextBox tbActividad;
        private Guna.UI.WinForms.GunaComboBox cmbUsuarioAsignado;
        private Guna.UI.WinForms.GunaComboBox cmbUsuarioRegistra;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFechaAsignacion;
    }
}