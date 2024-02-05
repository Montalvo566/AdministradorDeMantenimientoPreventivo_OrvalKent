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
    public partial class EditDepartamentosModal : Form
    {
        DepartamentCrudModel depCrudTabla = new DepartamentCrudModel();
        DepartamentCrud crud = new DepartamentCrud();
        public string idDepartamento = null;
        public string OperacionEdit = "Editar";

        public EditDepartamentosModal()
        {
            InitializeComponent();
        }

        private void gbtnEditar_Click(object sender, EventArgs e)
        {
            if (OperacionEdit == "Editar")
            {
                try
                {
                    if (EsCampoValido(gtbDepartamento, "Departamento"))
                    {
                        crud.Departamento1 = gtbDepartamento.Text;
                        crud.Id1 = Convert.ToInt32(idDepartamento);

                        crud.PutDepartamentos();

                        MessageBox.Show("Departamento actualizado con exito");
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


        private void EditDepartamentosModal_Load(object sender, EventArgs e)
        {
            ValdiacionesTipoCampo();
        }


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
