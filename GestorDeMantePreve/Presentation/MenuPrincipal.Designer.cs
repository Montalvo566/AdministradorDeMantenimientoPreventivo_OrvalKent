
namespace Presentation
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.pMenuLateral = new System.Windows.Forms.Panel();
            this.panelSeccionTareas = new System.Windows.Forms.Panel();
            this.btnAreas = new FontAwesome.Sharp.IconButton();
            this.btnEquipos = new FontAwesome.Sharp.IconButton();
            this.btnDepartamentos = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnActividades = new FontAwesome.Sharp.IconButton();
            this.btnMostrarCruds = new FontAwesome.Sharp.IconButton();
            this.btnTareasAsignadas = new FontAwesome.Sharp.IconButton();
            this.btnRegistros = new FontAwesome.Sharp.IconButton();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.btnMenuPrincipal = new FontAwesome.Sharp.IconButton();
            this.pLogo = new System.Windows.Forms.Panel();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.lbNombreInicioSesion = new System.Windows.Forms.Label();
            this.panelFormularioHijo = new System.Windows.Forms.Panel();
            this.btnFinalizarTareas = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigoBarras = new Guna.UI.WinForms.GunaTextBox();
            this.dgvMostrarActividadesUsuarios = new Guna.UI.WinForms.GunaDataGridView();
            this.pMenuLateral.SuspendLayout();
            this.panelSeccionTareas.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.panelFormularioHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarActividadesUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenuLateral
            // 
            this.pMenuLateral.AutoScroll = true;
            this.pMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pMenuLateral.Controls.Add(this.panelSeccionTareas);
            this.pMenuLateral.Controls.Add(this.btnMostrarCruds);
            this.pMenuLateral.Controls.Add(this.btnTareasAsignadas);
            this.pMenuLateral.Controls.Add(this.btnRegistros);
            this.pMenuLateral.Controls.Add(this.btnCerrarSesion);
            this.pMenuLateral.Controls.Add(this.btnMenuPrincipal);
            this.pMenuLateral.Controls.Add(this.pLogo);
            this.pMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pMenuLateral.Name = "pMenuLateral";
            this.pMenuLateral.Size = new System.Drawing.Size(242, 613);
            this.pMenuLateral.TabIndex = 0;
            // 
            // panelSeccionTareas
            // 
            this.panelSeccionTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelSeccionTareas.Controls.Add(this.btnAreas);
            this.panelSeccionTareas.Controls.Add(this.btnEquipos);
            this.panelSeccionTareas.Controls.Add(this.btnDepartamentos);
            this.panelSeccionTareas.Controls.Add(this.btnUsuarios);
            this.panelSeccionTareas.Controls.Add(this.btnActividades);
            this.panelSeccionTareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeccionTareas.Location = new System.Drawing.Point(0, 395);
            this.panelSeccionTareas.Name = "panelSeccionTareas";
            this.panelSeccionTareas.Size = new System.Drawing.Size(221, 311);
            this.panelSeccionTareas.TabIndex = 0;
            // 
            // btnAreas
            // 
            this.btnAreas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAreas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAreas.FlatAppearance.BorderSize = 0;
            this.btnAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreas.ForeColor = System.Drawing.Color.White;
            this.btnAreas.IconChar = FontAwesome.Sharp.IconChar.LocationPinLock;
            this.btnAreas.IconColor = System.Drawing.Color.White;
            this.btnAreas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAreas.IconSize = 30;
            this.btnAreas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAreas.Location = new System.Drawing.Point(0, 240);
            this.btnAreas.Name = "btnAreas";
            this.btnAreas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAreas.Size = new System.Drawing.Size(221, 60);
            this.btnAreas.TabIndex = 6;
            this.btnAreas.Text = "Areas";
            this.btnAreas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAreas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAreas.UseVisualStyleBackColor = false;
            this.btnAreas.Click += new System.EventHandler(this.btnAreas_Click);
            // 
            // btnEquipos
            // 
            this.btnEquipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnEquipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEquipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEquipos.FlatAppearance.BorderSize = 0;
            this.btnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipos.ForeColor = System.Drawing.Color.White;
            this.btnEquipos.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnEquipos.IconColor = System.Drawing.Color.White;
            this.btnEquipos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEquipos.IconSize = 30;
            this.btnEquipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipos.Location = new System.Drawing.Point(0, 180);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEquipos.Size = new System.Drawing.Size(221, 60);
            this.btnEquipos.TabIndex = 5;
            this.btnEquipos.Text = "Equipos";
            this.btnEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEquipos.UseVisualStyleBackColor = false;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnDepartamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartamentos.FlatAppearance.BorderSize = 0;
            this.btnDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartamentos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartamentos.ForeColor = System.Drawing.Color.White;
            this.btnDepartamentos.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.btnDepartamentos.IconColor = System.Drawing.Color.White;
            this.btnDepartamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDepartamentos.IconSize = 30;
            this.btnDepartamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartamentos.Location = new System.Drawing.Point(0, 120);
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDepartamentos.Size = new System.Drawing.Size(221, 60);
            this.btnDepartamentos.TabIndex = 4;
            this.btnDepartamentos.Text = "Departamentos";
            this.btnDepartamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartamentos.UseVisualStyleBackColor = false;
            this.btnDepartamentos.Click += new System.EventHandler(this.btnDepartamentos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 30;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 60);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(221, 60);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnActividades
            // 
            this.btnActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActividades.FlatAppearance.BorderSize = 0;
            this.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActividades.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActividades.ForeColor = System.Drawing.Color.White;
            this.btnActividades.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnActividades.IconColor = System.Drawing.Color.White;
            this.btnActividades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActividades.IconSize = 30;
            this.btnActividades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActividades.Location = new System.Drawing.Point(0, 0);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnActividades.Size = new System.Drawing.Size(221, 60);
            this.btnActividades.TabIndex = 2;
            this.btnActividades.Text = "Actividades";
            this.btnActividades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActividades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActividades.UseVisualStyleBackColor = false;
            this.btnActividades.Click += new System.EventHandler(this.btnActividades_Click);
            // 
            // btnMostrarCruds
            // 
            this.btnMostrarCruds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMostrarCruds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarCruds.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMostrarCruds.FlatAppearance.BorderSize = 0;
            this.btnMostrarCruds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarCruds.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarCruds.ForeColor = System.Drawing.Color.White;
            this.btnMostrarCruds.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnMostrarCruds.IconColor = System.Drawing.Color.White;
            this.btnMostrarCruds.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrarCruds.IconSize = 30;
            this.btnMostrarCruds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarCruds.Location = new System.Drawing.Point(0, 335);
            this.btnMostrarCruds.Name = "btnMostrarCruds";
            this.btnMostrarCruds.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMostrarCruds.Size = new System.Drawing.Size(221, 60);
            this.btnMostrarCruds.TabIndex = 6;
            this.btnMostrarCruds.Text = "Seccion de modulos";
            this.btnMostrarCruds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarCruds.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrarCruds.UseVisualStyleBackColor = false;
            this.btnMostrarCruds.Click += new System.EventHandler(this.btnMostrarCruds_Click);
            // 
            // btnTareasAsignadas
            // 
            this.btnTareasAsignadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnTareasAsignadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTareasAsignadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTareasAsignadas.FlatAppearance.BorderSize = 0;
            this.btnTareasAsignadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareasAsignadas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareasAsignadas.ForeColor = System.Drawing.Color.White;
            this.btnTareasAsignadas.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.btnTareasAsignadas.IconColor = System.Drawing.Color.White;
            this.btnTareasAsignadas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnTareasAsignadas.IconSize = 30;
            this.btnTareasAsignadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareasAsignadas.Location = new System.Drawing.Point(0, 275);
            this.btnTareasAsignadas.Name = "btnTareasAsignadas";
            this.btnTareasAsignadas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTareasAsignadas.Size = new System.Drawing.Size(221, 60);
            this.btnTareasAsignadas.TabIndex = 2;
            this.btnTareasAsignadas.Text = "Filtro Actividades";
            this.btnTareasAsignadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareasAsignadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTareasAsignadas.UseVisualStyleBackColor = false;
            this.btnTareasAsignadas.Click += new System.EventHandler(this.btnTareasAsignadas_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistros.FlatAppearance.BorderSize = 0;
            this.btnRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistros.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistros.ForeColor = System.Drawing.Color.White;
            this.btnRegistros.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnRegistros.IconColor = System.Drawing.Color.White;
            this.btnRegistros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistros.IconSize = 30;
            this.btnRegistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistros.Location = new System.Drawing.Point(0, 215);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRegistros.Size = new System.Drawing.Size(221, 60);
            this.btnRegistros.TabIndex = 5;
            this.btnRegistros.Text = "Historial Activdades";
            this.btnRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistros.UseVisualStyleBackColor = false;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.IconSize = 30;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 706);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(221, 60);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuPrincipal.FlatAppearance.BorderSize = 0;
            this.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnMenuPrincipal.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnMenuPrincipal.IconColor = System.Drawing.Color.White;
            this.btnMenuPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuPrincipal.IconSize = 30;
            this.btnMenuPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPrincipal.Location = new System.Drawing.Point(0, 155);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuPrincipal.Size = new System.Drawing.Size(221, 60);
            this.btnMenuPrincipal.TabIndex = 1;
            this.btnMenuPrincipal.Text = "Menú Principal";
            this.btnMenuPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuPrincipal.UseVisualStyleBackColor = false;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // pLogo
            // 
            this.pLogo.Controls.Add(this.pbUsuario);
            this.pLogo.Controls.Add(this.lbNombreInicioSesion);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(221, 155);
            this.pLogo.TabIndex = 0;
            // 
            // pbUsuario
            // 
            this.pbUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbUsuario.Image = global::Presentation.Properties.Resources.UserDeafault;
            this.pbUsuario.Location = new System.Drawing.Point(0, 0);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(221, 124);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuario.TabIndex = 0;
            this.pbUsuario.TabStop = false;
            // 
            // lbNombreInicioSesion
            // 
            this.lbNombreInicioSesion.AutoSize = true;
            this.lbNombreInicioSesion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreInicioSesion.ForeColor = System.Drawing.Color.White;
            this.lbNombreInicioSesion.Location = new System.Drawing.Point(7, 127);
            this.lbNombreInicioSesion.Name = "lbNombreInicioSesion";
            this.lbNombreInicioSesion.Size = new System.Drawing.Size(151, 20);
            this.lbNombreInicioSesion.TabIndex = 1;
            this.lbNombreInicioSesion.Text = "Nombre del usuario";
            // 
            // panelFormularioHijo
            // 
            this.panelFormularioHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelFormularioHijo.Controls.Add(this.btnFinalizarTareas);
            this.panelFormularioHijo.Controls.Add(this.label1);
            this.panelFormularioHijo.Controls.Add(this.tbCodigoBarras);
            this.panelFormularioHijo.Controls.Add(this.dgvMostrarActividadesUsuarios);
            this.panelFormularioHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularioHijo.Location = new System.Drawing.Point(242, 0);
            this.panelFormularioHijo.Name = "panelFormularioHijo";
            this.panelFormularioHijo.Size = new System.Drawing.Size(827, 613);
            this.panelFormularioHijo.TabIndex = 2;
            // 
            // btnFinalizarTareas
            // 
            this.btnFinalizarTareas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarTareas.AnimationHoverSpeed = 0.07F;
            this.btnFinalizarTareas.AnimationSpeed = 0.03F;
            this.btnFinalizarTareas.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarTareas.BaseColor = System.Drawing.Color.Blue;
            this.btnFinalizarTareas.BorderColor = System.Drawing.Color.Black;
            this.btnFinalizarTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarTareas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFinalizarTareas.FocusedColor = System.Drawing.Color.Empty;
            this.btnFinalizarTareas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarTareas.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarTareas.Image = null;
            this.btnFinalizarTareas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFinalizarTareas.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFinalizarTareas.Location = new System.Drawing.Point(598, 15);
            this.btnFinalizarTareas.Name = "btnFinalizarTareas";
            this.btnFinalizarTareas.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.btnFinalizarTareas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFinalizarTareas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFinalizarTareas.OnHoverImage = null;
            this.btnFinalizarTareas.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnFinalizarTareas.Radius = 5;
            this.btnFinalizarTareas.Size = new System.Drawing.Size(217, 35);
            this.btnFinalizarTareas.TabIndex = 4;
            this.btnFinalizarTareas.Text = "Finalizar las tareas";
            this.btnFinalizarTareas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFinalizarTareas.Click += new System.EventHandler(this.btnFinalizarTareas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de empleado:";
            // 
            // tbCodigoBarras
            // 
            this.tbCodigoBarras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigoBarras.BackColor = System.Drawing.Color.Transparent;
            this.tbCodigoBarras.BaseColor = System.Drawing.Color.White;
            this.tbCodigoBarras.BorderColor = System.Drawing.Color.Silver;
            this.tbCodigoBarras.BorderSize = 0;
            this.tbCodigoBarras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCodigoBarras.Enabled = false;
            this.tbCodigoBarras.FocusedBaseColor = System.Drawing.Color.White;
            this.tbCodigoBarras.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbCodigoBarras.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCodigoBarras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoBarras.Location = new System.Drawing.Point(246, 15);
            this.tbCodigoBarras.Name = "tbCodigoBarras";
            this.tbCodigoBarras.PasswordChar = '\0';
            this.tbCodigoBarras.Radius = 5;
            this.tbCodigoBarras.SelectedText = "";
            this.tbCodigoBarras.Size = new System.Drawing.Size(346, 35);
            this.tbCodigoBarras.TabIndex = 2;
            // 
            // dgvMostrarActividadesUsuarios
            // 
            this.dgvMostrarActividadesUsuarios.AllowUserToAddRows = false;
            this.dgvMostrarActividadesUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMostrarActividadesUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrarActividadesUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrarActividadesUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrarActividadesUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.dgvMostrarActividadesUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMostrarActividadesUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMostrarActividadesUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrarActividadesUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrarActividadesUsuarios.ColumnHeadersHeight = 70;
            this.dgvMostrarActividadesUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrarActividadesUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMostrarActividadesUsuarios.EnableHeadersVisualStyles = false;
            this.dgvMostrarActividadesUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.dgvMostrarActividadesUsuarios.Location = new System.Drawing.Point(6, 61);
            this.dgvMostrarActividadesUsuarios.Name = "dgvMostrarActividadesUsuarios";
            this.dgvMostrarActividadesUsuarios.ReadOnly = true;
            this.dgvMostrarActividadesUsuarios.RowHeadersVisible = false;
            this.dgvMostrarActividadesUsuarios.RowHeadersWidth = 51;
            this.dgvMostrarActividadesUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrarActividadesUsuarios.Size = new System.Drawing.Size(818, 549);
            this.dgvMostrarActividadesUsuarios.TabIndex = 1;
            this.dgvMostrarActividadesUsuarios.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvMostrarActividadesUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMostrarActividadesUsuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMostrarActividadesUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMostrarActividadesUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMostrarActividadesUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMostrarActividadesUsuarios.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.dgvMostrarActividadesUsuarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.dgvMostrarActividadesUsuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.dgvMostrarActividadesUsuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMostrarActividadesUsuarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMostrarActividadesUsuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMostrarActividadesUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMostrarActividadesUsuarios.ThemeStyle.HeaderStyle.Height = 70;
            this.dgvMostrarActividadesUsuarios.ThemeStyle.ReadOnly = true;
            this.dgvMostrarActividadesUsuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMostrarActividadesUsuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMostrarActividadesUsuarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMostrarActividadesUsuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMostrarActividadesUsuarios.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMostrarActividadesUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvMostrarActividadesUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 613);
            this.Controls.Add(this.panelFormularioHijo);
            this.Controls.Add(this.pMenuLateral);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.pMenuLateral.ResumeLayout(false);
            this.panelSeccionTareas.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.panelFormularioHijo.ResumeLayout(false);
            this.panelFormularioHijo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarActividadesUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenuLateral;
        private FontAwesome.Sharp.IconButton btnActividades;
        private System.Windows.Forms.Panel pLogo;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnTareasAsignadas;
        private System.Windows.Forms.PictureBox pbUsuario;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private System.Windows.Forms.Label lbNombreInicioSesion;
        private FontAwesome.Sharp.IconButton btnRegistros;
        private System.Windows.Forms.Panel panelSeccionTareas;
        private FontAwesome.Sharp.IconButton btnMostrarCruds;
        private FontAwesome.Sharp.IconButton btnDepartamentos;
        private FontAwesome.Sharp.IconButton btnEquipos;
        private FontAwesome.Sharp.IconButton btnAreas;
        private Guna.UI.WinForms.GunaDataGridView dgvMostrarActividadesUsuarios;
        private Guna.UI.WinForms.GunaButton btnFinalizarTareas;
        private System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaTextBox tbCodigoBarras;
        public FontAwesome.Sharp.IconButton btnMenuPrincipal;
        private System.Windows.Forms.Panel panelFormularioHijo;
    }
}

