using Registro_de_RMA.Controller;
using Registro_de_RMA.Entities;
using System;
using System.Windows.Forms;
using Registro_de_RMA.Entities.Exceptions;

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



            try
            {
                Camera camera = new Camera();
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
                ControleCamera controleCamera = new ControleCamera();
                controleCamera.CadastrarCamera(camera);
                MessageBox.Show(controleCamera.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException error)
            {
                MessageBox.Show("Erro de formatação: " + error.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException error)
            {
                MessageBox.Show("Erro nos valores numericos: " + error.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DomainException error)
            {
                MessageBox.Show("Erro de dominio: " + error.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro inesperado: " + error.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
