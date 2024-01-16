
namespace Presentation
{
    partial class RegistrosActividades
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
            this.panelRAHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pRegistroActividades = new System.Windows.Forms.Panel();
            this.panelRAHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRAHeader
            // 
            this.panelRAHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelRAHeader.Controls.Add(this.label1);
            this.panelRAHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRAHeader.Location = new System.Drawing.Point(0, 0);
            this.panelRAHeader.Name = "panelRAHeader";
            this.panelRAHeader.Size = new System.Drawing.Size(825, 57);
            this.panelRAHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registro de actividades realizadas";
            // 
            // pRegistroActividades
            // 
            this.pRegistroActividades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pRegistroActividades.Location = new System.Drawing.Point(0, 63);
            this.pRegistroActividades.Name = "pRegistroActividades";
            this.pRegistroActividades.Size = new System.Drawing.Size(825, 550);
            this.pRegistroActividades.TabIndex = 1;
            // 
            // RegistrosActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(825, 613);
            this.Controls.Add(this.pRegistroActividades);
            this.Controls.Add(this.panelRAHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrosActividades";
            this.Text = "Form4";
            this.panelRAHeader.ResumeLayout(false);
            this.panelRAHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRAHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pRegistroActividades;
    }
}