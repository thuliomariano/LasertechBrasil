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
        
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            DateTime date1 = DateTime.Today;
            DateTime date2 = DateTime.Parse("2019-08-12 18:00:15");

            String d1 = date1.ToString("yyyy-MM-dd");
            String d2 = date2.ToString("yyyy-MM-dd");

            Sensor sensor = new Sensor();
            Controle controle = new Controle();
            sensor.NumeroDeSerie = txtSerie.Text;   
            sensor.Cliente = txtCliente.Text;
            sensor.Rma = txtRma.Text;
            sensor.Recebimento = txtRecebimento.Text;
            sensor.Observacao = txtObservacao.Text;
            sensor.Os = txtOrdemDeServico.Text;
            sensor.Apontamento = txtApontamento.Text;
            sensor.Patrimonio = Convert.ToInt32(txtPatrimonio.Text);
            sensor.DataDeEntrada = d1;
            sensor.DataDeSaida = d2;
            controle.CadastrarSensor(sensor);
            MessageBox.Show(controle.Mensagem);
        }
    }
}
