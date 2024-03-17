using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.ModalesFormulario
{
    public partial class MostrarHistorial : Form
    {
        public MostrarHistorial()
        {
            InitializeComponent();
        }

        private void MostrarHistorial_Load(object sender, EventArgs e)
        {

        }


        //Funcion para cerrar los detalles del historial//
        private void btnCerrarTarea_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Fin//


    }
}
