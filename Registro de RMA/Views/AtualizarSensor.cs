using Registro_de_RMA.Controller;
using Registro_de_RMA.Modelo;
using System;
using System.Globalization;
using System.Windows.Forms;
using Registro_de_RMA.Entities.Exceptions;


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
                    ControleSensor controleSensor = new ControleSensor();

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
                        controleSensor.AtualizarStatus(sensor);
                    }
                    MessageBox.Show(controleSensor.Mensagem, "Anteção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
