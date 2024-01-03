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

        public Usuarios()
        {
            InitializeComponent();
        }

        //Funcion para mostrar los datos de la tabla de usuarios//
        private void Usuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuariosTabla();
            gbtnGuardarCambios.Enabled = false;
        }
        private void MostrarUsuariosTabla()
        {
            UserCrudModel verTabla = new UserCrudModel();
            gdgvUsuariosTabla.DataSource = verTabla.MostrarUsuarios();
        }
        //Fin//


        //Funcion para agregar registros a la tabla de usuarios//
        private void gbtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                userCrudTabla.InsertarUsuarios(tbCorreo.Text, tbPass.Text, tbNombres.Text, tbApPaterno.Text, tbApMaterno.Text);
                MessageBox.Show("Usuario insertado con exito");
                MostrarUsuariosTabla();

                //limpiar campos al ejecutar la accion del boton
                tbNombres.Clear();
                tbApPaterno.Clear();
                tbApMaterno.Clear();
                tbCorreo.Clear();
                tbPass.Clear();
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
                tbCorreo.Text = gdgvUsuariosTabla.CurrentRow.Cells["Correo"].Value.ToString();
                tbPass.Text = gdgvUsuariosTabla.CurrentRow.Cells["Pass"].Value.ToString();
                tbNombres.Text = gdgvUsuariosTabla.CurrentRow.Cells["Nombres"].Value.ToString();
                tbApPaterno.Text = gdgvUsuariosTabla.CurrentRow.Cells["ApPaterno"].Value.ToString();
                tbApMaterno.Text = gdgvUsuariosTabla.CurrentRow.Cells["ApMaterno"].Value.ToString();
                idUsuario = gdgvUsuariosTabla.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona un registro");
            }
        }
        //Fin//


    }
}
