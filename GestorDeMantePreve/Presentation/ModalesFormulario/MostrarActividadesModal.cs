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
    public partial class MostrarActividadesModal : Form
    {
        public MostrarActividadesModal()
        {
            InitializeComponent();
        }


        //Boton para cerrar el formulario del modal//
        private void btnCerrarTarea_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Fin//
    }
}
