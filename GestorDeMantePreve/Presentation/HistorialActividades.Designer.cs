﻿
namespace Presentation
{
    partial class HistorialActividades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelRAHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gdgvHistorialActividades = new Guna.UI.WinForms.GunaDataGridView();
            this.panelRAHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdgvHistorialActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRAHeader
            // 
            this.panelRAHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelRAHeader.Controls.Add(this.label1);
            this.panelRAHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRAHeader.Location = new System.Drawing.Point(0, 0);
            this.panelRAHeader.Name = "panelRAHeader";
            this.panelRAHeader.Size = new System.Drawing.Size(827, 54);
            this.panelRAHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Historial de actividades terminadas";
            // 
            // gdgvHistorialActividades
            // 
            this.gdgvHistorialActividades.AllowUserToAddRows = false;
            this.gdgvHistorialActividades.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gdgvHistorialActividades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gdgvHistorialActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdgvHistorialActividades.BackgroundColor = System.Drawing.Color.White;
            this.gdgvHistorialActividades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdgvHistorialActividades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgvHistorialActividades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdgvHistorialActividades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gdgvHistorialActividades.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdgvHistorialActividades.DefaultCellStyle = dataGridViewCellStyle6;
            this.gdgvHistorialActividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.gdgvHistorialActividades.EnableHeadersVisualStyles = false;
            this.gdgvHistorialActividades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvHistorialActividades.Location = new System.Drawing.Point(0, 54);
            this.gdgvHistorialActividades.Name = "gdgvHistorialActividades";
            this.gdgvHistorialActividades.ReadOnly = true;
            this.gdgvHistorialActividades.RowHeadersVisible = false;
            this.gdgvHistorialActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdgvHistorialActividades.Size = new System.Drawing.Size(827, 439);
            this.gdgvHistorialActividades.TabIndex = 0;
            this.gdgvHistorialActividades.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gdgvHistorialActividades.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgvHistorialActividades.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdgvHistorialActividades.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdgvHistorialActividades.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdgvHistorialActividades.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdgvHistorialActividades.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdgvHistorialActividades.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvHistorialActividades.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdgvHistorialActividades.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdgvHistorialActividades.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgvHistorialActividades.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdgvHistorialActividades.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdgvHistorialActividades.ThemeStyle.HeaderStyle.Height = 4;
            this.gdgvHistorialActividades.ThemeStyle.ReadOnly = true;
            this.gdgvHistorialActividades.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgvHistorialActividades.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgvHistorialActividades.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdgvHistorialActividades.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdgvHistorialActividades.ThemeStyle.RowsStyle.Height = 22;
            this.gdgvHistorialActividades.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgvHistorialActividades.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // HistorialActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(827, 613);
            this.Controls.Add(this.gdgvHistorialActividades);
            this.Controls.Add(this.panelRAHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialActividades";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.HistorialActividades_Load);
            this.panelRAHeader.ResumeLayout(false);
            this.panelRAHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdgvHistorialActividades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRAHeader;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView gdgvHistorialActividades;
    }
}