using Registro_de_RMA.Entities;
using Registro_de_RMA.Modelo;
using System;
using System.Windows.Forms;

namespace Registro_de_RMA.Views
{
    public partial class CadastrarCamera : Form
    {
        public CadastrarCamera()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Camera camera = new Camera();
            try
            {
                if (txtFornecedor.Text == "")
                {
                    camera.Fornecedor = "";
                }
                else
                {
                    camera.Fornecedor = txtFornecedor.Text.ToUpper();
                }
                if (txtObservacaoCamera.Text == "")
                {
                    camera.Observacao = "";
                }
                else
                {
                    camera.Observacao = txtObservacaoCamera.Text.ToUpper();
                }
                if (txtMac.Text == "")
                {
                    camera.Mac = "";
                }
                else
                {
                    camera.Mac = txtMac.Text.ToUpper();
                }
                if (txtAcessório.Text == "")
                {
                    camera.Acessorio = "";
                }
                else
                {
                    camera.Acessorio = txtAcessório.Text.ToUpper();
                }
                if (txtProduto.Text == "")
                {
                    camera.CameraPuma = "";
                }
                else
                {
                    camera.CameraPuma = txtProduto.Text.ToUpper();
                }
                camera.CameraDataDeEntrada = DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss");
                camera.CameraDataDeSaida = DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss");
                camera.CameraStatus = "ABERTO";
            }
            catch (Exception erroDeDados)
            {

                MessageBox.Show(erroDeDados.ToString());
            }

            try
            {
                Controle controle = new Controle();
                controle.CadastrarCamera(camera);
                MessageBox.Show(controle.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception PassagemDeDados)
            {
                MessageBox.Show(PassagemDeDados.ToString());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
            txtAcessório.Text = "";
            txtApontamento.Text = "";
            txtFornecedor.Text = "";
            txtMac.Text = "";
            txtObservacaoCamera.Text = "";
            txtPatrimonioCamera.Text = "";
            txtProduto.Text = "";

            }
            catch (Exception capturarDadosCamera)
            {

                MessageBox.Show(capturarDadosCamera.ToString());
            }
        }

        private void CadastrarCamera_Load(object sender, EventArgs e)
        {
            txtProduto.DataSource = Enum.GetValues(typeof(Entities.Enum.ModeloCamera));
            txtFornecedor.DataSource = Enum.GetValues(typeof(Entities.Enum.Fornecedor));
        }
    }
}
