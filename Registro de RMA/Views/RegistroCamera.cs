using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_de_RMA.Views;

namespace Registro_de_RMA.Apresentacao
{
    public partial class RegistroCamera : Form
    {
        public RegistroCamera()
        {
            InitializeComponent();
        }

        private void RegistroCamera_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lasertechbrasilDataSet3.camera'. Você pode movê-la ou removê-la conforme necessário.
            this.cameraTableAdapter1.Fill(this.lasertechbrasilDataSet3.camera);
            // TODO: esta linha de código carrega dados na tabela 'lasertechbrasilDataSet1.camera'. Você pode movê-la ou removê-la conforme necessário.
            this.cameraTableAdapter.Fill(this.lasertechbrasilDataSet1.camera);

            cbStatus.DataSource = Enum.GetValues(typeof( Entities.Enum.OrderStatus));

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            CadastrarCamera camera = new CadastrarCamera();
            camera.ShowDialog();
            this.cameraTableAdapter1.Fill(this.lasertechbrasilDataSet3.camera);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AtualizarCamera atualizarCamera = new AtualizarCamera();
            atualizarCamera.ShowDialog();
            this.cameraTableAdapter1.Fill(this.lasertechbrasilDataSet3.camera);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.cameraTableAdapter1.Fill(this.lasertechbrasilDataSet3.camera);
        }

        private void consultatatusToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void consultaStatusToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cameraTableAdapter1.ConsultaStatus(this.lasertechbrasilDataSet3.camera, "%" + cbStatus.Text + "%");
        }

        private void consultaMacToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void consultaMacToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnConsultarSerie_Click(object sender, EventArgs e)
        {
            this.cameraTableAdapter1.ConsultaMac(this.lasertechbrasilDataSet3.camera,"%" + txtConsulta.Text + "%");
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
