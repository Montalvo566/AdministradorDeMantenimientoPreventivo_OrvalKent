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
            dgvTablaUsuarios.DataSource = verTabla.MostrarUsuarios();
        }
        //Fin//


        //Funcion para agregar registros a la tabla de usuarios//
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                userCrudTabla.InsertarUsuarios(tbCorreo.Text, tbPass.Text, tbNombres.Text, tbApPaterno.Text, tbApMaterno.Text);
                MessageBox.Show("Usuario insertado con exito");
                MostrarUsuariosTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar datos: " +ex);
            }
        }
        //Fin//

    }
}
