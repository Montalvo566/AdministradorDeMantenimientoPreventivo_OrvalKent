
namespace Presentation
{
    partial class TareasAsignadas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelRAHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gdgvTablaActividades = new Guna.UI.WinForms.GunaDataGridView();
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCantidadRegistros = new Guna.UI.WinForms.GunaComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbUsuario = new Guna.UI.WinForms.GunaComboBox();
            this.btnFiltrar = new Guna.UI.WinForms.GunaButton();
            this.btnCancelar = new Guna.UI.WinForms.GunaButton();
            this.panelRAHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdgvTablaActividades)).BeginInit();
            this.panelFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRAHeader
            // 
            this.panelRAHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelRAHeader.Controls.Add(this.label1);
            this.panelRAHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRAHeader.Location = new System.Drawing.Point(0, 0);
            this.panelRAHeader.Name = "panelRAHeader";
            this.panelRAHeader.Size = new System.Drawing.Size(827, 41);
            this.panelRAHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Actividades de usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 595);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 18);
            this.panel1.TabIndex = 2;
            // 
            // gdgvTablaActividades
            // 
            this.gdgvTablaActividades.AllowUserToAddRows = false;
            this.gdgvTablaActividades.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gdgvTablaActividades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gdgvTablaActividades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdgvTablaActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdgvTablaActividades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.gdgvTablaActividades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdgvTablaActividades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgvTablaActividades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdgvTablaActividades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gdgvTablaActividades.ColumnHeadersHeight = 4;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdgvTablaActividades.DefaultCellStyle = dataGridViewCellStyle12;
            this.gdgvTablaActividades.EnableHeadersVisualStyles = false;
            this.gdgvTablaActividades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvTablaActividades.Location = new System.Drawing.Point(12, 114);
            this.gdgvTablaActividades.Name = "gdgvTablaActividades";
            this.gdgvTablaActividades.ReadOnly = true;
            this.gdgvTablaActividades.RowHeadersVisible = false;
            this.gdgvTablaActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdgvTablaActividades.Size = new System.Drawing.Size(803, 475);
            this.gdgvTablaActividades.TabIndex = 3;
            this.gdgvTablaActividades.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gdgvTablaActividades.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgvTablaActividades.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdgvTablaActividades.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdgvTablaActividades.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdgvTablaActividades.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdgvTablaActividades.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.gdgvTablaActividades.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvTablaActividades.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdgvTablaActividades.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdgvTablaActividades.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgvTablaActividades.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdgvTablaActividades.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdgvTablaActividades.ThemeStyle.HeaderStyle.Height = 4;
            this.gdgvTablaActividades.ThemeStyle.ReadOnly = true;
            this.gdgvTablaActividades.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgvTablaActividades.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgvTablaActividades.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgvTablaActividades.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdgvTablaActividades.ThemeStyle.RowsStyle.Height = 22;
            this.gdgvTablaActividades.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvTablaActividades.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panelFiltro
            // 
            this.panelFiltro.Controls.Add(this.btnCancelar);
            this.panelFiltro.Controls.Add(this.label2);
            this.panelFiltro.Controls.Add(this.cmbCantidadRegistros);
            this.panelFiltro.Controls.Add(this.label8);
            this.panelFiltro.Controls.Add(this.btnFiltrar);
            this.panelFiltro.Controls.Add(this.cmbUsuario);
            this.panelFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltro.Location = new System.Drawing.Point(0, 41);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(827, 67);
            this.panelFiltro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(383, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cantidad de registros:";
            // 
            // cmbCantidadRegistros
            // 
            this.cmbCantidadRegistros.BackColor = System.Drawing.Color.Transparent;
            this.cmbCantidadRegistros.BaseColor = System.Drawing.Color.White;
            this.cmbCantidadRegistros.BorderColor = System.Drawing.Color.Silver;
            this.cmbCantidadRegistros.BorderSize = 0;
            this.cmbCantidadRegistros.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCantidadRegistros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidadRegistros.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCantidadRegistros.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbCantidadRegistros.ForeColor = System.Drawing.Color.Black;
            this.cmbCantidadRegistros.FormattingEnabled = true;
            this.cmbCantidadRegistros.Location = new System.Drawing.Point(387, 31);
            this.cmbCantidadRegistros.Name = "cmbCantidadRegistros";
            this.cmbCantidadRegistros.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCantidadRegistros.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCantidadRegistros.Radius = 5;
            this.cmbCantidadRegistros.Size = new System.Drawing.Size(369, 27);
            this.cmbCantidadRegistros.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Usuarios:";
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
            this.cmbUsuario.Location = new System.Drawing.Point(12, 31);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbUsuario.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbUsuario.Radius = 5;
            this.cmbUsuario.Size = new System.Drawing.Size(369, 27);
            this.cmbUsuario.TabIndex = 22;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.AnimationHoverSpeed = 0.07F;
            this.btnFiltrar.AnimationSpeed = 0.03F;
            this.btnFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnFiltrar.BorderColor = System.Drawing.Color.Black;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFiltrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Image = null;
            this.btnFiltrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFiltrar.Location = new System.Drawing.Point(760, 6);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFiltrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFiltrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFiltrar.OnHoverImage = null;
            this.btnFiltrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnFiltrar.Radius = 10;
            this.btnFiltrar.Size = new System.Drawing.Size(64, 25);
            this.btnFiltrar.TabIndex = 28;
            this.btnFiltrar.Text = "Filtrar";
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
            this.btnCancelar.Location = new System.Drawing.Point(762, 39);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnHoverImage = null;
            this.btnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancelar.Radius = 10;
            this.btnCancelar.Size = new System.Drawing.Size(62, 25);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TareasAsignadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(827, 613);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.gdgvTablaActividades);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRAHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TareasAsignadas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TareasAsignadas_Load);
            this.panelRAHeader.ResumeLayout(false);
            this.panelRAHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdgvTablaActividades)).EndInit();
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRAHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView gdgvTablaActividades;
        private System.Windows.Forms.Panel panelFiltro;
        private Guna.UI.WinForms.GunaComboBox cmbUsuario;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaButton btnFiltrar;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox cmbCantidadRegistros;
        private Guna.UI.WinForms.GunaButton btnCancelar;
    }
}