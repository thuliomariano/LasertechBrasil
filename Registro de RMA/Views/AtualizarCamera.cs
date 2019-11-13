using Registro_de_RMA.Controller;
using Registro_de_RMA.Entities;
using System;
using System.Windows.Forms;
using Registro_de_RMA.Entities.Exceptions;

namespace Registro_de_RMA.Views
{
    public partial class AtualizarCamera : Form
    {
        public AtualizarCamera()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAtualizarCamera_Click(object sender, EventArgs e)
        {
            Camera camera = new Camera();
            try
            {
                camera.CameraDataDeSaida = DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss");
                if (txtIdCamera.Text == "")
                {
                    camera.idCamera = 0;
                }
                else
                {
                    camera.idCamera = Convert.ToInt16(txtIdCamera.Text.ToUpper());
                }
                if (cbStatusCamera.Text == "")
                {
                    camera.CameraStatus = "";
                }
                else
                {
                    camera.CameraStatus = cbStatusCamera.Text.ToUpper();
                }
                if (txtObservacaoCamera.Text == "")
                {
                    camera.Observacao = "";
                }
                else
                {
                    camera.Observacao = txtObservacaoCamera.Text.ToUpper();
                }
                ControleCamera controleCamera = new ControleCamera();
                MessageBox.Show(controleCamera.AtualizarCamera(camera), "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cbStatusCamera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AtualizarCamera_Load(object sender, EventArgs e)
        {
            cbStatusCamera.DataSource = Enum.GetValues(typeof(Entities.Enum.OrderStatus));
        }

        private void btnLimparCamera_Click(object sender, EventArgs e)
        {
            try
            {
                txtObservacaoCamera.Text = "";
                cbStatusCamera.Text = "";
                txtIdCamera.Text = "";
            }
            catch (FormatException errorEntradaDadosCamera)
            {
                MessageBox.Show("Erro no formato de entrada: " + errorEntradaDadosCamera.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro inesperado: " + error.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
