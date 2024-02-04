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
    public partial class TareasAsignadas : Form
    {
        public TareasAsignadas()
        {
            InitializeComponent();
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TareasAsignadas_Load(object sender, EventArgs e)
        {
            MostrarTablaActividades();
            ConfigurarDataGridView();
            ListarUsuarios();
            CargarOpcionesCantidadRegistros();
        }


        //Funcion para mostrar los datos en la tabla de Actividades//
        private void MostrarTablaActividades()
        {
            TareasAsignadasModel actividad = new TareasAsignadasModel();
            gdgvTablaActividades.DataSource = actividad.MostrarTablaActividades();
        }
        private void ConfigurarDataGridView()
        {
            gdgvTablaActividades.RowTemplate.Height = 30;
            gdgvTablaActividades.ColumnHeadersHeight = 30;
        }
        //Fin//


        //Funcion para listar los combobox//
        private void ListarUsuarios()
        {
            TareasAsignadasModel actividad = new TareasAsignadasModel();
            cmbUsuario.DataSource = actividad.ListadoUsuarios();
            cmbUsuario.DisplayMember = "NombreCompleto";
            cmbUsuario.ValueMember = "Id";
        }
        //Fin//


        //Funcion para filtrar los registro en base a el usuario//
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarActividadesPorUsuario();
        }
        private void FiltrarActividadesPorUsuario()
        {
            if (cmbUsuario.SelectedValue != null)
            {
                int idUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);

                TareasAsignadasModel actividad = new TareasAsignadasModel();
                DataTable actividades = actividad.MostrarTablaActividadesPorUsuario(idUsuario);

                string nombreUsuario = cmbUsuario.Text;

                if (actividades.Rows.Count > 0)
                {
                    int cantidadRegistros = ObtenerCantidadRegistrosSeleccionados();

                    // Obtener solo la cantidad especificada de registros
                    DataTable resultTable = actividades.Clone(); // Crear una tabla con la misma estructura

                    for (int i = 0; i < Math.Min(cantidadRegistros, actividades.Rows.Count); i++)
                    {
                        resultTable.ImportRow(actividades.Rows[i]);
                    }

                    gdgvTablaActividades.DataSource = resultTable;
                }
                else
                {
                    string mensaje = $"El usuario {nombreUsuario} no tiene actividades asignadas.";
                    MessageBox.Show(mensaje, "Sin actividades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //Fin//
        //Opciones del combobox//
        private void CargarOpcionesCantidadRegistros()
        {
            cmbCantidadRegistros.Items.Add("5 registros");
            cmbCantidadRegistros.Items.Add("10 registros");
            cmbCantidadRegistros.Items.Add("20 registros");
            cmbCantidadRegistros.SelectedIndex = 0;
        }
        private int ObtenerCantidadRegistrosSeleccionados()
        {
            string cantidadSeleccionada = cmbCantidadRegistros.SelectedItem.ToString();
            int cantidadRegistros;
            if (int.TryParse(cantidadSeleccionada.Split(' ')[0], out cantidadRegistros))
            {
                return cantidadRegistros;
            }
            return int.MaxValue;
        }
        //Fin//


    }
}
