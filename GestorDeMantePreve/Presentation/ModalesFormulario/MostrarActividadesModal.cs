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

        private void MostrarActividadesModal_Load(object sender, EventArgs e)
        {
            tbEstatus.Paint += TextBoxEstatus_Paint;
        }


        //Cambiar el color del textbox en referencia al estado//
        private void TextBoxEstatus_Paint(object sender, PaintEventArgs e)
        {
            string estatusTexto = tbEstatus.Text;
            switch (estatusTexto)
            {
                case "Terminado":
                    tbEstatus.ForeColor = Color.Green;
                    break;
                case "En revisión":
                    tbEstatus.ForeColor = Color.Blue;
                    break;
                case "Pendiente":
                    tbEstatus.ForeColor = Color.Red;
                    break;
                default:
                    break;
            }
        }
        //Fin//


        //Boton para cerrar el formulario del modal//
        private void btnCerrarTarea_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Fin//
    }
}
