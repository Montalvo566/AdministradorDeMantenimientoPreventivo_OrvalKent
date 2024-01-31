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

namespace Presentation
{
    public partial class HistorialActividades : Form
    {
        

        public HistorialActividades()
        {
            InitializeComponent();
        }

        //Funcion para mostrar el historial de Actividades//
        //Fin//

        private void HistorialActividades_Load(object sender, EventArgs e)
        {
            HistorialActividadesModal historial = new HistorialActividadesModal();
            gdgvHistorialActividades.DataSource = historial.MostrarHistorialActividades();
        }
    }
}
