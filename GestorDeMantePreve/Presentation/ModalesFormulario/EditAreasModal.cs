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
    public partial class EditAreasModal : Form
    {
        AreasCrudModel areasCrudTabla = new AreasCrudModel();
        AreasCrud crud = new AreasCrud();
        public string idArea = null;
        public string OperacionEdit = "Editar";

        public EditAreasModal()
        {
            InitializeComponent();
        }


        private void EditAreasModal_Load(object sender, EventArgs e)
        {

        }


        //Funciones para listar los campos del textbox//
        public void ListarDepartamentos()
        {
            AreasCrudModel areasCrudTabla = new AreasCrudModel();
            gcmbDepartamento.DataSource = areasCrudTabla.ListadoDepartamentos();
            gcmbDepartamento.DisplayMember = "Departamento";
            gcmbDepartamento.ValueMember = "Id";
        }
        //Fin//

        //Cerrar formulario modal//
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Fin//


        private void gbtnEditar_Click(object sender, EventArgs e)
        {
            if (OperacionEdit == "Editar")
            {
                try
                {
                    if (EsCampoValido(gtbAreas, "Area") &&
                            EsOpcionValidaSeleccionada(gcmbDepartamento, "Departamento"))
                    {
                        crud.Zona1 = gtbAreas.Text;
                        crud.IdDepartamento1 = Convert.ToInt32(gcmbDepartamento.SelectedValue);
                        crud.Id1 = Convert.ToInt32(idArea);

                        crud.PutAreas();

                        MessageBox.Show("Area actualizada con exito");
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


        //Funcion para limpiar los textbox del formulario//
        private void LimpiarCampos()
        {
            //limpiar campos al ejecutar la accion del boton
            gtbAreas.Clear();
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
