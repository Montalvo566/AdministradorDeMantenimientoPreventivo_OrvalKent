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
                            EsOpcionValidaSeleccionada(cmbEstatus, "Estatus"))
                    {
                        crud.IdArea1 = Convert.ToInt32(cmbArea.SelectedValue);
                        crud.IdEquipo1 = Convert.ToInt32(cmbEquipo.SelectedValue);
                        crud.IdFrecuencia1 = Convert.ToInt32(cmbFrecuencia.SelectedValue);
                        crud.Actividad1 = tbActividad.Text;
                        crud.Registro1 = tbRegistro.Text;
                        crud.Estatus1 = Convert.ToInt32(cmbEstatus.SelectedValue);
                        crud.IdUsuarioRegistra1 = Convert.ToInt32(cmbUsuarioRegistra.SelectedValue);
                        crud.IdUsuarioAsignado1 = Convert.ToInt32(cmbUsuarioAsignado.SelectedValue);
                        crud.FechaAsignado1 = dtpFechaAsignacion.Value.ToString("yyyy-MM-dd");
                        crud.Id1 = Convert.ToInt32(idActividad);

                        DateTime fechaFinalizacionActual = crud.ObtenerFechaFinalizacionActual(crud.Id1);

                        if (crud.Estatus1 == 1) // Estado "Terminado"
                        {
                            crud.FechaFinalizacion1 = DateTime.Now;
                        }
                        else
                        {
                            // No actualiza la FechaFinalizacion si no es "Terminado"
                            crud.FechaFinalizacion1 = fechaFinalizacionActual;
                        }

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
        //Fin//
    }
}
