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
            gdgvTablaActividades.RowTemplate.Height = 50;
            gdgvTablaActividades.ColumnHeadersHeight = 50;
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


        //Funcion para reestablecer los campos de los filtros//
        private void btnMostrarTareas_Click(object sender, EventArgs e)
        {
            if (gdgvTablaActividades.SelectedRows.Count > 0)
            {
                ModalesFormulario.MostrarActividadesModal modal = new ModalesFormulario.MostrarActividadesModal();
                modal.tbId.Text = gdgvTablaActividades.CurrentRow.Cells[0].Value.ToString();
                modal.tbActividad.Text = gdgvTablaActividades.CurrentRow.Cells["Actividad"].Value.ToString();
                modal.tbArea.Text = gdgvTablaActividades.CurrentRow.Cells["Area"].Value.ToString();
                modal.tbEquipo.Text = gdgvTablaActividades.CurrentRow.Cells["Equipo"].Value.ToString();
                modal.tbFrecuencia.Text = gdgvTablaActividades.CurrentRow.Cells["Frecuencia"].Value.ToString();
                modal.tbRegistro.Text = gdgvTablaActividades.CurrentRow.Cells["Registro"].Value.ToString();
                modal.tbEstatus.Text = gdgvTablaActividades.CurrentRow.Cells["Estatus"].Value.ToString();
                modal.tbUsuarioAsignado.Text = gdgvTablaActividades.CurrentRow.Cells["UsuarioAsignado"].Value.ToString();
                DateTime fechaAsignado = Convert.ToDateTime(gdgvTablaActividades.CurrentRow.Cells["FechaAsignado"].Value);
                modal.tbFechaAsignado.Text = fechaAsignado.ToString("dd/MM/yyyy");
                modal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione el registro para visualizarlo");
            }
        }
        //Fin//


        //Botones para ejecutar la funcion y cancelarla//
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarActividadesPorUsuario();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gdgvTablaActividades.DataSource = tablaOriginal;
            cmbUsuario.SelectedIndex = -1;
            cmbCantidadRegistros.SelectedIndex = 0;
        }
        //Funcion para filtrar los registros//
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
    }
}
