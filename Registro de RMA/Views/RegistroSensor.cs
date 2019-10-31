using Registro_de_RMA.Modelo;
using System;
using System.Windows.Forms;
namespace Registro_de_RMA.Apresentacao
{
    public partial class RegistroSensor : Form
    {
        public RegistroSensor()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            this.sensorTableAdapter1.Fill(this.lasertechbrasilDataSet21.Sensor);
            this.sensorTableAdapter.Fill(this.lasertechbrasilDataSet.Sensor);
            Sensor sensor = new Sensor();
            Controle controle = new Controle();
            cbStatus.DataSource = Enum.GetValues(typeof(Entities.Enum.OrderStatus));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

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
            this.sensorTableAdapter1.ConsultarTudo(this.lasertechbrasilDataSet21.Sensor);
        }

        private void btnConsultarSerie_Click(object sender, EventArgs e)
        {
            if (txtConsulta.Text == "" && cbStatus.Text != "")
            {
                this.sensorTableAdapter1.ConsultaStatus(this.lasertechbrasilDataSet21.Sensor, "%" + cbStatus.Text + "%");
            }
            if (txtConsulta.Text != "" && cbStatus.Text == "")
            {
                this.sensorTableAdapter1.ConsultaNumeroSerial(this.lasertechbrasilDataSet21.Sensor, "%" + txtConsulta.Text + "%");
            }
            if (txtConsulta.Text != "" && cbStatus.Text != "")
            {
                this.sensorTableAdapter1.ConsultaContemAvancada(this.lasertechbrasilDataSet21.Sensor, "%" + txtConsulta.Text + "%", cbStatus.Text);
            }

        }

        private void btnDeletarSerie_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void consultaNsToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            CadastrarSensor cadastrar = new CadastrarSensor();
            cadastrar.ShowDialog();
            this.sensorTableAdapter1.ConsultarTudo(this.lasertechbrasilDataSet21.Sensor);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AtualizarSensor atualizar = new AtualizarSensor();
            atualizar.ShowDialog();
            this.sensorTableAdapter1.ConsultarTudo(this.lasertechbrasilDataSet21.Sensor);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void consultaStatusToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void consultaStatusToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.sensorTableAdapter.ConsultaStatus(this.lasertechbrasilDataSet.Sensor, cbStatus.Text);

        }

        private void consultarTudoToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void consultarTudoToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void consultaAvancadaToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void consultaContemAvancadaToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void consultaContemAvancadaToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void consultaStatusToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void consultaNumeroSerialToolStripButton_Click(object sender, EventArgs e)
        {


        }
    }
}
