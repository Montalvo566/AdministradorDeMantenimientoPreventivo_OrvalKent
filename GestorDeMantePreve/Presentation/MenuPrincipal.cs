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
using System.IO;
using System.Drawing.Drawing2D;

namespace Presentation
{
    public partial class MenuPrincipal : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private UserModel userModel;

        public MenuPrincipal()
        {
            InitializeComponent();
            personalizarDiseño();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pMenuLateral.Controls.Add(leftBorderBtn);

            userModel = new UserModel();

            PermisosUsuarios();
        }


        //Permisos de usuarios//
        private void PermisosUsuarios()
        {
            if (UserLoginCache.Puesto == UserPermissions.Supervisor)
            {
                btnMostrarCruds.Enabled = false;
                btnActividades.Enabled = false;
                btnEquipos.Enabled = false;
                btnUsuarios.Enabled = false;
                btnDepartamentos.Enabled = false;
                btnAreas.Enabled = false;
            }

            if (UserLoginCache.Puesto == UserPermissions.Empleado)
            {
                btnRegistros.Enabled = false;
                btnMostrarCruds.Enabled = false;
                btnActividades.Enabled = false;
                btnEquipos.Enabled = false;
                btnUsuarios.Enabled = false;
                btnDepartamentos.Enabled = false;
                btnAreas.Enabled = false;
            }
        }
        //Fin//


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
            if (activeForm != null && activeForm.GetType() == typeof(MenuPrincipal))
            {
                return;
            }

            if (activeForm != null)
            {
                activeForm.Close();
            }

            botonActivado(sender, RGBColors.color1);
            ocultarSubmenus();
            MostrarPantallaPrincipal();     
        }
        private void MostrarPantallaPrincipal()
        {
            activeForm = null;
        }


        //Registro de actividades
        private void btnRegistros_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            abrirFormularioHijo(new HistorialActividades());
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
            ValdiacionesTipoCampo();
        }
        //Fin//


        //Cargar lod datos del usuario, Nombre e imagen//
        private void cargarDatosUsuario()
        {
            lbNombreInicioSesion.Text = UserLoginCache.NombreCompleto;

            try
            {
                // Verificar si la propiedad Foto está disponible
                if (!string.IsNullOrEmpty(UserLoginCache.Foto) && File.Exists(UserLoginCache.Foto))
                {
                    // Cargar la imagen original
                    Image originalImage = Image.FromFile(UserLoginCache.Foto);

                    // Redondear la imagen
                    Image roundedImage = RoundImage(originalImage);

                    // Mostrar la imagen redondeada en el PictureBox
                    pbUsuario.Image = roundedImage;
                }
                else
                {
                    Console.WriteLine("No se pudo cargar la imagen");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la imagen del usuario: " + ex.Message);
            }
        }
        private Image RoundImage(Image originalImage)
        {
            // Crear un Bitmap redondeado con el mismo tamaño que la imagen original
            Bitmap roundedImage = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics g = Graphics.FromImage(roundedImage))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Crear un path redondeado
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, roundedImage.Width - 1, roundedImage.Height - 1);

                // Aplicar el path al área de recorte del gráfico
                g.SetClip(path);

                // Dibujar la imagen original en el gráfico redondeado
                g.DrawImage(originalImage, 0, 0);
            }

            return roundedImage;
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

                    }
                    else
                    {
                        Console.WriteLine("No se encontraron actividades asignadas para el usuario actual.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener actividades en la presentación: " + ex.Message);
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
                    userDao.Estatus1 = 3;
                    userDao.CambiarEstadoActividad();
                    MessageBox.Show("La actividad paso a revisión.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La actividad no se pudo finalizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Fin//


        //Validaciones de campos//
        private void SoloFormatoNumero(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y la tecla de retroceso (backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Ignora la tecla presionada
            }
        }
        private void ValdiacionesTipoCampo()
        {
            tbCodigoBarras.KeyPress += new KeyPressEventHandler(SoloFormatoNumero);
        }
        //Fin//




    }
}
