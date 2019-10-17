using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_de_RMA.Modelo;
using System.Globalization;
using System.Data.SqlClient;
using Registro_de_RMA.DAL;
namespace Registro_de_RMA.Apresentacao
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lasertechbrasilDataSet.Sensor'. Você pode movê-la ou removê-la conforme necessário.
            this.sensorTableAdapter.Fill(this.lasertechbrasilDataSet.Sensor);
            Sensor sensor = new Sensor();
            Controle controle = new Controle();

         
           
               
            

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.Parse("2019-08-12 18:00:15");

            String d1 = date1.ToString("yyyy-dd-MM HH:mm:ss");
            String d2 = date2.ToString("yyyy-dd-MM HH:mm:ss");

            Sensor sensor = new Sensor();
            Controle controle = new Controle();
            sensor.NumeroDeSerie = txtSerie.Text;   
            sensor.Cliente = txtCliente.Text;
            sensor.Rma = txtRma.Text;
            sensor.Recebimento = txtRecebimento.Text;
            sensor.Observacao = txtObservacao.Text;
            sensor.Os = txtOrdemDeServico.Text;
            sensor.Apontamento = txtApontamentos.Text;
            sensor.Patrimonio = Convert.ToInt32(txtPatrimonio.Text);
            sensor.DataDeEntrada = d1;
            sensor.DataDeSaida = "";
            sensor.Status = "Aberto";
            controle.CadastrarSensor(sensor);
            MessageBox.Show(controle.Mensagem);
            this.sensorTableAdapter.FillBy(this.lasertechbrasilDataSet.Sensor);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sensorTableAdapter.FillBy(this.lasertechbrasilDataSet.Sensor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sensorTableAdapter.FillBy(this.lasertechbrasilDataSet.Sensor);
        }

        private void btnConsultarSerie_Click(object sender, EventArgs e)
        {
            this.sensorTableAdapter.ConsultaNs(lasertechbrasilDataSet.Sensor, "%" + txtConsulta + "%");
        }

        private void btnDeletarSerie_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            Controle controle = new Controle();

            sensor.IdSensor = Convert.ToInt32(txtId.Text);
            controle.DeletarSensor(sensor);
            MessageBox.Show(controle.Mensagem);
            this.sensorTableAdapter.FillBy(this.lasertechbrasilDataSet.Sensor);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            Controle controle = new Controle();

            sensor.IdSensor = Convert.ToInt32(txtId.Text);
            sensor.NumeroDeSerie = txtSerie.Text;
            sensor.Cliente = txtCliente.Text;
            sensor.Rma = txtRma.Text;
            sensor.Recebimento = txtRecebimento.Text;
            sensor.Observacao = txtObservacao.Text;
            sensor.Os = txtOrdemDeServico.Text;
            sensor.Apontamento = txtApontamentos.Text;
            sensor.Patrimonio = Convert.ToInt32(txtPatrimonio.Text);

            controle.AtualizarPorId(sensor);
            MessageBox.Show(controle.Mensagem);
            this.sensorTableAdapter.FillBy(this.lasertechbrasilDataSet.Sensor);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            Controle controle = new Controle();
            sensor.IdSensor =  Convert.ToInt32(txtId.Text);
            sensor = controle.BuscaPorId(sensor);

            txtSerie.Text = sensor.NumeroDeSerie;
            txtCliente.Text = sensor.Cliente;
            txtRma.Text = sensor.Rma;
            txtRecebimento.Text = sensor.Recebimento;
            txtOrdemDeServico.Text = sensor.Os;
            txtApontamento.Text = sensor.Apontamento;
            txtObservacao.Text = sensor.Observacao;
            txtPatrimonio.Text = sensor.Patrimonio.ToString();
                


        }

        private void consultaNsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sensorTableAdapter.ConsultaNs(this.lasertechbrasilDataSet.Sensor, numeroDeSerieToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
