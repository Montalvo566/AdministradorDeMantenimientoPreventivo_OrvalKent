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
using System.Globalization;

namespace Presentation
{
    public partial class Actividades : Form
    {
        ActivitiesCrudModel actividad = new ActivitiesCrudModel();
        ActivitiesCrud crud = new ActivitiesCrud();

        public Actividades()
        {
            InitializeComponent();
        }

        private void Actividades_Load(object sender, EventArgs e)
        {
            ListarAreas();
            ListarEquipos();
            ListarFrecuencias();
            ListarUsuarioRegistra();
            ListarUsuarioAsignado();
            MostrarTablaActividades();
            ConfigurarDataGridView();
        }

        //Funciones para listar los datos del combobox//
        private void ListarAreas()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            cmbArea.DataSource = actividad.ListadoAreas();
            cmbArea.DisplayMember = "Zona";
            cmbArea.ValueMember = "Id";
        }

        private void ListarEquipos()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            cmbEquipo.DataSource = actividad.ListadoEquipos();
            cmbEquipo.DisplayMember = "Equipo";
            cmbEquipo.ValueMember = "Id";
        }

        private void ListarFrecuencias()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            cmbFrecuencia.DataSource = actividad.ListadoFrecuencias();
            cmbFrecuencia.DisplayMember = "Frecuencia";
            cmbFrecuencia.ValueMember = "Id";
        }

        private void ListarUsuarioRegistra()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            cmbUsuarioRegistra.DataSource = actividad.ListadoUsuarioRegistra();
            cmbUsuarioRegistra.DisplayMember = "NombreCompleto";
            cmbUsuarioRegistra.ValueMember = "Id";
        }

        private void ListarUsuarioAsignado()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            cmbUsuarioAsignado.DataSource = actividad.ListadoUsuarioAsignado();
            cmbUsuarioAsignado.DisplayMember = "NombreCompleto";
            cmbUsuarioAsignado.ValueMember = "Id";
        }
        //Fin//


        //Funcion para mostrar los datos en la tabla de Actividades//
        private void MostrarTablaActividades()
        {
            ActivitiesCrudModel actividad = new ActivitiesCrudModel();
            dgvActividadesTabla.DataSource = actividad.MostrarTablaActividades();
        }
        private void ConfigurarDataGridView()
        {
            dgvActividadesTabla.RowTemplate.Height = 50;
        }
        //Fin//


        //Funcion para agregar datos a la tabla de Actividades//
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (EsCampoValido(tbActividad, "Actividad") &&
                        EsCampoValido(tbRegistro, "Registro") &&
                        EsOpcionValidaSeleccionada(cmbArea, "Area") &&
                        EsOpcionValidaSeleccionada(cmbEquipo, "Equipo") &&
                        EsOpcionValidaSeleccionada(cmbFrecuencia, "Frecuencia") &&
                        EsOpcionValidaSeleccionada(cmbUsuarioRegistra, "Usuario Registra") &&
                        EsOpcionValidaSeleccionada(cmbUsuarioAsignado, "Usuario Asignado"))
                {
                    crud.IdArea1 = Convert.ToInt32(cmbArea.SelectedValue);
                    crud.IdEquipo1 = Convert.ToInt32(cmbEquipo.SelectedValue);
                    crud.IdFrecuencia1 = Convert.ToInt32(cmbFrecuencia.SelectedValue);
                    crud.Actividad1 = tbActividad.Text;
                    crud.Registro1 = tbRegistro.Text;
                    crud.IdUsuarioRegistra1 = Convert.ToInt32(cmbUsuarioRegistra.SelectedValue);
                    crud.IdUsuarioAsignado1 = Convert.ToInt32(cmbUsuarioAsignado.SelectedValue);
                    crud.FechaAsignado1 = dtpFechaAsignacion.Value.ToString("yyyy-MM-dd");
                    crud.PostActividades();
                    MessageBox.Show("Usuario registrada con exito");
                    LimpiarCampos();
                    MostrarTablaActividades();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar datos: " + ex);
            }
        }
        //Fin//


        //Funcion para eliminar registros de la tabla de actividades//
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvActividadesTabla.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar la actividad?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    crud.Id1 = Convert.ToInt32(dgvActividadesTabla.CurrentRow.Cells[0].Value);
                    crud.DeleteActividades();
                    MessageBox.Show("Actividad eliminada con exito");
                    LimpiarCampos();
                    MostrarTablaActividades();
                } 
            }
            else
            {
                MessageBox.Show("Para poder eliminar, seleccione un regustro");
            }
        }
        //Fin//


        //Funcion para abri el modal del formulario para poder editar los registros//
        private void btnAbriModalEdit_Click(object sender, EventArgs e)
        {
            if (dgvActividadesTabla.SelectedRows.Count > 0)
            {
                ModalesFormulario.EditActividadesModal modal = new ModalesFormulario.EditActividadesModal();
                modal.OperacionEdit = "Editar";

                //Funcion para listar los combobox//
                modal.ListarAreas();
                modal.ListarEquipos();
                modal.ListarFrecuencias();
                modal.ListarUsuarioRegistra();
                modal.ListarUsuarioAsignado();
                modal.ListarEstatus();
                //Fin//

                //Funcion para cargar los datos en los campos//
                modal.cmbArea.Text = dgvActividadesTabla.CurrentRow.Cells[1].Value.ToString();
                modal.cmbEquipo.Text = dgvActividadesTabla.CurrentRow.Cells[2].Value.ToString();
                modal.cmbFrecuencia.Text = dgvActividadesTabla.CurrentRow.Cells[3].Value.ToString();
                modal.tbActividad.Text = dgvActividadesTabla.CurrentRow.Cells["Actividad"].Value.ToString();
                modal.tbRegistro.Text = dgvActividadesTabla.CurrentRow.Cells["Registro"].Value.ToString();
                modal.cmbEstatus.Text = dgvActividadesTabla.CurrentRow.Cells[6].Value.ToString();
                modal.cmbUsuarioRegistra.Text = dgvActividadesTabla.CurrentRow.Cells[7].Value.ToString();
                modal.cmbUsuarioAsignado.Text = dgvActividadesTabla.CurrentRow.Cells[8].Value.ToString();
                modal.idActividad = dgvActividadesTabla.CurrentRow.Cells["Id"].Value.ToString();
                DateTime fechaAsignado = Convert.ToDateTime(dgvActividadesTabla.CurrentRow.Cells["FechaAsignado"].Value);
                modal.dtpFechaAsignacion.Value = fechaAsignado;
                modal.ShowDialog();
                MostrarTablaActividades();
                //Fin//
            }
            else
            {
                MessageBox.Show("Para modificar, seleccione un registro");
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
