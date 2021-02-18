using CarlosB01.DOMINIO;
using CarlosB01.NEGOCIO;
using CarlosB01.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlosB01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Usuario = txtUser.Text;
            log.Password = txtPassword.Text;

            ClsLogin clslog = new ClsLogin();
            frmMenu menu = new frmMenu();

            int variabledeevaluacion = clslog.accesoBidimecional(log);


            if ( variabledeevaluacion == 1)
            {
                MessageBox.Show("Enter");
                this.Dispose(false);
                //this.hide solo oculta el formulario y el dispose trabaja con la ram
                //limpia el espacio y basicamente desaparece el formulario de la ram.
                //en pocas palabras lo cierra por completo
                menu.Show();

            }
            else {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
