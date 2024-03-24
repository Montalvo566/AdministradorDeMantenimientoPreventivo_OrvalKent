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
        private HistorialDomain historial = new HistorialDomain();
        private DateTime ultimaEntrada = DateTime.MinValue;
        private const int umbralEscaneo = 150; // Milisegundos
        private Timer temporizador;

        public FinalizarTareasModal()
        {
            InitializeComponent();
            this.Load += FinalizarTareasModal_Load;

            //Temporizador
            temporizador = new Timer();
            temporizador.Interval = 150;
            temporizador.Tick += Temporizador_Tick;
        }

        private void FinalizarTareasModal_Load(object sender, EventArgs e)
        {
            tbCodigoSupervisor.Focus();
            temporizador.Start();
        }


        //Temporizador//
        private void Temporizador_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempoTranscurrido = DateTime.Now - ultimaEntrada;
            if (tiempoTranscurrido.TotalMilliseconds > umbralEscaneo)
            {
                tbCodigoSupervisor.Clear();
            }
        }
        //Fin//


        //Funcion del lector de codigo de barras y la finalizacion de las actividades//
        private void tbCodigoSupervisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ultimaEntrada = DateTime.Now;
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
                    MessageBox.Show("Porfavor escanee su codigo de barras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Fin//


        //Funcion para cerrar el formulario//
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal formularioPrincipal = this.Owner as MenuPrincipal;
            if (formularioPrincipal != null)
            {
                formularioPrincipal.HabilitarCapturaCodigoBarras(true);
            }
            this.Close();
        }
        //Fin//


        //Detener el temporizador al cerrar el formulario//
        private void FinalizarTareasModal_FormClosing(object sender, FormClosingEventArgs e)
        {
            temporizador.Stop();
            temporizador.Dispose();
        }
        //Detener el temporizador al cerrar el formulario//
    }
}
