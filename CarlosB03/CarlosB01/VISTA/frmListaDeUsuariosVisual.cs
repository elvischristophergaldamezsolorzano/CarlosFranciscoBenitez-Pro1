using CarlosB01.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlosB01.VISTA
{
    public partial class frmListaDeUsuariosVisual : Form
    {
        public frmListaDeUsuariosVisual()
        {
            InitializeComponent();
        }

        private void frmListaDeUsuariosVisual_Load(object sender, EventArgs e)
        {
            ClsListaUsuarios cls = new ClsListaUsuarios();
            foreach(var iteracion in cls.Users)
            {
                dataGridView1.Rows.Add(iteracion.ToString());
            }
        }
    }
}
