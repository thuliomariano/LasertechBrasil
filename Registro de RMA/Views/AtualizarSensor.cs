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
            if (txtId.Text == "" && cbStatus.Text == "" && txtObservacao.Text == "" && txtLti.Text == "" && txtPreco.Text == "")
            {
                MessageBox.Show("Campos vazios, por favor preenchaalgum dos campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                Sensor sensor = new Sensor();
                Controle controle = new Controle();

                DateTime d1 = DateTime.Now;
                String date = d1.ToString("yyyy-dd-MM HH:mm:ss");
                    if (txtId.Text == "")
                    {
                        MessageBox.Show("Campo Id não pode ser vazio, por favor insira um id valido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (cbStatus.Text == "")
                        {
                            sensor.Status = "";
                        }
                        else
                        {
                            sensor.Status = cbStatus.Text.ToUpper();
                        }
                        if (txtObservacao.Text == "")
                        {
                            sensor.Observacao = "";
                        }
                        else
                        {
                            sensor.Observacao = txtObservacao.Text.ToUpper();
                        }
                        if (txtLti.Text == "")
                        {
                            sensor.Lti = "";
                        }
                        else
                        {
                            sensor.Lti = txtLti.Text;
                        }
                        if (txtPreco.Text == "")
                        {
                            sensor.SensorPrice = 0.0;
                        }
                        else
                        {
                            sensor.SensorPrice = Convert.ToDouble(txtPreco.Text);
                            sensor.SensorPrice.ToString("F2", CultureInfo.InvariantCulture);
                        }
                        sensor.IdSensor = Convert.ToInt32(txtId.Text.ToUpper());
                        sensor.DataDeSaida = date;
                        controle.AtualizarStatus(sensor);
                    }              
                MessageBox.Show(controle.Mensagem, "Anteção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception errorSensor)
                {
                    MessageBox.Show(errorSensor.ToString(), "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
