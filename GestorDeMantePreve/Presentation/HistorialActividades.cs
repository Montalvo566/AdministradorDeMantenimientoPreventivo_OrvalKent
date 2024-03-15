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
        private void HistorialActividades_Load(object sender, EventArgs e)
        {
            CargarHistorialActividades();
        }
        //Fin//


        // Función para cargar el historial de actividades en el ListView
        private void CargarHistorialActividades()
        {
            try
            {
                HistorialDomain historial = new HistorialDomain();
                DataTable tablaHistorial = historial.MostrarHistorialActividades();

                listViewHistorial.Clear();
                listViewHistorial.View = View.Details;

                // Agregar columnas al ListView
                listViewHistorial.Columns.Add("Actividad", 830);               
                listViewHistorial.Columns.Add("Frecuencia", 140);
                listViewHistorial.Columns.Add("Estatus", 140);
                listViewHistorial.Columns.Add("Usuario Asignado", 250);
                listViewHistorial.Columns.Add("Finalización", 240);

                DateTime fechaActual = DateTime.MinValue;
                ListViewGroup grupoActual = null;

                foreach (DataRow fila in tablaHistorial.Rows)
                {
                    DateTime fechaActividad = Convert.ToDateTime(fila["Finalizacion"]).Date;
                    if (fechaActividad != fechaActual)
                    {
                        fechaActual = fechaActividad;
                        grupoActual = new ListViewGroup(fechaActividad.ToString("dd/MM/yyyy"));
                        listViewHistorial.Groups.Add(grupoActual);
                    }
                    ListViewItem item = new ListViewItem(fila["Actividad"].ToString());                
                    item.SubItems.Add(fila["Frecuencia"].ToString());
                    item.SubItems.Add(fila["Estatus"].ToString());
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
    }
}
