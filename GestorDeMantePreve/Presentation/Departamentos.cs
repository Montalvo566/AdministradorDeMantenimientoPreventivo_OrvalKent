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
    public partial class Departamentos : Form
    {
        DepartamentCrudModel depCrudTabla = new DepartamentCrudModel();
        DepartamentCrud crud = new DepartamentCrud();

        public Departamentos()
        {
            InitializeComponent();
        }

        private void Departamentos_Load(object sender, EventArgs e)
        {
            ListarAreas();
            MostrarDepartamentosTabla();
            ConfigurarDataGridView();
            ValdiacionesTipoCampo();
        }


        //Funcion para mostrar los datos en la tabla de usuarios//
        private void MostrarDepartamentosTabla()
        {
            DepartamentCrudModel depCrudTabla = new DepartamentCrudModel();
            dgvDepartamentosTabla.DataSource = depCrudTabla.MostrarTablaDep();
        }
        private void ConfigurarDataGridView()
        {
            dgvDepartamentosTabla.RowTemplate.Height = 50;
        }
        //Fin//


        //Funciones para listar los datos del combobox//
        private void ListarAreas()
        {
            DepartamentCrudModel depCrudTabla = new DepartamentCrudModel();
            gcmbArea.DataSource = depCrudTabla.ListadoAreas();
            gcmbArea.DisplayMember = "Zona";
            gcmbArea.ValueMember = "Id";
        }
        //Fin//


        //Funcion agregar registros a la tablas de departamentos//
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (EsCampoValido(gtbDepartamento, "Departamento") &&
                        EsOpcionValidaSeleccionada(gcmbArea, "Area"))
                {
                    crud.Departamento1 = gtbDepartamento.Text;
                    crud.IdZonaAcceso1 = Convert.ToInt32(gcmbArea.SelectedValue);
                    crud.PostDepartamentos();

                    MessageBox.Show("Departamento registrado con exito");
                    LimpiarCampos();
                    MostrarDepartamentosTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar datos: " + ex);
            }
        }
        //Fin//


        //Funcion para eliminar registros de la tabla de departamentos//
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDepartamentosTabla.SelectedRows.Count > 0)
            {
                crud.Id1 = Convert.ToInt32(dgvDepartamentosTabla.CurrentRow.Cells[0].Value);
                crud.DeleteDepartamentos();
                MessageBox.Show("Departamento eliminado con exito");
                LimpiarCampos();
                MostrarDepartamentosTabla();
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
            gtbDepartamento.Clear();
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
            gtbDepartamento.KeyPress += new KeyPressEventHandler(SoloFormatoLetra);
        }
        //Fin//


    }
}
