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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void clickParaMásInformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe frm = new frmAcercaDe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDeUsuariosVisual frmusu = new frmListaDeUsuariosVisual();
            frmusu.MdiParent = this;
            frmusu.Show();
        }
    }
}
