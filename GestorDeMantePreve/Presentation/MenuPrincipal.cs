using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            personalizarDiseño();
        }

        //Funciones para ocultar el diseño de los paneles con submenus//
        private void personalizarDiseño()
        {
            panelSecciones.Visible = false;
        }

        private void ocultarSubmenus()
        {
            if (panelSecciones.Visible == true)
            {
                panelSecciones.Visible = false;
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
            abrirFormularioHijo(new Form4());
            ocultarSubmenus();
        }

        //Actividades
        private void btnActividades_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Form2());
            ocultarSubmenus();
        }

        //Usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Form3());
            ocultarSubmenus();
        }

        //Secciones desplegables
        private void btnSecciones_Click(object sender, EventArgs e)
        {
            mostrarSubmenus(panelSecciones);
        }
        private void btnSeccionMenu_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Form1());
            ocultarSubmenus();
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

        //Funcionalidades de los botones cerrar ventana, minimizar y maximizar//
        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarVentana_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                // Si la ventana está en estado normal, maximízala
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                // Si la ventana está maximizada, restaura al tamaño original
                this.WindowState = FormWindowState.Normal;
            }
        }
        //Fin//


    }
}
