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
using Domain;
using System.Globalization;

namespace Presentation.ModalesFormulario
{
    public partial class EditActividadesModal : Form
    {
        ActivitiesCrud crud = new ActivitiesCrud();
        public string idActividad = null;
        public string OperacionEdit = "Editar";

        public EditActividadesModal()
        {
            InitializeComponent();
        }

        //Cerrar la ventana al presionar el boton//
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Fin//


        //Funciones para listar los datos del combobox//
        public void ListarAreas()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            cmbArea.DataSource = actividad.ListadoAreas();
            cmbArea.DisplayMember = "Zona";
            cmbArea.ValueMember = "Id";
        }

        public void ListarEquipos()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            cmbEquipo.DataSource = actividad.ListadoEquipos();
            cmbEquipo.DisplayMember = "Equipo";
            cmbEquipo.ValueMember = "Id";
        }

        public void ListarFrecuencias()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            cmbFrecuencia.DataSource = actividad.ListadoFrecuencias();
            cmbFrecuencia.DisplayMember = "Frecuencia";
            cmbFrecuencia.ValueMember = "Id";
        }

        public void ListarUsuarioRegistra()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            cmbUsuarioRegistra.DataSource = actividad.ListadoUsuarioRegistra();
            cmbUsuarioRegistra.DisplayMember = "NombreCompleto";
            cmbUsuarioRegistra.ValueMember = "Id";
        }

        public void ListarUsuarioAsignado()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            cmbUsuarioAsignado.DataSource = actividad.ListadoUsuarioAsignado();
            cmbUsuarioAsignado.DisplayMember = "NombreCompleto";
            cmbUsuarioAsignado.ValueMember = "Id";
        }

        public void ListarEstatus()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            cmbEstatus.DataSource = actividad.ListadoEstatus();
            cmbEstatus.DisplayMember = "Estatus";
            cmbEstatus.ValueMember = "Id";
        }
        //Fin//


        //Funcion para editar los campos del formulario//
        private void gbtnEditar_Click(object sender, EventArgs e)
        {
            if (OperacionEdit == "Editar")
            {
                try
                {
                    if (EsCampoValido(tbActividad, "Actividad") &&
                            EsCampoValido(tbRegistro, "Registro") &&
                            EsOpcionValidaSeleccionada(cmbArea, "Area") &&
                            EsOpcionValidaSeleccionada(cmbEquipo, "Equipo") &&
                            EsOpcionValidaSeleccionada(cmbFrecuencia, "Frecuencia") &&
                            EsOpcionValidaSeleccionada(cmbUsuarioRegistra, "Usuario Registra") &&
                            EsOpcionValidaSeleccionada(cmbUsuarioAsignado, "Usuario Asignado") &&
                            EsCampoValido(tbFechaAsignacion, "Fecha de asignación") &&
                            EsCampoValido(tbHoraAsignacion, "Hora de asignación") &&
                            EsOpcionValidaSeleccionada(cmbEstatus, "Estatus")&&
                            EsFormatoFechaValido(tbFechaAsignacion.Text))
                    {
                        crud.IdArea1 = Convert.ToInt32(cmbArea.SelectedValue);
                        crud.IdEquipo1 = Convert.ToInt32(cmbEquipo.SelectedValue);
                        crud.IdFrecuencia1 = Convert.ToInt32(cmbFrecuencia.SelectedValue);
                        crud.Actividad1 = tbActividad.Text;
                        crud.Registro1 = tbRegistro.Text;
                        crud.Estatus1 = Convert.ToInt32(cmbEstatus.SelectedValue);
                        crud.IdUsuarioRegistra1 = Convert.ToInt32(cmbUsuarioRegistra.SelectedValue);
                        crud.IdUsuarioAsignado1 = Convert.ToInt32(cmbUsuarioAsignado.SelectedValue);
                        crud.FechaAsignado1 = tbFechaAsignacion.Text;
                        crud.HoraAsignado1 = tbHoraAsignacion.Text;
                        crud.Id1 = Convert.ToInt32(idActividad);

                        crud.PutActividades();

                        MessageBox.Show("Actividad actualizada con exito");
                        LimpiarCampos();
                        this.Close();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar datos: " + ex);
                }
            }
        }
        //Fin//


        //Funcion para limpiar los textbox del formulario//
        private void LimpiarCampos()
        {
            //limpiar campos al ejecutar la accion del boton
            tbActividad.Clear();
            tbRegistro.Clear();
            tbFechaAsignacion.Clear();
            tbHoraAsignacion.Clear();
        }
        //Fin//

        //Validacion de campos vacios en el formulario y fromato no valido//
        private bool EsCampoValido(Guna.UI.WinForms.GunaTextBox campo, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                MessageBox.Show($"Por favor, coloque el campo {nombreCampo}");
                return false;
            }
            return true;
        }
        private bool EsOpcionValidaSeleccionada(Guna.UI.WinForms.GunaComboBox campo, string nombreCampo)
        {
            if (campo.SelectedIndex == -1)
            {
                MessageBox.Show($"Por favor, seleccione el campo {nombreCampo}");
                return false;
            }
            return true;
        }
        private bool EsFormatoFechaValido(string fecha)
        {
            if (!DateTime.TryParseExact(fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Formato de fecha inválido. Utilizado el formato dd/MM/yyyy");
                return false;
            }
            return true;
        }
        //Fin//


    }
}
