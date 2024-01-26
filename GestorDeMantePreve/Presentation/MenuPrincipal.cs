using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Common.Cache;
using Domain;
using DataAccess;

namespace Presentation
{
    public partial class MenuPrincipal : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form formularioActual = null;
        private UserModel userModel;

        public MenuPrincipal()
        {
            InitializeComponent();
            personalizarDiseño();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pMenuLateral.Controls.Add(leftBorderBtn);

            userModel = new UserModel();
        }


        //Estructura y diseño de los botones del menu lateral//
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(24, 161, 251);
            public static Color color2 = Color.FromArgb(249, 88, 155);
        }
        private void botonActivado(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                botonDesabilitado();

                //Diseño de botones
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
            }
        }
        
        private void botonDesabilitado()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(26, 25, 62);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
            }
        }
        //Fin//


        //Funciones para ocultar el diseño de los paneles con submenus//
        private void personalizarDiseño()
        {
            panelSeccionTareas.Visible = false;
        }

        private void ocultarSubmenus()
        {
            if (panelSeccionTareas.Visible == true)
            {
                panelSeccionTareas.Visible = false;
            }
        }

        private void mostrarSubmenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubmenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        //Fin//


        //Funciones de diseño aplicada a los botones del menu lateral//

        //Menu Principal
        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            ocultarSubmenus();   
            abrirFormularioHijo(new MenuPrincipal());     
        }

        //Registro de actividades
        private void btnRegistros_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            abrirFormularioHijo(new RegistrosActividades());
            ocultarSubmenus();
        }

        //Actividades
        private void btnActividades_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            abrirFormularioHijo(new Actividades());
        }

        //Usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            abrirFormularioHijo(new Usuarios());
        }

        //Departamentos
        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            abrirFormularioHijo(new Departamentos());
        }

        //Equipos
        private void btnEquipos_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            abrirFormularioHijo(new Equipos());
        }

        //Areas
        private void btnAreas_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            abrirFormularioHijo(new Areas());
        }

        //Secciones desplegables
        private void btnTareasAsignadas_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            abrirFormularioHijo(new TareasAsignadas());
            ocultarSubmenus();
        }
        private void btnSeccionTareas_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new TareasAsignadas());
        }
        private void btnMostrarCruds_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            mostrarSubmenus(panelSeccionTareas);
        }

        //Boton de cerrar sesión
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color2);
            ocultarSubmenus();
            //Mensaje de cerrar sesion y validación
            if (MessageBox.Show("¿Desea cerrar la sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //Fin//


        //Funciones para abrir formularios hijos//
        private Form activeForm = null;
        private void abrirFormularioHijo(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelFormularioHijo.Controls.Add(childForm);
            panelFormularioHijo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        //Fin//


        //Funcion para mostrar los datos del usuario que inicio sesion//
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            cargarDatosUsuario();
            mostrarActividadesUsuario();
        }
        private void cargarDatosUsuario()
        {
            lbNombreInicioSesion.Text = UserLoginCache.NombreCompleto;
            lbCorreoInicioSesion.Text = UserLoginCache.Correo;
        }
        //Fin//


        //Mostrar actividades usuarios//
        private void mostrarActividadesUsuario()
        {
            try
            {
                if (userModel != null)
                {
                    string errorMessage;
                    DataTable actividadesUsuario = userModel.MostrarActividadesUsuario(UserLoginCache.Id, out errorMessage);

                    // Verificar si el DataTable contiene datos
                    if (actividadesUsuario.Rows.Count > 0)
                    {
                        // Configurar el DataGridView
                        dgvMostrarActividadesUsuarios.AutoGenerateColumns = false;
                        dgvMostrarActividadesUsuarios.DataSource = actividadesUsuario;

                        // Configurar AutoSizeRowsMode para que las filas se ajusten automáticamente al contenido
                        dgvMostrarActividadesUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        // Establecer la altura mínima de las filas
                        dgvMostrarActividadesUsuarios.RowTemplate.MinimumHeight = 85;
                        dgvMostrarActividadesUsuarios.RowTemplate.Height = 85;

                        // Configurar las columnas de información
                        DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
                        colId.DataPropertyName = "Id";
                        colId.HeaderText = "Id";
                        dgvMostrarActividadesUsuarios.Columns.Add(colId);

                        DataGridViewTextBoxColumn colActividad = new DataGridViewTextBoxColumn();
                        colActividad.DataPropertyName = "Actividad";
                        colActividad.HeaderText = "Actividad";

                        // Configurar la columna "Actividad" como multilinea
                        colActividad.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        colActividad.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

                        dgvMostrarActividadesUsuarios.Columns.Add(colActividad);

                        DataGridViewTextBoxColumn colArea = new DataGridViewTextBoxColumn();
                        colArea.DataPropertyName = "Area";
                        colArea.HeaderText = "Área";
                        dgvMostrarActividadesUsuarios.Columns.Add(colArea);

                        DataGridViewTextBoxColumn colEquipo = new DataGridViewTextBoxColumn();
                        colEquipo.DataPropertyName = "Equipo";
                        colEquipo.HeaderText = "Equipo";
                        dgvMostrarActividadesUsuarios.Columns.Add(colEquipo);

                        DataGridViewTextBoxColumn colEstatus = new DataGridViewTextBoxColumn();
                        colEstatus.DataPropertyName = "Estatus";
                        colEstatus.HeaderText = "Estatus";
                        dgvMostrarActividadesUsuarios.Columns.Add(colEstatus);

                        // Crear una columna de botones solo para la eliminación
                        DataGridViewButtonColumn botonAcciones = new DataGridViewButtonColumn();
                        botonAcciones.Name = "Acciones";
                        botonAcciones.Text = "Finalizar Tarea";
                        botonAcciones.UseColumnTextForButtonValue = true;
                        dgvMostrarActividadesUsuarios.Columns.Add(botonAcciones);

                        // Personalizar la apariencia del DataGridView
                        dgvMostrarActividadesUsuarios.BackgroundColor = Color.FromArgb(31, 34, 74);
                        dgvMostrarActividadesUsuarios.ForeColor = Color.White;
                        colActividad.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                        // Asociar el evento CellContentClick para el botón Eliminar
                        dgvMostrarActividadesUsuarios.CellContentClick += dgvMostrarActividadesUsuarios_CellContentClick;
                        dgvMostrarActividadesUsuarios.CellPainting += dgvMostrarActividadesUsuarios_CellPainting;

                    }
                    else
                    {
                        MessageBox.Show("No se encontraron actividades asignadas para el usuario actual.", "Información", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener actividades en la presentación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Fin//


        //Diseño del datagridview//
        private void dgvMostrarActividadesUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserDao userDao = new UserDao();

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMostrarActividadesUsuarios.Columns["Acciones"].Index)
            {
                try
                {
                    int idActividad = Convert.ToInt32(dgvMostrarActividadesUsuarios.Rows[e.RowIndex].Cells[0].Value);
                    userDao.Id1 = idActividad;
                    userDao.Estatus1 = 1;
                    userDao.CambiarEstadoActividad();
                    MessageBox.Show("Estado cambiado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al cambiar el estado de la actividad en la capa de presentación: " + ex.ToString());
                    MessageBox.Show("Error al cambiar el estado de la actividad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvMostrarActividadesUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Obtener el rectángulo de la celda
                Rectangle rectCell = dgvMostrarActividadesUsuarios.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                // Dibujar una línea en la parte inferior de la celda
                using (Pen pen = new Pen(Color.FromArgb(31, 34, 74), 5)) // Color y grosor de la línea
                {
                    e.Graphics.DrawLine(pen, rectCell.Left - 1, rectCell.Bottom - 1, rectCell.Right - 1, rectCell.Bottom - 1);
                }

                e.Handled = true;
            }
        }

        //Fin//



    }
}
