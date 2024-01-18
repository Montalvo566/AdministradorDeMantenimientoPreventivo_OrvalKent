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
    public partial class Equipos : Form
    {
        EquiposCrudModel equiposCrudTabla = new EquiposCrudModel();
        EquiposCrud crud = new EquiposCrud();

        public Equipos()
        {
            InitializeComponent();
        }

        private void Equipos_Load(object sender, EventArgs e)
        {
            ListarAreas();
            MostrarEquiposTabla();
            ConfigurarDataGridView();
            ValdiacionesTipoCampo();
        }


        //Funcion para mostrar los datos en la tabla de usuarios//
        private void MostrarEquiposTabla()
        {
            EquiposCrudModel equiposCrudTabla = new EquiposCrudModel();
            dgvEquiposTabla.DataSource = equiposCrudTabla.MostrarTablaEquipos();
        }
        private void ConfigurarDataGridView()
        {
            dgvEquiposTabla.RowTemplate.Height = 50;
        }
        //Fin//


        //Funciones para listar los datos del combobox//
        private void ListarAreas()
        {
            EquiposCrudModel equiposCrudTabla = new EquiposCrudModel();
            gcmbArea.DataSource = equiposCrudTabla.ListadoAreas();
            gcmbArea.DisplayMember = "Zona";
            gcmbArea.ValueMember = "Id";
        }
        //Fin//


        //Funcion para agregar registros a la tabla de equipos//
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (EsCampoValido(gtbEquipo, "Equipos") &&
                    EsCampoValido(gtbNumeroEquipo, "Numero de equipo") &&
                    EsOpcionValidaSeleccionada(gcmbArea, "Area"))
                {
                    crud.Equipo1 = gtbEquipo.Text;
                    crud.NumeroEquipo1 = Convert.ToInt32(gtbNumeroEquipo.Text);
                    crud.IdArea1 = Convert.ToInt32(gcmbArea.SelectedValue);
                    crud.PostEquipos();

                    MessageBox.Show("Equipo registrado con exito");
                    LimpiarCampos();
                    MostrarEquiposTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar datos: " + ex);
            }
        }
        //Fin//


        //Funcion para abrir el formulario para editar los equipos//
        private void btnAbriModalEdit_Click(object sender, EventArgs e)
        {
            if (dgvEquiposTabla.SelectedRows.Count > 0)
            {
                ModalesFormulario.EditEquiposModal modal = new ModalesFormulario.EditEquiposModal();
                modal.OperacionEdit = "Editar";

                //Funcion para listar los combobox//
                modal.ListarAreas();
                //Fin//

                //Funcion para cargar los datos en los campos//
                modal.gtbEquipo.Text = dgvEquiposTabla.CurrentRow.Cells[1].Value.ToString();
                modal.gtbNumeroEquipo.Text = dgvEquiposTabla.CurrentRow.Cells[2].Value.ToString();
                modal.gcmbArea.Text = dgvEquiposTabla.CurrentRow.Cells[3].Value.ToString();
                modal.idEquipo = dgvEquiposTabla.CurrentRow.Cells[0].Value.ToString();
                modal.ShowDialog();
                MostrarEquiposTabla();
                //Fin//
            }
            else
            {
                MessageBox.Show("Para modificar, seleccione un registro");
            }
        }
        //Fin//


        //Funcion para eliminar registros de la tablas de equipos//
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEquiposTabla.SelectedRows.Count > 0)
            {
                crud.Id1 = Convert.ToInt32(dgvEquiposTabla.CurrentRow.Cells[0].Value);
                crud.DeleteEquipos();
                MessageBox.Show("Equipo eliminado con exito");
                LimpiarCampos();
                MostrarEquiposTabla();
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
            gtbEquipo.Clear();
            gtbNumeroEquipo.Clear();
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
        private void SoloFormatoNumero(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y la tecla de retroceso (backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Ignora la tecla presionada
            }
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
            gtbEquipo.KeyPress += new KeyPressEventHandler(SoloFormatoLetra);
            gtbNumeroEquipo.KeyPress += new KeyPressEventHandler(SoloFormatoNumero);
        }
        //Fin//


    }
}
