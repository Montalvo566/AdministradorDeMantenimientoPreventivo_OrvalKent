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
using Guna.UI.WinForms;
using System.Globalization;

namespace Presentation
{
    public partial class MenuPrincipal : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private UserModel userModel;
        private KeyMessageFilter keyMessageFilter;
        private int numeroEmpleado;
        public GunaTextBox CodigoBarrasTextBox
        {
            get { return tbCodigoBarras; }
        }
        private StringBuilder codigoBarrasBuffer = new StringBuilder();
        private bool capturaCodigoBarrasHabilitada = true;


        public MenuPrincipal()
        {
            InitializeComponent();
            personalizarDiseño();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pMenuLateral.Controls.Add(leftBorderBtn);
            userModel = new UserModel();
            PermisosUsuarios();

            // Inicializa el filtro de mensajes
            keyMessageFilter = new KeyMessageFilter();
            keyMessageFilter.KeyPressed += KeyMessageFilter_KeyPressed;
            Application.AddMessageFilter(keyMessageFilter);
        }


        //Permisos de usuarios//
        private void PermisosUsuarios()
        {
            if (UserLoginCache.Puesto == UserPermissions.Empleado)
            {
                btnRegistros.Enabled = false;
                btnMostrarCruds.Enabled = false;
                btnActividades.Enabled = false;
                btnEquipos.Enabled = false;
                btnUsuarios.Enabled = false;
                btnDepartamentos.Enabled = false;
                btnAreas.Enabled = false;
                btnTareasAsignadas.Enabled = false;
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
            capturaCodigoBarrasHabilitada = true;
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
            capturaCodigoBarrasHabilitada = false;
            abrirFormularioHijo(new HistorialActividades());
            ocultarSubmenus();
        }

        //Actividades
        private void btnActividades_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            capturaCodigoBarrasHabilitada = false;
            abrirFormularioHijo(new Actividades());
        }

        //Usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            capturaCodigoBarrasHabilitada = false;
            abrirFormularioHijo(new Usuarios());
        }

        //Departamentos
        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            capturaCodigoBarrasHabilitada = false;
            abrirFormularioHijo(new Departamentos());
        }

        //Equipos
        private void btnEquipos_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            capturaCodigoBarrasHabilitada = false;
            abrirFormularioHijo(new Equipos());
        }

        //Areas
        private void btnAreas_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            capturaCodigoBarrasHabilitada = false;
            abrirFormularioHijo(new Areas());
        }

        //Secciones desplegables
        private void btnTareasAsignadas_Click(object sender, EventArgs e)
        {
            botonActivado(sender, RGBColors.color1);
            capturaCodigoBarrasHabilitada = false;
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
            capturaCodigoBarrasHabilitada = false;
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
            ValdiacionesTipoCampo();
            MostrarActividadesUsuario();
            ResetearEstadoActividadesSiFechaVencida();
        }
        //Fin//


        //Funcion para resetear el estado de las actividades//
        private void ResetearEstadoActividadesSiFechaVencida()
        {
            try
            {
                UserModel userModel = new UserModel();
                userModel.ResetearEstadoActividadesSiFechaVencida();
                MostrarActividadesUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al resetear el estado de las actividades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Fin//


        //Cargar lod datos del usuario, Nombre e imagen//
        private void cargarDatosUsuario()
        {
            lbNombreInicioSesion.Text = UserLoginCache.NombreCompleto;

            try
            {
                if (!string.IsNullOrEmpty(UserLoginCache.Foto) && File.Exists(UserLoginCache.Foto))
                {
                    Image originalImage = Image.FromFile(UserLoginCache.Foto);
                    Image roundedImage = RoundImage(originalImage);
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
            Bitmap roundedImage = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics g = Graphics.FromImage(roundedImage))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, roundedImage.Width - 1, roundedImage.Height - 1);
                g.SetClip(path);
                g.DrawImage(originalImage, 0, 0);
            }

            return roundedImage;
        }
        //Fin//


        // Evento KeyPress para manejar el escaneo del código de barras//
        private void KeyMessageFilter_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (capturaCodigoBarrasHabilitada)
            {
                if (char.IsDigit(e.KeyChar))
                {
                    codigoBarrasBuffer.Append(e.KeyChar);
                    tbCodigoBarras.Text = codigoBarrasBuffer.ToString();
                }
                else if (e.KeyChar == (char)Keys.Enter)
                {
                    string codigoBarras = codigoBarrasBuffer.ToString();
                    ProcesarCodigoBarras(codigoBarras);
                    codigoBarrasBuffer.Clear();
                }
            }
        }
        private void MenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyCode))
            {
                codigoBarrasBuffer.Append((char)e.KeyCode);
                tbCodigoBarras.Text = codigoBarrasBuffer.ToString();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                string codigoBarras = codigoBarrasBuffer.ToString();
                ProcesarCodigoBarras(codigoBarras);
                codigoBarrasBuffer.Clear();
                e.SuppressKeyPress = true;
            }
        }
        //Fin//


        // Función para procesar el código de barras y mostrar actividades
        private void ProcesarCodigoBarras(string codigoBarras)
        {
            if (!string.IsNullOrEmpty(codigoBarras))
            {
                if (int.TryParse(codigoBarras, out numeroEmpleado))
                {
                    MostrarActividadesUsuario();
                }
                else
                {
                    MessageBox.Show("El código de barras no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Fin//


        //Mostrar actividades usuarios//
        private void MostrarActividadesUsuario()
        {
            try
            {
                UserModel actividad = new UserModel();
                DataTable tablaActividades = actividad.MostrarActividadesCodigoBarras(numeroEmpleado);

                dgvMostrarActividadesUsuarios.Columns.Clear();
                dgvMostrarActividadesUsuarios.RowTemplate.MinimumHeight = 85;
                dgvMostrarActividadesUsuarios.RowTemplate.Height = 85;
                dgvMostrarActividadesUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvMostrarActividadesUsuarios.ForeColor = Color.White;

                dgvMostrarActividadesUsuarios.DataSource = tablaActividades;

                //Establecer la multilinea
                int columnaMultilinea = 1;
                dgvMostrarActividadesUsuarios.Columns[columnaMultilinea].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvMostrarActividadesUsuarios.Columns[columnaMultilinea].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvMostrarActividadesUsuarios.Columns[columnaMultilinea].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Crear columna de botones
                DataGridViewButtonColumn botonAcciones = new DataGridViewButtonColumn();
                botonAcciones.Name = "Acciones";
                botonAcciones.Text = "Completar tarea";
                botonAcciones.UseColumnTextForButtonValue = true;
                dgvMostrarActividadesUsuarios.Columns.Add(botonAcciones);

                dgvMostrarActividadesUsuarios.CellContentClick -= dgvMostrarActividadesUsuarios_CellContentClick;
                dgvMostrarActividadesUsuarios.CellContentClick += dgvMostrarActividadesUsuarios_CellContentClick;
                dgvMostrarActividadesUsuarios.CellFormatting += dgvActividadesTabla_CellFormatting;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar actividades de usuario: " + ex.Message);
            }
        }

        //Funcion que asignar la funcion de cambiar el estado de la aplicacion sin que se repita la funcion//
        private void dgvMostrarActividadesUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMostrarActividadesUsuarios.Columns["Acciones"].Index)
            {
                try
                {
                    int idActividad = Convert.ToInt32(dgvMostrarActividadesUsuarios.Rows[e.RowIndex].Cells[0].Value);
                    CambiarEstadoActividad(idActividad);
                    MessageBox.Show("La actividad pasó a revisión", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarActividadesUsuario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la acción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Funcion para cambiar el color del estatus en referencia al estatus//
        private void dgvActividadesTabla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvMostrarActividadesUsuarios.Columns["Estatus"].Index && e.Value != null)
            {
                string estatusTexto = e.Value.ToString();
                switch (estatusTexto)
                {
                    case "Terminado":
                        e.CellStyle.ForeColor = Color.Green;
                        break;
                    case "En revisión":
                        e.CellStyle.ForeColor = Color.Blue;
                        break;
                    case "Pendiente":
                        e.CellStyle.ForeColor = Color.Red;
                        break;
                    default:
                        break;
                }
            }
        }
        //Fin//


        // Función para cambiar el estado de la actividad
        private void CambiarEstadoActividad(int idActividad)
        {
            UserDao userDao = new UserDao();
            userDao.Id1 = idActividad;
            userDao.Estatus1 = 3;
            userDao.CambiarEstadoActividad();
        }
        //Fin//


        //Funcion para abrir el modal en el cual se finalizara las tareas//
        private void btnFinalizarTareas_Click(object sender, EventArgs e)
        {
            ModalesFormulario.FinalizarTareasModal modal = new ModalesFormulario.FinalizarTareasModal();
            modal.Owner = this;
            capturaCodigoBarrasHabilitada = false;
            modal.ShowDialog();
        }
        public void HabilitarCapturaCodigoBarras(bool habilitado)
        {
            capturaCodigoBarrasHabilitada = habilitado;
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
