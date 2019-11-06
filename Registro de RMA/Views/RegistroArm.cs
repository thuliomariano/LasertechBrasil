using System;
using System.Windows.Forms;

namespace Registro_de_RMA.Views
{
    public partial class RegistroArm : Form
    {
        public RegistroArm()
        {
            InitializeComponent();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            CadastrarArm cadastrarArm = new CadastrarArm();
            cadastrarArm.ShowDialog();
        }

        private void RegistroArm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dataSetGeralArm.arm'. Você pode movê-la ou removê-la conforme necessário.
                this.armTableAdapter4.Fill(this.dataSetGeralArm.arm);
                // TODO: esta linha de código carrega dados na tabela 'lasertechbrasilDataSet7.arm'. Você pode movê-la ou removê-la conforme necessário.
                this.armTableAdapter3.Fill(this.lasertechbrasilDataSet7.arm);
                // TODO: esta linha de código carrega dados na tabela 'lasertechbrasilDataSet6.arm'. Você pode movê-la ou removê-la conforme necessário.
                this.armTableAdapter2.Fill(this.lasertechbrasilDataSet6.arm);
                // TODO: esta linha de código carrega dados na tabela 'lasertechbrasilDataSet5.arm'. Você pode movê-la ou removê-la conforme necessário.
                this.armTableAdapter1.Fill(this.lasertechbrasilDataSet5.arm);
                // TODO: esta linha de código carrega dados na tabela 'lasertechbrasilDataSet4.arm'. Você pode movê-la ou removê-la conforme necessário.
                this.armTableAdapter.Fill(this.lasertechbrasilDataSet4.arm);

            }
            catch (Exception errorDeComunicacao)
            {
                MessageBox.Show(errorDeComunicacao.ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripLabel2_ButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultarSerie_Click(object sender, EventArgs e)
        {
            try
            {
                this.armTableAdapter4.ConsultaPCI(this.dataSetGeralArm.arm, "%" + txtConsulta.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void consultaPCIToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void consultaPatrimonioAtualizadoToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void consultaPatrimonioAtualizadoToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.armTableAdapter4.ConsultaPatrimonioAtualizado(this.dataSetGeralArm.arm, "%" + txtPatrimonioArmAtualizado.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
