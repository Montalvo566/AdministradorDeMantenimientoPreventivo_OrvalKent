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
using DataAccess;

namespace Presentation
{
    public partial class Equipos : Form
    {
        EquiposCrudModel equiposCrudTabla = new EquiposCrudModel();

        public Equipos()
        {
            InitializeComponent();
        }

        private void Equipos_Load(object sender, EventArgs e)
        {
            ListarAreas();
            MostrarDepartamentosTabla();
            ConfigurarDataGridView();
        }


        //Funcion para mostrar los datos en la tabla de usuarios//
        private void MostrarDepartamentosTabla()
        {
            EquiposCrudModel equiposCrudTabla = new EquiposCrudModel();
            dgvEquiposTabla.DataSource = equiposCrudTabla.MostrarTablaEquipos();
        }
        private void ConfigurarDataGridView()
        {
            dgvEquiposTabla.RowTemplate.Height = 50;
        }
        //Fin//


        //Funciones para listar los datos del combobox//
        private void ListarAreas()
        {
            EquiposCrudModel equiposCrudTabla = new EquiposCrudModel();
            gcmbArea.DataSource = equiposCrudTabla.ListadoAreas();
            gcmbArea.DisplayMember = "Zona";
            gcmbArea.ValueMember = "Id";
        }
        //Fin//


    }
}
