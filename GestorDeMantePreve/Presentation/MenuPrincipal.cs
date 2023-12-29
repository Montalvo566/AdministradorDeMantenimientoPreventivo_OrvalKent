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
            abrirFormularioHijo(new FormularioMenu());
            ocultarSubmenus();
        }

        //Actividades
        private void btnActividades_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Actividades());
            ocultarSubmenus();
        }

        //Usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Usuarios());
            ocultarSubmenus();
        }

        //Secciones desplegables
        private void btnTareasAsignadas_Click(object sender, EventArgs e)
        {
            mostrarSubmenus(panelSeccionTareas);
        }
        private void btnSeccionTareas_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new TareasAsignadas());
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


    }
}
