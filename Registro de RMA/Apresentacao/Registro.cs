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

            DateTime date1 = DateTime.ParseExact("20/10/2019", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact("20/10/2019", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            
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
            sensor.DataDeEntrada = date1;
            sensor.DataDeSaida = date2;
            controle.CadastrarSensor(sensor);
            MessageBox.Show(controle.Mensagem);
        }
    }
}
