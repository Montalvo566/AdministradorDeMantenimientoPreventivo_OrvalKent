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
            panelMenuPrincipal.Visible = false;
        }

        private void ocultarSubmenus()
        {
            if (panelMenuPrincipal.Visible == true)
            {
                panelMenuPrincipal.Visible = false;
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
            mostrarSubmenus(panelMenuPrincipal);
        }
        private void btnSeccionMenu_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Form1());
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
