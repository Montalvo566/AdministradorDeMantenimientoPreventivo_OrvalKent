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
        private DataTable tablaOriginal;
        HistorialDomain historialCarga = new HistorialDomain();

        public HistorialActividades()
        {
            InitializeComponent();
        }


        //Funcion para listar los combobox//
        private void ListarUsuarios()
        {
            TareasAsignadasModel actividad = new TareasAsignadasModel();
            cmbUsuario.DataSource = actividad.ListadoUsuarios();
            cmbUsuario.DisplayMember = "NombreCompleto";
            cmbUsuario.ValueMember = "Id";
        }
        //Fin//


        //Funcion para mostrar el historial de Actividades//
        private void HistorialActividades_Load(object sender, EventArgs e)
        {
            CargarHistorialActividades();
            ListarUsuarios();
            tablaOriginal = historialCarga.MostrarHistorialActividades().Copy();
        }
        //Fin//


        // Función para cargar el historial de actividades en el ListView
        private void CargarHistorialActividades()
        {
            try
            {
                HistorialDomain historial = new HistorialDomain();
                DataTable tablaHistorial = historial.MostrarHistorialActividades();

                // Ordenar la tabla por la columna de FechaFinalizacion de forma descendente
                DataView dv = tablaHistorial.DefaultView;
                dv.Sort = "Finalizacion DESC";
                DataTable tablaOrdenada = dv.ToTable();
                listViewHistorial.Clear();
                listViewHistorial.View = View.Details;
                listViewHistorial.HeaderStyle = ColumnHeaderStyle.None;

                // Agregar columnas al ListView
                listViewHistorial.Columns.Add("Id", 50);
                listViewHistorial.Columns.Add("Actividad", 840);
                listViewHistorial.Columns.Add("Frecuencia", 120);
                listViewHistorial.Columns.Add("Estatus", 120);
                listViewHistorial.Columns.Add("Area", 120);
                listViewHistorial.Columns.Add("Equipo", 120);
                listViewHistorial.Columns.Add("Usuario Asignado", 120);
                listViewHistorial.Columns.Add("Finalización", 120);

                DateTime fechaActual = DateTime.MinValue;
                ListViewGroup grupoActual = null;

                foreach (DataRow fila in tablaOrdenada.Rows)
                {
                    DateTime fechaActividad = Convert.ToDateTime(fila["Finalizacion"]).Date;
                    if (fechaActividad != fechaActual)
                    {
                        fechaActual = fechaActividad;
                        grupoActual = new ListViewGroup(fechaActividad.ToString("dd/MM/yyyy"));
                        listViewHistorial.Groups.Add(grupoActual);
                    }
                    ListViewItem item = new ListViewItem(fila["Id"].ToString());
                    item.SubItems.Add(fila["Actividad"].ToString());
                    item.SubItems.Add(fila["Frecuencia"].ToString());
                    item.SubItems.Add(fila["Estatus"].ToString());
                    item.SubItems.Add(fila["Area"].ToString());
                    item.SubItems.Add(fila["Equipo"].ToString());
                    item.SubItems.Add(fila["UsuarioAsignado"].ToString());
                    item.SubItems.Add(fila["Finalizacion"].ToString());
                    item.Group = grupoActual;

                    listViewHistorial.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial de actividades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Fin//


        //Funcion para ver los detalles del historial//
        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            if (listViewHistorial.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewHistorial.SelectedItems[0];

                ModalesFormulario.MostrarHistorial modal = new ModalesFormulario.MostrarHistorial();
                modal.tbId.Text = selectedItem.SubItems[0].Text;
                modal.tbActividad.Text = selectedItem.SubItems[1].Text;
                modal.tbFrecuencia.Text = selectedItem.SubItems[2].Text;
                modal.tbArea.Text = selectedItem.SubItems[4].Text;
                modal.tbEquipo.Text = selectedItem.SubItems[5].Text;
                modal.tbUsuarioAsignado.Text = selectedItem.SubItems[6].Text;
                modal.tbFinalizacion.Text = selectedItem.SubItems[7].Text;
                modal.tbEstatus.Text = selectedItem.SubItems[3].Text;

                modal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione el registro para visualizarlo");
            }
        }
        //Fin//


        //Funcion para filtrar los registros//
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarActividadesPorUsuario();
        }

        private void FiltrarActividadesPorUsuario()
        {
            if (cmbUsuario.SelectedValue != null)
            {
                int idUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);

                try
                {
                    HistorialDomain historial = new HistorialDomain();
                    DataTable tablaHistorial = historial.FiltroActividadesUsuarios(idUsuario);

                    // Ordenar la tabla filtrada por la columna de FechaFinalizacion de forma descendente
                    DataView dv = tablaHistorial.DefaultView;
                    dv.Sort = "Finalizacion DESC";
                    DataTable tablaOrdenada = dv.ToTable();

                    listViewHistorial.Items.Clear();
                    DateTime fechaActual = DateTime.MinValue;
                    ListViewGroup grupoActual = null;

                    foreach (DataRow fila in tablaOrdenada.Rows)
                    {
                        DateTime fechaActividad = Convert.ToDateTime(fila["Finalizacion"]).Date;
                        if (fechaActividad != fechaActual)
                        {
                            fechaActual = fechaActividad;
                            grupoActual = new ListViewGroup(fechaActividad.ToString("dd/MM/yyyy"));
                            listViewHistorial.Groups.Add(grupoActual);
                        }
                        ListViewItem item = new ListViewItem(fila["Id"].ToString());
                        item.SubItems.Add(fila["Actividad"].ToString());
                        item.SubItems.Add(fila["Frecuencia"].ToString());
                        item.SubItems.Add(fila["Estatus"].ToString());
                        item.SubItems.Add(fila["Area"].ToString());
                        item.SubItems.Add(fila["Equipo"].ToString());
                        item.SubItems.Add(fila["UsuarioAsignado"].ToString());
                        item.SubItems.Add(fila["Finalizacion"].ToString());
                        item.Group = grupoActual;
                        listViewHistorial.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al filtrar el historial de actividades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Fin//


        //Funcion para resetaer el filtro del historial//
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CargarHistorialActividades();
        }
        //Fin//
    }
}
