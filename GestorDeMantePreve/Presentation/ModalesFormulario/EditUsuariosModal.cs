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

namespace Presentation.ModalesFormulario
{
    public partial class EditUsuariosModal : Form
    {
        UserCrudModel userCrudTabla = new UserCrudModel();
        UserCrud crud = new UserCrud();
        public string idUsuario = null;
        public string OperacionEdit = "Editar";
        public DataGridView DgvUsuariosTabla { get; set; }

        public EditUsuariosModal()
        {
            InitializeComponent();
        }

        //Funciones del formuario cerrar//
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Fin//


        private void EditUsuariosModal_Load(object sender, EventArgs e)
        {
            ValdiacionesTipoCampo();
        }
        

        //Funciones para listar los campos del textbox//
        public void ListarDepartamentos()
        {
            UserCrudModel userCrudTabla = new UserCrudModel();
            gcmbDepartamento.DataSource = userCrudTabla.ListadoDepartamentos();
            gcmbDepartamento.DisplayMember = "Departamento";
            gcmbDepartamento.ValueMember = "Id";
        }
        public void ListarAreas()
        {
            UserCrudModel userCrudTabla = new UserCrudModel();
            gcmbArea.DataSource = userCrudTabla.ListadoAreas();
            gcmbArea.DisplayMember = "Zona";
            gcmbArea.ValueMember = "Id";
        }
        public void ListarPuestos()
        {
            UserCrudModel userCrudTabla = new UserCrudModel();
            gcmbPuesto.DataSource = userCrudTabla.ListadoPuestos();
            gcmbPuesto.DisplayMember = "Puesto";
            gcmbPuesto.ValueMember = "Id";
        }
        //Fin//


        //Funcion para seleccionar el archivo//
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
        //Funcion para editar los campos de la tabla de usuarios//
        private void gbtnEditar_Click(object sender, EventArgs e)
        {
           if (OperacionEdit == "Editar")
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
                        crud.Foto1 = gtbFoto.Text;
                        crud.Id1 = Convert.ToInt32(idUsuario);

                        // Validar que se haya seleccionado una imagen
                        if (!string.IsNullOrEmpty(gtbFoto.Text) && File.Exists(gtbFoto.Text))
                        {
                            string carpetaApp = AppDomain.CurrentDomain.BaseDirectory;
                            string carpetaImagenes = Path.Combine(carpetaApp, "ImagenesUsuarios");
                            if (!Directory.Exists(carpetaImagenes))
                            {
                                Directory.CreateDirectory(carpetaImagenes);
                            }
                            string nombreArchivo = $"{Guid.NewGuid()}.jpg";
                            string rutaImagen = Path.Combine(carpetaImagenes, nombreArchivo);
                            File.Copy(gtbFoto.Text, rutaImagen, true);
                            crud.Foto1 = rutaImagen;
                            string fotoPath = DgvUsuariosTabla.CurrentRow.Cells["Foto"].Value.ToString();
                            crud.PutUsuarios(fotoPath);
                            MessageBox.Show("Usuario actualizado con exito");
                            LimpiarCampos();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, seleccione una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar el registro: " + ex);
                }
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
                e.Handled = true;
            }
        }
        private void SoloFormatoLetra(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras y espacios
            if ((!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' '))
            {
                e.Handled = true;
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
