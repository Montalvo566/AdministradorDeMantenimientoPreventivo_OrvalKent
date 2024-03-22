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
            this.Shown += FinalizarTareasModal_Shown;
        }

        private void FinalizarTareasModal_Shown(object sender, EventArgs e)
        {
            tbCodigoSupervisor.Focus();
            this.Focus();
        }

        //Funcion para cerrar la ventana//
        private void btnCerrarModal_Click(object sender, EventArgs e)
        {
            MenuPrincipal formularioPrincipal = this.Owner as MenuPrincipal;
            if (formularioPrincipal != null)
            {
                formularioPrincipal.HabilitarCapturaCodigoBarras(true);
            }
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
                        if (historial.ValidacionActividadesEnRevision())
                        {
                            try
                            {
                                int idUsuario = UserLoginCache.Id;
                                historial.RegistrarEnHistorialEnRevision(idUsuario);
                                MessageBox.Show("Tareas finalizadas con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MenuPrincipal formularioPrincipal = this.Owner as MenuPrincipal;
                                if (formularioPrincipal != null)
                                {
                                    formularioPrincipal.HabilitarCapturaCodigoBarras(true);
                                }
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
