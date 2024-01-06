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
        ActivitiesCrudModel actividad = new ActivitiesCrudModel();

        public Actividades()
        {
            InitializeComponent();
        }

        private void Actividades_Load(object sender, EventArgs e)
        {
            ListarAreas();
            ListarEquipos();
            ListarFrecuencias();
            MostrarTablaActividades();
            ConfigurarDataGridView();
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


        //Funcion para mostrar los datos en la tabla de Actividades//
        private void MostrarTablaActividades()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            dgvActividadesTabla.DataSource = actividad.MostrarActividades();
        }
        private void ConfigurarDataGridView()
        {
            dgvActividadesTabla.RowTemplate.Height = 50;
        }
        //Fin//


        //Funcion para agregar datos a la tabla de Actividades//
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            actividad.InsertarActidad(Convert.ToInt32(cmbAreaEmpresa.SelectedValue), Convert.ToInt32(cmbEquipos.SelectedValue),
            Convert.ToInt32(cmbFrecuencia.SelectedValue), tbFechaMantenimiento.Text, tbActividad.Text, tbFormato.Text);
            MessageBox.Show("Actividad insertada con éxito");
            MostrarTablaActividades();

            // Limpiar campos al ejecutar la acción del botón
            LimpiarCampos();
        }
        //Fin//


        //Funcion para limpiar los textbox del formulario//
        private void LimpiarCampos()
        {
            //limpiar campos al ejecutar la accion del boton
            tbFechaMantenimiento.Clear();
            tbActividad.Clear();
            tbFormato.Clear();
        }
        //Fin//

    }
}
