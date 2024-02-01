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
using System.IO;

namespace Presentation
{
    public partial class Usuarios : Form
    {
        UserCrudModel userCrudTabla = new UserCrudModel();
        UserCrud crud = new UserCrud();


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


        //Funcion para seleccionar una archivo//
        private void gbtnSubirImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
                openFileDialog.Title = "Seleccionar imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtén la ruta del archivo seleccionado
                    string rutaImagen = openFileDialog.FileName;

                    // Muestra la ruta en un TextBox u otro control si es necesario
                    gtbFoto.Text = rutaImagen;
                }
            }
        }
        //Funcion paara agregar registros a la tabla de usuarios//
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
                    crud.NombreCompleto1 = gtbNombreCompleto.Text;
                    crud.NumeroTrabajador1 = Convert.ToInt32(gtbNumeroTrabajador.Text);
                    crud.Departamento1 = Convert.ToInt32(gcmbDepartamento.SelectedValue);
                    crud.Area1 = Convert.ToInt32(gcmbArea.SelectedValue);
                    crud.Puesto1 = Convert.ToInt32(gcmbPuesto.SelectedValue);
                    crud.Correo1 = gtbCorreo.Text;
                    crud.Contrasena1 = gtbPassword.Text;

                    // Validar que se haya seleccionado una imagen
                    if (!string.IsNullOrEmpty(gtbFoto.Text) && File.Exists(gtbFoto.Text))
                    {
                        // Obtener la carpeta de la aplicación
                        string carpetaApp = AppDomain.CurrentDomain.BaseDirectory;

                        // Unir la carpeta de la aplicación con la carpeta "ImagenesUsuarios"
                        string carpetaImagenes = Path.Combine(carpetaApp, "ImagenesUsuarios");

                        // Crear la carpeta si no existe
                        if (!Directory.Exists(carpetaImagenes))
                        {
                            Directory.CreateDirectory(carpetaImagenes);
                        }

                        // Guardar la imagen en la carpeta
                        string nombreArchivo = $"{Guid.NewGuid()}.jpg";
                        string rutaImagen = Path.Combine(carpetaImagenes, nombreArchivo);

                        File.Copy(gtbFoto.Text, rutaImagen, true);

                        // Asignar la ruta completa al atributo Foto1
                        crud.Foto1 = rutaImagen;

                        // Llamar a la función para agregar datos a la tabla de usuarios
                        crud.PostUsuarios();

                        MessageBox.Show("Usuario registrado con éxito");
                        LimpiarCampos();
                        MostrarUsuariosTabla();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // No continuar si no hay imagen seleccionada
                    }
                    //Fin//

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar datos: " + ex);
            }
        }
        //Fin//


        //Funcion para seleccionar las filas de la tabla y actualizar los registros de la tabla de usuarios//
        private void btnAbriModalEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsuariosTabla.SelectedRows.Count > 0)
            {
                ModalesFormulario.EditUsuariosModal modal = new ModalesFormulario.EditUsuariosModal();
                modal.OperacionEdit = "Editar";

                //Funcion para listar los combobox//
                modal.ListarDepartamentos();
                modal.ListarPuestos();
                modal.ListarAreas();
                //Fin//

                //Funcion para cargar los datos en los campos//
                modal.gtbNombreCompleto.Text = dgvUsuariosTabla.CurrentRow.Cells["NombreCompleto"].Value.ToString();
                modal.gtbNumeroTrabajador.Text = dgvUsuariosTabla.CurrentRow.Cells["NumeroEmpleado"].Value.ToString();
                modal.gcmbDepartamento.Text = dgvUsuariosTabla.CurrentRow.Cells[3].Value.ToString();
                modal.gcmbArea.Text = dgvUsuariosTabla.CurrentRow.Cells[4].Value.ToString();
                modal.gcmbPuesto.Text = dgvUsuariosTabla.CurrentRow.Cells[5].Value.ToString();
                modal.gtbCorreo.Text = dgvUsuariosTabla.CurrentRow.Cells["Correo"].Value.ToString();
                modal.gtbPassword.Text = dgvUsuariosTabla.CurrentRow.Cells["Contrasena"].Value.ToString();
                modal.gtbFoto.Text = dgvUsuariosTabla.CurrentRow.Cells["Foto"].Value.ToString();
                modal.idUsuario = dgvUsuariosTabla.CurrentRow.Cells["Id"].Value.ToString();
                modal.ShowDialog();
                MostrarUsuariosTabla();
                //Fin//
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
                if (MessageBox.Show("¿Desea eliminar el usuario?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    crud.Id1 = Convert.ToInt32(dgvUsuariosTabla.CurrentRow.Cells[0].Value);
                    crud.DeleteUsuarios();
                    MessageBox.Show("Usuario eliminado con exito");
                    LimpiarCampos();
                    MostrarUsuariosTabla();
                }
                
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
            gtbNumeroTrabajador.KeyPress += new KeyPressEventHandler(SoloFormatoNumero);
            gtbNombreCompleto.KeyPress += new KeyPressEventHandler(SoloFormatoLetra);
        }
        //Fin//


    }
}
