using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;

namespace Presentation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void cerrarVentana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Funcion para poder mover el formulario por la pantalla implementado a diferentes partes del Login//
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void header1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Fin//


        //Validación del Inicio de Sesión//
        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text != "")
            {
                if(tbPassword.Text != "")
                {
                    UserModel user = new UserModel();
                    var loginValido = user.LoginUser(tbUsuario.Text, tbPassword.Text);

                    //Validacion para abrir el menu principal y cerrar el login
                    if (loginValido == true)
                    {
                        MenuPrincipal menuPrincipal = new MenuPrincipal();
                        menuPrincipal.Show();
                        menuPrincipal.FormClosed += cerrarSesion;//Sobrecargar el evento con la funcion de cerrar sesion
                        this.Hide();
                    }
                    else
                    {
                        errorMensajeLogin("Datos incorrectos, ingreselos otraves");
                        tbPassword.Clear();
                        tbUsuario.Focus();
                    }
                }
                else
                {
                    errorMensajeLogin("Ingresa la contraseña");
                }
            }
            else
            {
                errorMensajeLogin("Ingresa el correo electronico");
            }
        }
        private void errorMensajeLogin(string mensaje)//Mensaje de campos vacios
        {
            lbErrorInicioSesion.Text = mensaje;
            lbErrorInicioSesion.Visible = true;
        }
        //Fin//

        //Función para cerrar la sesión del usuario//
        private void cerrarSesion(object sender, FormClosedEventArgs e)
        {
            tbUsuario.Clear();
            tbUsuario.Focus();
            tbPassword.Clear();
            lbErrorInicioSesion.Visible = false;
            this.Show();
        }
        //Fin//
        
    }
}
