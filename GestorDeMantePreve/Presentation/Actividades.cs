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
    public partial class Actividades : Form
    {
        

        public Actividades()
        {
            InitializeComponent();
        }

        private void Actividades_Load(object sender, EventArgs e)
        {
            ListarAreas();
            ListarEquipos();
            ListarFrecuencias();
        }

        //Funciones para listar los datos del combobox//
        private void ListarAreas()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            cmbAreaEmpresa.DataSource = actividad.ListadoAreas();
            cmbAreaEmpresa.DisplayMember = "NombreEmpresa";
            cmbAreaEmpresa.ValueMember = "Id";
        }

        private void ListarEquipos()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            cmbEquipos.DataSource = actividad.ListadoEquipos();
            cmbEquipos.DisplayMember = "NombreEquipo";
            cmbEquipos.ValueMember = "Id";
        }

        private void ListarFrecuencias()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            cmbFrecuencia.DataSource = actividad.ListadoFrecuencias();
            cmbFrecuencia.DisplayMember = "Freciencia";
            cmbFrecuencia.ValueMember = "Id";
        }
        //Fin//

    }
}
