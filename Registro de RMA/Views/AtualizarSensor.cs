using Registro_de_RMA.Modelo;
using System;
using System.Windows.Forms;
using System.Globalization;


namespace Registro_de_RMA.Apresentacao
{
    public partial class AtualizarSensor : Form
    {
        public AtualizarSensor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            Controle controle = new Controle();

            DateTime d1 = DateTime.Now;
            String date = d1.ToString("yyyy-dd-MM HH:mm:ss");

            sensor.IdSensor = Convert.ToInt32(txtId.Text.ToUpper());
            sensor.Status = cbStatus.Text.ToUpper();
            sensor.Observacao = txtObservacao.Text.ToUpper();
            sensor.DataDeSaida = date;
            sensor.Lti = txtLti.Text;
            sensor.SensorPrice = Convert.ToDouble(txtPreco.Text);
            sensor.SensorPrice.ToString("F2", CultureInfo.InvariantCulture);
            controle.AtualizarStatus(sensor);
            MessageBox.Show(controle.Mensagem, "Anteção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AtualizarSensor_Load(object sender, EventArgs e)
        {
            cbStatus.DataSource = Enum.GetValues(typeof(Entities.Enum.OrderStatus));


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtObservacao.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
