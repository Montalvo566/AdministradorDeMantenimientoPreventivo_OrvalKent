
namespace Presentation
{
    partial class Equipos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCrudUser = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gtbNumeroEquipo = new Guna.UI.WinForms.GunaTextBox();
            this.gcmbArea = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gtbEquipo = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAbriModalEdit = new Guna.UI.WinForms.GunaButton();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEquiposTabla = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1.SuspendLayout();
            this.panelCrudUser.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposTabla)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(825, 229);
            this.panel1.TabIndex = 5;
            // 
            // panelCrudUser
            // 
            this.panelCrudUser.Controls.Add(this.label3);
            this.panelCrudUser.Controls.Add(this.gtbNumeroEquipo);
            this.panelCrudUser.Controls.Add(this.gcmbArea);
            this.panelCrudUser.Controls.Add(this.label6);
            this.panelCrudUser.Controls.Add(this.gtbEquipo);
            this.panelCrudUser.Controls.Add(this.label4);
            this.panelCrudUser.Controls.Add(this.label1);
            this.panelCrudUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCrudUser.Location = new System.Drawing.Point(0, 0);
            this.panelCrudUser.Name = "panelCrudUser";
            this.panelCrudUser.Size = new System.Drawing.Size(666, 229);
            this.panelCrudUser.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(361, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Numero de equipo:";
            // 
            // gtbNumeroEquipo
            // 
            this.gtbNumeroEquipo.BackColor = System.Drawing.Color.Transparent;
            this.gtbNumeroEquipo.BaseColor = System.Drawing.Color.White;
            this.gtbNumeroEquipo.BorderColor = System.Drawing.Color.Silver;
            this.gtbNumeroEquipo.BorderSize = 0;
            this.gtbNumeroEquipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbNumeroEquipo.FocusedBaseColor = System.Drawing.Color.White;
            this.gtbNumeroEquipo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtbNumeroEquipo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtbNumeroEquipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbNumeroEquipo.Location = new System.Drawing.Point(354, 88);
            this.gtbNumeroEquipo.Name = "gtbNumeroEquipo";
            this.gtbNumeroEquipo.PasswordChar = '\0';
            this.gtbNumeroEquipo.Radius = 5;
            this.gtbNumeroEquipo.SelectedText = "";
            this.gtbNumeroEquipo.Size = new System.Drawing.Size(309, 30);
            this.gtbNumeroEquipo.TabIndex = 12;
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
            this.gcmbArea.Location = new System.Drawing.Point(17, 168);
            this.gcmbArea.Name = "gcmbArea";
            this.gcmbArea.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gcmbArea.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcmbArea.Radius = 5;
            this.gcmbArea.Size = new System.Drawing.Size(309, 27);
            this.gcmbArea.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Area:";
            // 
            // gtbEquipo
            // 
            this.gtbEquipo.BackColor = System.Drawing.Color.Transparent;
            this.gtbEquipo.BaseColor = System.Drawing.Color.White;
            this.gtbEquipo.BorderColor = System.Drawing.Color.Silver;
            this.gtbEquipo.BorderSize = 0;
            this.gtbEquipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbEquipo.FocusedBaseColor = System.Drawing.Color.White;
            this.gtbEquipo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtbEquipo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtbEquipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbEquipo.Location = new System.Drawing.Point(17, 88);
            this.gtbEquipo.Name = "gtbEquipo";
            this.gtbEquipo.PasswordChar = '\0';
            this.gtbEquipo.Radius = 5;
            this.gtbEquipo.SelectedText = "";
            this.gtbEquipo.Size = new System.Drawing.Size(309, 30);
            this.gtbEquipo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Equipo:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar Equipos";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAbriModalEdit);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnNuevo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(672, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 229);
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
            this.btnAbriModalEdit.Location = new System.Drawing.Point(3, 85);
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
            this.btnEliminar.Location = new System.Drawing.Point(3, 159);
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
            this.panel2.Location = new System.Drawing.Point(0, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 36);
            this.panel2.TabIndex = 6;
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
            this.label2.Text = "Tabla de equipos";
            // 
            // dgvEquiposTabla
            // 
            this.dgvEquiposTabla.AllowUserToAddRows = false;
            this.dgvEquiposTabla.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEquiposTabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEquiposTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquiposTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquiposTabla.BackgroundColor = System.Drawing.Color.White;
            this.dgvEquiposTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquiposTabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEquiposTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquiposTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEquiposTabla.ColumnHeadersHeight = 50;
            this.dgvEquiposTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquiposTabla.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEquiposTabla.EnableHeadersVisualStyles = false;
            this.dgvEquiposTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEquiposTabla.Location = new System.Drawing.Point(16, 271);
            this.dgvEquiposTabla.MultiSelect = false;
            this.dgvEquiposTabla.Name = "dgvEquiposTabla";
            this.dgvEquiposTabla.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquiposTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEquiposTabla.RowHeadersVisible = false;
            this.dgvEquiposTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquiposTabla.ShowCellErrors = false;
            this.dgvEquiposTabla.ShowCellToolTips = false;
            this.dgvEquiposTabla.ShowEditingIcon = false;
            this.dgvEquiposTabla.ShowRowErrors = false;
            this.dgvEquiposTabla.Size = new System.Drawing.Size(793, 330);
            this.dgvEquiposTabla.TabIndex = 7;
            this.dgvEquiposTabla.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvEquiposTabla.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEquiposTabla.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEquiposTabla.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEquiposTabla.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEquiposTabla.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEquiposTabla.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEquiposTabla.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEquiposTabla.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEquiposTabla.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEquiposTabla.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEquiposTabla.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEquiposTabla.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEquiposTabla.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvEquiposTabla.ThemeStyle.ReadOnly = true;
            this.dgvEquiposTabla.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEquiposTabla.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEquiposTabla.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEquiposTabla.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEquiposTabla.ThemeStyle.RowsStyle.Height = 22;
            this.dgvEquiposTabla.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEquiposTabla.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(825, 613);
            this.Controls.Add(this.dgvEquiposTabla);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Equipos";
            this.Text = "Equipos";
            this.Load += new System.EventHandler(this.Equipos_Load);
            this.panel1.ResumeLayout(false);
            this.panelCrudUser.ResumeLayout(false);
            this.panelCrudUser.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCrudUser;
        private Guna.UI.WinForms.GunaComboBox gcmbArea;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox gtbEquipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaButton btnAbriModalEdit;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaButton btnNuevo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDataGridView dgvEquiposTabla;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox gtbNumeroEquipo;
    }
}