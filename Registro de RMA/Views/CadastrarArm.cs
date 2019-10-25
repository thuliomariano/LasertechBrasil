using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_RMA.Views
{
    public partial class CadastrarArm : Form
    {
        public CadastrarArm()
        {
            InitializeComponent();
        }

        private void btnCopiarPatrimonio_Click(object sender, EventArgs e)
        {
            txtVersaoAtualizadaPatrimonio.Text = txtPatrimonioArm.Text;
        }

        private void btnCopiarWindowsCe_Click(object sender, EventArgs e)
        {
            txtVersaoAtualizadoWindowsCe.Text = txtVersaoAtualWindowsCe.Text;
        }

        private void btnCopiarBootLoader_Click(object sender, EventArgs e)
        {
            txtVersaoAtualizadaBootLoader.Text = txtVersaoAtualBootloader.Text;
        }

        private void btnCopiarSoftwareTrufix_Click(object sender, EventArgs e)
        {
            txtVersaoAtualiadoSoftwareTrufix.Text = txtVersaoAtualSoftwareTrufix.Text;
        }

        private void btnCopiarSoftwareTdx_Click(object sender, EventArgs e)
        {
            txtVersaoAtualizadaSoftwareTdx .Text = txtVersaoAtualSoftwareTdx.Text;
        }

        private void btnLimparArm_Click(object sender, EventArgs e)
        {

        }
    }
}
