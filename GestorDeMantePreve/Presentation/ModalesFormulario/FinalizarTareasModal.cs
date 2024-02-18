using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Common.Cache;
using Domain;

namespace Presentation.ModalesFormulario
{
    public partial class FinalizarTareasModal : Form
    {
        HistorialDomain historial = new HistorialDomain();

        public FinalizarTareasModal()
        {
            InitializeComponent();
        }

        //Funcion para cerrar la ventana//
        private void btnCerrarModal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Fin//


        //Funcion para cambiar el estado de las actividades y hacer el historial//
        private void tbCodigoSupervisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string codigoBarras = tbCodigoSupervisor.Text;
                if (int.TryParse(codigoBarras, out int numeroEmpleado))
                {
                    int puesto = historial.ObtenerPuestoPorNumeroEmpleado(numeroEmpleado);
                    if (puesto == UserPermissions.Supervisor)
                    {
                        // Verificar si hay actividades en revisión
                        if (historial.ValidacionActividadesEnRevision())
                        {
                            try
                            {
                                // Obtener el Id del usuario actual
                                int idUsuario = UserLoginCache.Id;

                                // Llamar a la función de la capa de dominio pasando el Id del usuario
                                historial.RegistrarEnHistorialEnRevision(idUsuario);

                                MessageBox.Show("Tareas finalizadas con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al intentar registrar en historial: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No hay actividades en revisión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usted no tiene los permisos necesarios para realizar esta acción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    tbCodigoSupervisor.Text = "";
                }
                else
                {
                    MessageBox.Show("Código de barras no válido. Por favor, escanee un código válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Fin//
    }
}
