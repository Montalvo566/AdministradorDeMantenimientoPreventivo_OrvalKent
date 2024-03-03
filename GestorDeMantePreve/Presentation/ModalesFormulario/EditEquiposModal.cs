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

namespace Presentation.ModalesFormulario
{
    public partial class EditEquiposModal : Form
    {
        EquiposCrudModel areasCrudTabla = new EquiposCrudModel();
        EquiposCrud crud = new EquiposCrud();
        public string idEquipo = null;
        public string OperacionEdit = "Editar";

        public EditEquiposModal()
        {
            InitializeComponent();
        }


        private void EditEquiposModal_Load(object sender, EventArgs e)
        {
            ValdiacionesTipoCampo();
        }


        private void gbtnEditar_Click(object sender, EventArgs e)
        {
            if (OperacionEdit == "Editar")
            {
                try
                {
                    if (EsCampoValido(gtbEquipo, "Equipo") &&
                            EsCampoValido(gtbNumeroEquipo, "Numero de equipo") &&
                            EsOpcionValidaSeleccionada(gcmbArea, "Area"))
                    {
                        crud.Equipo1 = gtbEquipo.Text;
                        crud.NumeroEquipo1 = Convert.ToInt32(gtbNumeroEquipo.Text);
                        crud.IdArea1 = Convert.ToInt32(gcmbArea.SelectedValue);
                        crud.Id1 = Convert.ToInt32(idEquipo);

                        crud.PutEquipos();

                        MessageBox.Show("Equipo actualizado con exito");
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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Funciones para listar los datos del combobox//
        public void ListarAreas()
        {
            EquiposCrudModel equiposCrudTabla = new EquiposCrudModel();
            gcmbArea.DataSource = equiposCrudTabla.ListadoAreas();
            gcmbArea.DisplayMember = "Zona";
            gcmbArea.ValueMember = "Id";
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
        //Fin//

        //Ejecutar las validaciones//
        private void ValdiacionesTipoCampo()
        {
            gtbNumeroEquipo.KeyPress += new KeyPressEventHandler(SoloFormatoNumero);
        }
        //Fin//

    }
}
