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
    public partial class Areas : Form
    {
        AreasCrud crud = new AreasCrud();

        public Areas()
        {
            InitializeComponent();
        }

        private void Areas_Load(object sender, EventArgs e)
        {
            ListarDepartamentos();
            MostrarAreasTabla();
            ConfigurarDataGridView();
            ValdiacionesTipoCampo();
        }


        //Funcion para mostrar los datos en la tabla de usuarios//
        private void MostrarAreasTabla()
        {
            AreasCrudModel areasCrud = new AreasCrudModel();
            dgvAreasTabla.DataSource = areasCrud.MostrarTablaAreas();
        }
        private void ConfigurarDataGridView()
        {
            dgvAreasTabla.RowTemplate.Height = 50;
        }
        //Fin//


        //Funciones para listar los datos del combobox//
        private void ListarDepartamentos()
        {
            AreasCrudModel areasCrud = new AreasCrudModel();
            gcmbDepartamento.DataSource = areasCrud.ListadoDepartamentos();
            gcmbDepartamento.DisplayMember = "Departamento";
            gcmbDepartamento.ValueMember = "Id";
        }
        //Fin//


        //Funcion para agregar datos a la tabla de Areas//
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (EsCampoValido(gtbArea, "Area") &&
                        EsOpcionValidaSeleccionada(gcmbDepartamento, "Departamento"))
                {
                    crud.Zona1 = gtbArea.Text;
                    crud.IdDepartamento1 = Convert.ToInt32(gcmbDepartamento.SelectedValue);
                    crud.PostAreas();

                    MessageBox.Show("Area registrada con exito");
                    LimpiarCampos();
                    MostrarAreasTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar datos: " + ex);
            }
        }
        //Fin//


        //Funcion parar eliminar datos de la tabla de areas
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAreasTabla.SelectedRows.Count > 0)
            {
                crud.Id1 = Convert.ToInt32(dgvAreasTabla.CurrentRow.Cells[0].Value);
                crud.DeleteAreas();
                MessageBox.Show("Area eliminada con exito");
                LimpiarCampos();
                MostrarAreasTabla();
            }
            else
            {
                MessageBox.Show("Para poder eliminar, seleccione un registro");
            }
        }
        //Fin//


        //Funcion para limpiar los textbox del formulario//
        private void LimpiarCampos()
        {
            //limpiar campos al ejecutar la accion del boton
            gtbArea.Clear();
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
        private void SoloFormatoLetra(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras y espacios
            if ((!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' '))
            {
                e.Handled = true; // Ignora la tecla presionada
            }
        }
        //Fin//

        //Ejecutar las validaciones//
        private void ValdiacionesTipoCampo()
        {
            gtbArea.KeyPress += new KeyPressEventHandler(SoloFormatoLetra);
        }
        //Fin//


    }
}
