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
            HistorialDomain historial = new HistorialDomain();
            gdgvHistorialActividades.DataSource = historial.MostrarHistorialActividades();
            // Establecer la altura mínima de las filas
            gdgvHistorialActividades.RowTemplate.MinimumHeight = 50;
            gdgvHistorialActividades.RowTemplate.Height = 50;
            gdgvHistorialActividades.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
