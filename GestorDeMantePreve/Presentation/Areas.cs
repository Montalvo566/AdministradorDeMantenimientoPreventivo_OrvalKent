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
    public partial class Areas : Form
    {
        public Areas()
        {
            InitializeComponent();
        }

        private void Areas_Load(object sender, EventArgs e)
        {
            ListarDepartamentos();
            MostrarAreasTabla();
            ConfigurarDataGridView();
        }


        //Funcion para mostrar los datos en la tabla de usuarios//
        private void MostrarAreasTabla()
        {
            AreasCrudModel areasCrud = new AreasCrudModel();
            dgvAreasTabla.DataSource = areasCrud.MostrarTablaAreas();
        }
        private void ConfigurarDataGridView()
        {
            dgvAreasTabla.RowTemplate.Height = 50;
        }
        //Fin//


        //Funciones para listar los datos del combobox//
        private void ListarDepartamentos()
        {
            AreasCrudModel areasCrud = new AreasCrudModel();
            gcmbDepartamento.DataSource = areasCrud.ListadoDepartamentos();
            gcmbDepartamento.DisplayMember = "Departamento";
            gcmbDepartamento.ValueMember = "Id";
        }
        //Fin//

    }
}
