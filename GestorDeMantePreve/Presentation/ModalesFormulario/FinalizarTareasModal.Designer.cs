
namespace Presentation.ModalesFormulario
{
    partial class FinalizarTareasModal
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
            FontAwesome.Sharp.IconButton btnCerrarModal;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalizarTareasModal));
            this.panelRAHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCodigoSupervisor = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            btnCerrarModal = new FontAwesome.Sharp.IconButton();
            this.panelRAHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarModal
            // 
            btnCerrarModal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            btnCerrarModal.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCerrarModal.Dock = System.Windows.Forms.DockStyle.Right;
            btnCerrarModal.FlatAppearance.BorderSize = 0;
            btnCerrarModal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            btnCerrarModal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            btnCerrarModal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCerrarModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCerrarModal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            btnCerrarModal.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnCerrarModal.IconColor = System.Drawing.Color.White;
            btnCerrarModal.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarModal.IconSize = 55;
            btnCerrarModal.Location = new System.Drawing.Point(1083, 0);
            btnCerrarModal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnCerrarModal.Name = "btnCerrarModal";
            btnCerrarModal.Size = new System.Drawing.Size(97, 74);
            btnCerrarModal.TabIndex = 5;
            btnCerrarModal.UseVisualStyleBackColor = false;
            btnCerrarModal.Click += new System.EventHandler(this.btnCerrarModal_Click);
            // 
            // panelRAHeader
            // 
            this.panelRAHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelRAHeader.Controls.Add(btnCerrarModal);
            this.panelRAHeader.Controls.Add(this.label1);
            this.panelRAHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRAHeader.Location = new System.Drawing.Point(0, 0);
            this.panelRAHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelRAHeader.Name = "panelRAHeader";
            this.panelRAHeader.Size = new System.Drawing.Size(1180, 74);
            this.panelRAHeader.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿Desea terminar las tareas?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbCodigoSupervisor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 454);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 180);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(403, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Supervisor de la actividad:";
            // 
            // tbCodigoSupervisor
            // 
            this.tbCodigoSupervisor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigoSupervisor.BackColor = System.Drawing.Color.Transparent;
            this.tbCodigoSupervisor.BaseColor = System.Drawing.Color.White;
            this.tbCodigoSupervisor.BorderColor = System.Drawing.Color.Silver;
            this.tbCodigoSupervisor.BorderSize = 0;
            this.tbCodigoSupervisor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCodigoSupervisor.FocusedBaseColor = System.Drawing.Color.White;
            this.tbCodigoSupervisor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbCodigoSupervisor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCodigoSupervisor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoSupervisor.Location = new System.Drawing.Point(24, 92);
            this.tbCodigoSupervisor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCodigoSupervisor.Name = "tbCodigoSupervisor";
            this.tbCodigoSupervisor.PasswordChar = '\0';
            this.tbCodigoSupervisor.Radius = 5;
            this.tbCodigoSupervisor.SelectedText = "";
            this.tbCodigoSupervisor.Size = new System.Drawing.Size(1123, 53);
            this.tbCodigoSupervisor.TabIndex = 10;
            this.tbCodigoSupervisor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoSupervisor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1002, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Si usted es un supervisor de area y quiere finalizar las tareas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1076, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "seleccione el cuadro de texto y despues escanee su codigo de";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1033, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "barras, se validara si usted tiene los permisos necesarios para";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(958, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "finalizar las actividades y asi hacer el registro del historial";
            // 
            // FinalizarTareasModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1180, 634);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRAHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FinalizarTareasModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinalizarTareasModal";
            this.panelRAHeader.ResumeLayout(false);
            this.panelRAHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRAHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox tbCodigoSupervisor;
        private System.Windows.Forms.Label label6;
    }
}