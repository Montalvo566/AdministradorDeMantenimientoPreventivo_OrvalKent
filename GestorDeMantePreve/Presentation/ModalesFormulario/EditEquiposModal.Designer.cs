
namespace Presentation.ModalesFormulario
{
    partial class EditEquiposModal
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
            this.panelCrudUser = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gtbNumeroEquipo = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcmbArea = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gtbEquipo = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancelar = new Guna.UI.WinForms.GunaButton();
            this.gbtnEditar = new Guna.UI.WinForms.GunaButton();
            this.panelCrudUser.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCrudUser
            // 
            this.panelCrudUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelCrudUser.Controls.Add(this.label3);
            this.panelCrudUser.Controls.Add(this.gtbNumeroEquipo);
            this.panelCrudUser.Controls.Add(this.label2);
            this.panelCrudUser.Controls.Add(this.label1);
            this.panelCrudUser.Controls.Add(this.gcmbArea);
            this.panelCrudUser.Controls.Add(this.label5);
            this.panelCrudUser.Controls.Add(this.gtbEquipo);
            this.panelCrudUser.Controls.Add(this.label4);
            this.panelCrudUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCrudUser.Location = new System.Drawing.Point(0, 0);
            this.panelCrudUser.Name = "panelCrudUser";
            this.panelCrudUser.Size = new System.Drawing.Size(554, 249);
            this.panelCrudUser.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Numero del equipo:";
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
            this.gtbNumeroEquipo.Location = new System.Drawing.Point(16, 142);
            this.gtbNumeroEquipo.Name = "gtbNumeroEquipo";
            this.gtbNumeroEquipo.PasswordChar = '\0';
            this.gtbNumeroEquipo.Radius = 5;
            this.gtbNumeroEquipo.SelectedText = "";
            this.gtbNumeroEquipo.Size = new System.Drawing.Size(523, 30);
            this.gtbNumeroEquipo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Editar Equipos";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, -316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "EditarUsuarios";
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
            this.gcmbArea.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcmbArea.ForeColor = System.Drawing.Color.Black;
            this.gcmbArea.FormattingEnabled = true;
            this.gcmbArea.Location = new System.Drawing.Point(16, 211);
            this.gcmbArea.Name = "gcmbArea";
            this.gcmbArea.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gcmbArea.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcmbArea.Radius = 5;
            this.gcmbArea.Size = new System.Drawing.Size(523, 27);
            this.gcmbArea.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Area:";
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
            this.gtbEquipo.Location = new System.Drawing.Point(16, 68);
            this.gtbEquipo.Name = "gtbEquipo";
            this.gtbEquipo.PasswordChar = '\0';
            this.gtbEquipo.Radius = 5;
            this.gtbEquipo.SelectedText = "";
            this.gtbEquipo.Size = new System.Drawing.Size(523, 30);
            this.gtbEquipo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Equipo:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.gbtnEditar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 249);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 97);
            this.panel3.TabIndex = 25;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AnimationHoverSpeed = 0.07F;
            this.btnCancelar.AnimationSpeed = 0.03F;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BaseColor = System.Drawing.Color.Red;
            this.btnCancelar.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancelar.Location = new System.Drawing.Point(294, 24);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnHoverImage = null;
            this.btnCancelar.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Radius = 10;
            this.btnCancelar.Size = new System.Drawing.Size(245, 62);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbtnEditar
            // 
            this.gbtnEditar.AnimationHoverSpeed = 0.07F;
            this.gbtnEditar.AnimationSpeed = 0.03F;
            this.gbtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.gbtnEditar.BaseColor = System.Drawing.Color.Blue;
            this.gbtnEditar.BorderColor = System.Drawing.Color.Black;
            this.gbtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnEditar.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnEditar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnEditar.ForeColor = System.Drawing.Color.White;
            this.gbtnEditar.Image = null;
            this.gbtnEditar.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtnEditar.Location = new System.Drawing.Point(16, 24);
            this.gbtnEditar.Name = "gbtnEditar";
            this.gbtnEditar.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.gbtnEditar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnEditar.OnHoverImage = null;
            this.gbtnEditar.OnPressedColor = System.Drawing.Color.Transparent;
            this.gbtnEditar.Radius = 10;
            this.gbtnEditar.Size = new System.Drawing.Size(245, 62);
            this.gbtnEditar.TabIndex = 2;
            this.gbtnEditar.Text = "Editar";
            this.gbtnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnEditar.Click += new System.EventHandler(this.gbtnEditar_Click);
            // 
            // EditEquiposModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(554, 356);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelCrudUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEquiposModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEquiposModal";
            this.Load += new System.EventHandler(this.EditEquiposModal_Load);
            this.panelCrudUser.ResumeLayout(false);
            this.panelCrudUser.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCrudUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaComboBox gcmbArea;
        private System.Windows.Forms.Label label5;
        public Guna.UI.WinForms.GunaTextBox gtbEquipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaButton btnCancelar;
        private Guna.UI.WinForms.GunaButton gbtnEditar;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaTextBox gtbNumeroEquipo;
    }
}