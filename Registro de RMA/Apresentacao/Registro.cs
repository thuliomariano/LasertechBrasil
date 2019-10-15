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
            Sensor sensor = new Sensor();
            Controle controle = new Controle();

            listView1.Items.Clear();

             
                sensor = controle.BuscarTudo(sensor);

                ListViewItem item = new ListViewItem(sensor.IdSensor.ToString());
                item.SubItems.Add(sensor.NumeroDeSerie);
                item.SubItems.Add(sensor.Cliente);
                item.SubItems.Add(sensor.Rma);
                item.SubItems.Add(sensor.Patrimonio.ToString());
                item.SubItems.Add(sensor.Recebimento);
                item.SubItems.Add(sensor.Os);
                item.SubItems.Add(sensor.Apontamento);
                item.SubItems.Add(sensor.Observacao);
                item.SubItems.Add(sensor.DataDeEntrada);
                item.SubItems.Add(sensor.DataDeSaida);
                item.SubItems.Add(sensor.Status);
                listView1.Items.Add(item);
            

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
            sensor.DataDeSaida = d2;
            sensor.Status = "Aberto";
            controle.CadastrarSensor(sensor);
            MessageBox.Show(controle.Mensagem);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
