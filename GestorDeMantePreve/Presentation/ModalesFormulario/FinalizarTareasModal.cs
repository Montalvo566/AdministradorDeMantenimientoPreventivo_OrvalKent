using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation.ModalesFormulario
{
    public partial class FinalizarTareasModal : Form
    {
        private string nombreUsuario;

        public FinalizarTareasModal(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            MostrarNombreUsuario();
        }

        private void btnCerrarModal_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Funcion para cargar las actividades del usuario en la pantalla//
        private void MostrarNombreUsuario()
        {
            lbNombreUsuarioActividades.Text = nombreUsuario;
        }
        //Fin//


        //Funcion para cambiar el estado de las actividades y hacer el historial//
        private void tbCodigoSupervisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            MenuPrincipal main = new MenuPrincipal();
            main.tbCodigoBarras.Focus();
            this.Close();
        }
        //Fin//
    }
}
