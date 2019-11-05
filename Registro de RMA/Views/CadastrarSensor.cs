using Registro_de_RMA.Modelo;
using System;
using System.Windows.Forms;

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
          
           
                DateTime date1 = DateTime.Now;
                DateTime date2 = DateTime.Parse("2019-08-12 18:00:15");

                String d1 = date1.ToString("yyyy-dd-MM HH:mm:ss");
                String d2 = date2.ToString("yyyy-dd-MM HH:mm:ss");


                Sensor sensor = new Sensor();
                Controle controle = new Controle();

            
          
            try
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
                    sensor.Observacao = "";
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
                }
                else
                {
                    sensor.Patrimonio = Convert.ToInt32(txtPatrimonio.Text);
                }
            }
            catch (Exception erroDeRecebimento)
            {
                MessageBox.Show(erroDeRecebimento.ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            sensor.DataDeEntrada = d1;
            sensor.DataDeSaida = "";
            sensor.Status = "ABERTO";
            controle.CadastrarSensor(sensor);
            MessageBox.Show(controle.Mensagem, "Anteção!", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
