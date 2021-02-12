using LoginConMatriz.DOMINIO;
using LoginConMatriz.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginConMatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.User = txtUser.Text;
            log.Password = txtPassword.Text;

            ClsLogin clslog = new ClsLogin();

            int variabledeevaluacion = clslog.Acceso(log);

            if (variabledeevaluacion == 1)
            {
                MessageBox.Show("Enter");
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
    }
}
