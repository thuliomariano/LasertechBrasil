using Registro_de_RMA.Modelo;
using System;
using System.Windows.Forms;
using Registro_de_RMA.Entities.Exceptions;
namespace Registro_de_RMA.Apresentacao
{
    public partial class CadastrarSensor : Form
    {
        public CadastrarSensor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime date1 = DateTime.Now;
                DateTime date2 = DateTime.Parse("2019-08-12 18:00:15");

                String d1 = date1.ToString("yyyy-dd-MM HH:mm:ss");
                String d2 = date2.ToString("yyyy-dd-MM HH:mm:ss");

                Sensor sensor = new Sensor();
                Controle controle = new Controle();

                if (txtSerie.Text == "" && txtCliente.Text == "" && txtRma.Text == "" && txtObservacao.Text == "" && txtOrdemDeServico.Text == "" && txtApontamento.Text == "" && txtRecebimento.Text == "" && txtPatrimonio.Text == "")
                {
                    MessageBox.Show("Favor preencher pelo menos o número de série", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtSerie.Text == "")
                    {
                        sensor.NumeroDeSerie = "";
                    }
                    else
                    {
                        sensor.NumeroDeSerie = txtSerie.Text.ToUpper();
                    }
                    if (txtCliente.Text == "")
                    {
                        sensor.Cliente = "";
                    }
                    else
                    {
                        sensor.Cliente = txtCliente.Text.ToUpper();
                    }
                    if (txtRma.Text == "")
                    {
                        sensor.Rma = "";
                    }
                    else
                    {
                        sensor.Rma = "RMA-" + txtRma.Text.ToUpper();
                    }
                    if (txtRecebimento.Text == "")
                    {
                        sensor.Recebimento = "";
                    }
                    else
                    {
                        sensor.Recebimento = txtRecebimento.Text.ToUpper();
                    }
                    if (txtObservacao.Text == "")
                    {
                        sensor.Observacao = "";
                    }
                    else
                    {
                        sensor.Observacao = txtObservacao.Text.ToUpper();
                    }
                    if (txtOrdemDeServico.Text == "")
                    {
                        sensor.Os = "";
                    }
                    else
                    {
                        sensor.Os = "OS-" + txtOrdemDeServico.Text.ToUpper();
                    }
                    if (txtApontamento.Text == "")
                    {
                        sensor.Apontamento = "";
                    }
                    else
                    {
                        sensor.Apontamento = "AP-" + txtApontamentos.Text.ToUpper();
                    }
                    if (txtPatrimonio.Text == "")
                    {
                        sensor.Patrimonio = 0;
                    }
                    else
                    {
                        sensor.Patrimonio = Convert.ToInt32(txtPatrimonio.Text);
                    }
                    sensor.Lti = "";
                    sensor.DataDeEntrada = d1;
                    sensor.DataDeSaida = "";
                    sensor.Status = "ABERTO";
                    controle.CadastrarSensor(sensor);
                    MessageBox.Show(controle.Mensagem, "Anteção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException erroFormatException)
            {
                MessageBox.Show("Erro de formatação: " + erroFormatException.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DomainException erroDomainException)
            {
               
            }
            catch (Exception erroException)
            {
                MessageBox.Show("Erro inesperado: " + erroException.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSerie.Text = "";
            txtCliente.Text = "";
            txtRecebimento.Text = "";
            txtOrdemDeServico.Text = "";
            txtApontamentos.Text = "";
            txtObservacao.Text = "";
            txtRma.Text = "";
            txtPatrimonio.Text = "";
        }
    }
}
