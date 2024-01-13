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

namespace Presentation
{
    public partial class Usuarios : Form
    {
        UserCrudModel userCrudTabla = new UserCrudModel();
        private string idUsuario = null;//Variable para almacenar el id al editar y eliminar
        private bool Editar = false;

        public Usuarios()
        {
            InitializeComponent();
        }
        
        //Funcion para mostrar los datos de la tabla de usuarios//
        private void Usuarios_Load(object sender, EventArgs e)
        {
            ListarDepartamentos();
            ListarAreas();
            ListarPuestos();
            MostrarUsuariosTabla();
            ConfigurarDataGridView();
            ValdiacionesTipoCampo();
        }
        private void MostrarUsuariosTabla()
        {
            UserCrudModel userCrudTabla = new UserCrudModel();
            dgvUsuariosTabla.DataSource = userCrudTabla.MostrarTablaUsuarios();
        }
        private void ConfigurarDataGridView()
        {
            dgvUsuariosTabla.RowTemplate.Height = 50;
        }
        //Fin//


        //Funciones para listar los campos del textbox//
        private void ListarDepartamentos()
        {
            UserCrudModel userCrudTabla = new UserCrudModel();
            gcmbDepartamento.DataSource = userCrudTabla.ListadoDepartamentos();
            gcmbDepartamento.DisplayMember = "Departamento";
            gcmbDepartamento.ValueMember = "Id";
        }
        private void ListarAreas()
        {
            UserCrudModel userCrudTabla = new UserCrudModel();
            gcmbArea.DataSource = userCrudTabla.ListadoAreas();
            gcmbArea.DisplayMember = "Zona";
            gcmbArea.ValueMember = "Id";
        }
        private void ListarPuestos()
        {
            UserCrudModel userCrudTabla = new UserCrudModel();
            gcmbPuesto.DataSource = userCrudTabla.ListadoPuestos();
            gcmbPuesto.DisplayMember = "Puesto";
            gcmbPuesto.ValueMember = "Id";
        }
        //Fin//


        //Boton para guadar los cambios al momento de ejecutar la funcion de PUT//
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (Editar == true)
            {
                try
                {
                    if (EsCampoValido(gtbNumeroTrabajador, "Numero de trabajador") && 
                        EsCampoValido(gtbNombreCompleto, "Nombre completo") &&
                        EsOpcionValidaSeleccionada(gcmbDepartamento, "Departamento")&&
                        EsOpcionValidaSeleccionada(gcmbArea, "Area")&&
                        EsOpcionValidaSeleccionada(gcmbPuesto, "Puesto")&&
                        EsCampoValido(gtbCorreo, "Correo electronico")&&
                        EsCampoValido(gtbPassword, "Contraseña")&&
                        EsCampoValido(gtbFoto, "Foto"))
                    {

                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar el registro: " + ex);
                }
            }
        }
        //FIN//


        //Funcion para agregar registros a la tabla de usuarios//
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (EsCampoValido(gtbNumeroTrabajador, "Numero de trabajador") &&
                        EsCampoValido(gtbNombreCompleto, "Nombre completo") &&
                        EsOpcionValidaSeleccionada(gcmbDepartamento, "Departamento") &&
                        EsOpcionValidaSeleccionada(gcmbArea, "Area") &&
                        EsOpcionValidaSeleccionada(gcmbPuesto, "Puesto") &&
                        EsCampoValido(gtbCorreo, "Correo electronico") &&
                        EsCampoValido(gtbPassword, "Contraseña") &&
                        EsCampoValido(gtbFoto, "Foto"))
                {
                    userCrudTabla.InsertarUsuarios(gtbNombreCompleto.Text, Convert.ToInt32(gtbNumeroTrabajador.Text), Convert.ToInt32(gcmbDepartamento.SelectedValue),
                    Convert.ToInt32(gcmbArea.SelectedValue), Convert.ToInt32(gcmbPuesto.SelectedValue), gtbCorreo.Text, gtbPassword.Text, gtbFoto.Text);
                    MessageBox.Show("Usuario registrado con exito");
                    LimpiarCampos();
                    MostrarUsuariosTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar datos: " + ex);
            }
        }
        //Fin//


        //Funcion para actualizar los registros de la tabla de usuarios//
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuariosTabla.SelectedRows.Count > 0)
            {
                Editar = true;

                gtbNombreCompleto.Text = dgvUsuariosTabla.CurrentRow.Cells["NombreCompleto"].Value.ToString();
                gtbNumeroTrabajador.Text = dgvUsuariosTabla.CurrentRow.Cells["NumeroEmpleado"].Value.ToString();
                gcmbDepartamento.Text = dgvUsuariosTabla.CurrentRow.Cells["IdDepartamento"].Value.ToString();
                gcmbArea.Text = dgvUsuariosTabla.CurrentRow.Cells["IdZonaAcceso"].Value.ToString();
                gcmbPuesto.Text = dgvUsuariosTabla.CurrentRow.Cells["IdPuesto"].Value.ToString();
                gtbCorreo.Text = dgvUsuariosTabla.CurrentRow.Cells["Correo"].Value.ToString();
                gtbPassword.Text = dgvUsuariosTabla.CurrentRow.Cells["Contrasena"].Value.ToString();
                gtbFoto.Text = dgvUsuariosTabla.CurrentRow.Cells["Foto"].Value.ToString();
                idUsuario = dgvUsuariosTabla.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Para modificar, seleccione un registro");
            }
        }
        //Fin//


        //Funcion para eliminar campos de la tabla de usuarios//
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuariosTabla.SelectedRows.Count > 0)
            {
                idUsuario = dgvUsuariosTabla.CurrentRow.Cells["Id"].Value.ToString();
                userCrudTabla.EliminarUsuarios(idUsuario);
                MessageBox.Show("Usuario eliminado con exito");
                LimpiarCampos();
                MostrarUsuariosTabla();
            }
            else
            {
                MessageBox.Show("Para poder eliminar, seleccione un regustro");
            }
        }
        //Fin//

        //Funcion para limpiar los textbox del formulario//
        private void LimpiarCampos()
        {
            //limpiar campos al ejecutar la accion del boton
            gtbNumeroTrabajador.Clear();
            gtbNombreCompleto.Clear();
            gtbCorreo.Clear();
            gtbPassword.Clear();
            gtbFoto.Clear();
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
            // Permite solo números y la tecla de retroceso (backspace)
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Ignora la tecla presionada
            }
        }
        //Fin//


        //Ejecutar las validaciones//
        private void ValdiacionesTipoCampo()
        {
            gtbNumeroTrabajador.KeyPress += new KeyPressEventHandler(SoloFormatoNumero);
            gtbNombreCompleto.KeyPress += new KeyPressEventHandler(SoloFormatoLetra);
        }
        //Fin//


    }
}
