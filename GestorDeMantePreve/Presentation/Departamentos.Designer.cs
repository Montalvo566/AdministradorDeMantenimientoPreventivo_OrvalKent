
namespace Presentation
{
    partial class Departamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departamentos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAbriModalEdit = new Guna.UI.WinForms.GunaButton();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaButton();
            this.panelCrudUser = new System.Windows.Forms.Panel();
            this.gtbDepartamento = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDepartamentosTabla = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelCrudUser.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentosTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelCrudUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 282);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAbriModalEdit);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnNuevo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(899, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 282);
            this.panel3.TabIndex = 19;
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
            this.btnAbriModalEdit.Location = new System.Drawing.Point(4, 105);
            this.btnAbriModalEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnEliminar.Location = new System.Drawing.Point(4, 196);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnNuevo.Location = new System.Drawing.Point(4, 17);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panelCrudUser
            // 
            this.panelCrudUser.Controls.Add(this.gtbDepartamento);
            this.panelCrudUser.Controls.Add(this.label4);
            this.panelCrudUser.Controls.Add(this.label1);
            this.panelCrudUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCrudUser.Location = new System.Drawing.Point(0, 0);
            this.panelCrudUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCrudUser.Name = "panelCrudUser";
            this.panelCrudUser.Size = new System.Drawing.Size(888, 282);
            this.panelCrudUser.TabIndex = 20;
            // 
            // gtbDepartamento
            // 
            this.gtbDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.gtbDepartamento.BaseColor = System.Drawing.Color.White;
            this.gtbDepartamento.BorderColor = System.Drawing.Color.Silver;
            this.gtbDepartamento.BorderSize = 0;
            this.gtbDepartamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbDepartamento.FocusedBaseColor = System.Drawing.Color.White;
            this.gtbDepartamento.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtbDepartamento.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtbDepartamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbDepartamento.Location = new System.Drawing.Point(23, 108);
            this.gtbDepartamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtbDepartamento.Name = "gtbDepartamento";
            this.gtbDepartamento.PasswordChar = '\0';
            this.gtbDepartamento.Radius = 5;
            this.gtbDepartamento.SelectedText = "";
            this.gtbDepartamento.Size = new System.Drawing.Size(847, 41);
            this.gtbDepartamento.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Departamento:";
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
            this.label1.Size = new System.Drawing.Size(296, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar Departamentos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 282);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label2.Location = new System.Drawing.Point(17, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tabla de departamentos";
            // 
            // dgvDepartamentosTabla
            // 
            this.dgvDepartamentosTabla.AllowUserToAddRows = false;
            this.dgvDepartamentosTabla.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDepartamentosTabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepartamentosTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartamentosTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartamentosTabla.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartamentosTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDepartamentosTabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDepartamentosTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartamentosTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDepartamentosTabla.ColumnHeadersHeight = 50;
            this.dgvDepartamentosTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartamentosTabla.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepartamentosTabla.EnableHeadersVisualStyles = false;
            this.dgvDepartamentosTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepartamentosTabla.Location = new System.Drawing.Point(21, 334);
            this.dgvDepartamentosTabla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDepartamentosTabla.MultiSelect = false;
            this.dgvDepartamentosTabla.Name = "dgvDepartamentosTabla";
            this.dgvDepartamentosTabla.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartamentosTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDepartamentosTabla.RowHeadersVisible = false;
            this.dgvDepartamentosTabla.RowHeadersWidth = 51;
            this.dgvDepartamentosTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartamentosTabla.ShowCellErrors = false;
            this.dgvDepartamentosTabla.ShowCellToolTips = false;
            this.dgvDepartamentosTabla.ShowEditingIcon = false;
            this.dgvDepartamentosTabla.ShowRowErrors = false;
            this.dgvDepartamentosTabla.Size = new System.Drawing.Size(1060, 406);
            this.dgvDepartamentosTabla.TabIndex = 6;
            this.dgvDepartamentosTabla.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvDepartamentosTabla.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepartamentosTabla.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDepartamentosTabla.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDepartamentosTabla.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDepartamentosTabla.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDepartamentosTabla.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepartamentosTabla.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepartamentosTabla.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDepartamentosTabla.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDepartamentosTabla.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDepartamentosTabla.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDepartamentosTabla.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDepartamentosTabla.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvDepartamentosTabla.ThemeStyle.ReadOnly = true;
            this.dgvDepartamentosTabla.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepartamentosTabla.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDepartamentosTabla.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDepartamentosTabla.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDepartamentosTabla.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDepartamentosTabla.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepartamentosTabla.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1103, 754);
            this.Controls.Add(this.dgvDepartamentosTabla);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Departamentos";
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.Departamentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelCrudUser.ResumeLayout(false);
            this.panelCrudUser.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentosTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCrudUser;
        private Guna.UI.WinForms.GunaTextBox gtbDepartamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaButton btnAbriModalEdit;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaButton btnNuevo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDataGridView dgvDepartamentosTabla;
    }
}