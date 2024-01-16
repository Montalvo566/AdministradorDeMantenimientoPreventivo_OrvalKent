using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Domain;
using DataAccess;

namespace Presentation
{
    public partial class Departamentos : Form
    {
        DepartamentCrudModel depCrudTabla = new DepartamentCrudModel();

        public Departamentos()
        {
            InitializeComponent();
        }

        private void Departamentos_Load(object sender, EventArgs e)
        {
            MostrarDepartamentosTabla();
            ConfigurarDataGridView();
        }


        //Funcion para mostrar los datos en la tabla de usuarios//
        private void MostrarDepartamentosTabla()
        {
            DepartamentCrudModel depCrudTabla = new DepartamentCrudModel();
            dgvDepartamentosTabla.DataSource = depCrudTabla.MostrarTablaDep();
        }
        private void ConfigurarDataGridView()
        {
            dgvDepartamentosTabla.RowTemplate.Height = 50;
        }
        //Fin//
    }
}
