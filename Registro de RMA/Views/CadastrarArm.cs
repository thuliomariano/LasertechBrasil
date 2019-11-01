using Registro_de_RMA.Entities;
using System;
using System.Windows.Forms;
using Registro_de_RMA.Controller;
using Registro_de_RMA.Modelo;

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
            txtVersaoAtualizadaSoftwareTdx.Text = txtVersaoAtualSoftwareTdx.Text;
        }

        private void btnLimparArm_Click(object sender, EventArgs e)
        {
            txtPatrimonioArm.Text = "";
            txtMac.Text = "";
            txtVersaoHardware.Text = "";
            txtIris.Text = "";
            txtVersaoSoftwarePc.Text = "";
            txtColibri.Text = "";
            txtVersaoAtualWindowsCe.Text = "";
            txtVersaoAtualBootloader.Text = "";
            txtVersaoAtualSoftwareTrufix.Text = "";
            txtVersaoAtualSoftwareTdx.Text = "";
            txtVersaoAtualizadaPatrimonio.Text = "";
            txtVersaoAtualizadaHardware.Text = "";
            txtVersaoAtualizadoWindowsCe.Text = "";
            txtVersaoAtualizadaBootLoader.Text = "";
            txtVersaoAtualiadoSoftwareTrufix.Text = "";
            txtVersaoAtualizadaSoftwareTdx.Text = "";
        }

        private void btnCopiarVersaoHardware_Click(object sender, EventArgs e)
        {
            txtVersaoAtualizadaHardware.Text = txtVersaoHardware.Text;
        }

        private void txtVersaoAtualizadaHardware_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCopiarTodos_Click(object sender, EventArgs e)
        {
            txtVersaoAtualizadaPatrimonio.Text = txtPatrimonioArm.Text;
            txtVersaoAtualizadaHardware.Text = txtVersaoHardware.Text;
            txtVersaoAtualizadoWindowsCe.Text = txtVersaoAtualWindowsCe.Text;
            txtVersaoAtualizadaBootLoader.Text = txtVersaoAtualBootloader.Text;
            txtVersaoAtualiadoSoftwareTrufix.Text = txtVersaoAtualSoftwareTrufix.Text;
            txtVersaoAtualizadaSoftwareTdx.Text = txtVersaoAtualSoftwareTdx.Text;
            txtVersaoAtualizadaSoftware.Text = txtVersaoSoftwarePc.Text;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtVersaoAtualizadaSoftwareTdx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCopiarVersaoSoftware_Click(object sender, EventArgs e)
        {
            txtVersaoAtualizadaSoftware.Text = txtVersaoSoftwarePc.Text;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Padrão
            Arm arm = new Arm();
            arm.Patrimonio = txtPatrimonioArm.Text.ToUpper();
            arm.Mac = txtMac.Text.ToUpper();
            arm.VersaoDeHardwareAtualizadoPc = txtVersaoHardware.Text.ToUpper();
            arm.SerialIris = Convert.ToInt16(txtIris.Text);
            arm.VersaoDeSoftwareAtualizadoPC = txtVersaoSoftwarePc.Text.ToUpper();
            arm.SerialColibri = Convert.ToInt16(txtColibri.Text);

            //Atual
            arm.WindowsCe = txtVersaoAtualWindowsCe.Text.ToUpper();
            arm.BootLoader = txtVersaoAtualBootloader.Text.ToUpper();
            arm.SoftwareTrufixAtualizado = txtVersaoAtualSoftwareTrufix.Text.ToUpper();
            arm.SoftwareToradex = txtVersaoAtualSoftwareTdx.Text.ToUpper();

            //Versão atualizada
            arm.PatrimonioPcAtualizado = txtVersaoAtualizadaPatrimonio.Text.ToUpper();
            arm.VersaoDeHardwareAtualizadoPc = txtVersaoAtualizadaHardware.Text.ToUpper();
            arm.WindowsCeAtualizado = txtVersaoAtualizadoWindowsCe.Text.ToUpper();
            arm.BootLoaderAtualizado = txtVersaoAtualizadaBootLoader.Text.ToUpper();
            arm.VersaoDeSoftwareAtualizadoPC = txtVersaoAtualiadoSoftwareTrufix.Text.ToUpper();
            arm.SoftwareToradexAtualizado = txtVersaoAtualizadaSoftwareTdx.Text.ToUpper();
            arm.DataDeEntrada = DateTime.Now;
            arm.DataDeSaida = DateTime.Now;
            arm.DataDeEntrada.ToString("dd-MM-yyyy HH:mm:ss");
            arm.DataDeSaida.ToString("dd-MM-yyyy HH:mm:ss");
            Controle controle = new Controle();
            MessageBox.Show(controle.CadastrarArm(arm), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
