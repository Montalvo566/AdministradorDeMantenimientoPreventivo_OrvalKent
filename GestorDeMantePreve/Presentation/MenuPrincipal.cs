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
                        dgvMostrarActividadesUsuarios.DataSource = actividadesUsuario;
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

    }
}
