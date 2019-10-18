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
            sensor.NumeroDeSerie = txtSerie.Text.ToUpper();
            sensor.Cliente = txtCliente.Text.ToUpper();
            sensor.Rma = "RMA-" + txtRma.Text.ToUpper();
            sensor.Recebimento = txtRecebimento.Text.ToUpper();
            sensor.Observacao = txtObservacao.Text.ToUpper();
            sensor.Os = "OS-" + txtOrdemDeServico.Text.ToUpper();
            sensor.Apontamento = "AP-" + txtApontamentos.Text.ToUpper();
            sensor.Patrimonio = Convert.ToInt32(txtPatrimonio.Text);
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
