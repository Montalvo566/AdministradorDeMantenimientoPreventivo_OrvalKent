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
        private DataTable tablaOriginal;

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
            tablaOriginal = (DataTable)gdgvTablaActividades.DataSource;
        }


        //Funcion para mostrar los datos en la tabla de Actividades//
        private void MostrarTablaActividades()
        {
            TareasAsignadasModel actividad = new TareasAsignadasModel();
            gdgvTablaActividades.DataSource = actividad.MostrarTablaActividades();
        }
        private void ConfigurarDataGridView()
        {
            gdgvTablaActividades.RowTemplate.Height = 40;
            gdgvTablaActividades.ColumnHeadersHeight = 40;
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

                    if (cantidadRegistros > 0)
                    {
                        DataTable resultTable = actividades.Clone();

                        for (int i = 0; i < Math.Min(cantidadRegistros, actividades.Rows.Count); i++)
                        {
                            resultTable.ImportRow(actividades.Rows[i]);
                        }

                        gdgvTablaActividades.DataSource = resultTable;
                    }
                    else
                    {
                        gdgvTablaActividades.DataSource = actividades;
                    }
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
            cmbCantidadRegistros.Items.Add("Seleccionar cantidad de registros");
            cmbCantidadRegistros.Items.Add("5 registros");
            cmbCantidadRegistros.Items.Add("10 registros");
            cmbCantidadRegistros.Items.Add("15 registros");
            cmbCantidadRegistros.Items.Add("20 registros");
            cmbCantidadRegistros.Items.Add("25 registros");
            cmbCantidadRegistros.Items.Add("30 registros");
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


        //Funcion para reestablecer los campos de los filtros//
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gdgvTablaActividades.DataSource = tablaOriginal;
            cmbUsuario.SelectedIndex = -1;
            cmbCantidadRegistros.SelectedIndex = 0;
        }
        //Fin//


    }
}
