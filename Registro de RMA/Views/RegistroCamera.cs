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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            CadastrarCamera camera = new CadastrarCamera();
            camera.ShowDialog();
        }
    }
}
