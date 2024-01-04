﻿using System;
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
            MostrarUsuariosTabla();
        }
        private void MostrarUsuariosTabla()
        {
            UserCrudModel verTabla = new UserCrudModel();
            gdgvUsuariosTabla.DataSource = verTabla.MostrarUsuarios();
        }
        //Fin//


        //Boton para guadar los cambios al momento de ejecutar la funcion de PUT y DELETE//
        private void gbtnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (Editar == true)
            {
                try
                {
                    if (EsCampoValido(tbNombres, "Nombre completo") &&
                    EsCampoValido(tbApPaterno, "Apellido paterno") &&
                    EsCampoValido(tbApMaterno, "Apellido materno") &&
                    EsCampoValido(tbCorreo, "Correo electronico") &&
                    EsCampoValido(tbPass, "Contraseña"))
                    {
                        userCrudTabla.ActualizarUsuarios(tbCorreo.Text, tbPass.Text, tbNombres.Text, tbApPaterno.Text, tbApMaterno.Text, idUsuario);
                        MessageBox.Show("Usuario actualizado con exito");
                        MostrarUsuariosTabla();

                        //limpiar campos al ejecutar la accion del boton
                        LimpiarCampos();
                        Editar = false;
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
        private void gbtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (EsCampoValido(tbNombres, "Nombre completo") &&
                    EsCampoValido(tbApPaterno, "Apellido paterno") &&
                    EsCampoValido(tbApMaterno, "Apellido materno") &&
                    EsCampoValido(tbCorreo, "Correo electronico") &&
                    EsCampoValido(tbPass, "Contraseña"))
                {
                    userCrudTabla.InsertarUsuarios(tbCorreo.Text, tbPass.Text, tbNombres.Text, tbApPaterno.Text, tbApMaterno.Text);
                    MessageBox.Show("Usuario insertado con éxito");
                    MostrarUsuariosTabla();

                    // Limpiar campos al ejecutar la acción del botón
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar datos: " + ex);
            }
        }
        //Fin//


        //Funcion para actualizar los registros de la tabla de usuarios//
        private void gbtnEditar_Click(object sender, EventArgs e)
        {
            if (gdgvUsuariosTabla.SelectedRows.Count > 0)
            {
                Editar = true;

                tbCorreo.Text = gdgvUsuariosTabla.CurrentRow.Cells["Correo"].Value.ToString();
                tbPass.Text = gdgvUsuariosTabla.CurrentRow.Cells["Pass"].Value.ToString();
                tbNombres.Text = gdgvUsuariosTabla.CurrentRow.Cells["Nombres"].Value.ToString();
                tbApPaterno.Text = gdgvUsuariosTabla.CurrentRow.Cells["ApPaterno"].Value.ToString();
                tbApMaterno.Text = gdgvUsuariosTabla.CurrentRow.Cells["ApMaterno"].Value.ToString();
                idUsuario = gdgvUsuariosTabla.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Para modificar, seleccione un registro");
            }
        }
        //Fin//


        //Funcion para eliminar campos de la tabla de usuarios//
        private void gbtnEliminar_Click(object sender, EventArgs e)
        {
            if (gdgvUsuariosTabla.SelectedRows.Count > 0)
            {
                idUsuario = gdgvUsuariosTabla.CurrentRow.Cells["Id"].Value.ToString();
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
            tbNombres.Clear();
            tbApPaterno.Clear();
            tbApMaterno.Clear();
            tbCorreo.Clear();
            tbPass.Clear();
        }
        //Fin//


        //Validacion de campos vacios en el formulario//
        private bool EsCampoValido(Guna.UI2.WinForms.Guna2TextBox campo, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                MessageBox.Show($"Por favor, coloque el campo {nombreCampo}");
                return false;
            }
            return true;
        }
        //Fin//

    }
}
