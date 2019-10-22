using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: esta linha de código carrega dados na tabela 'lasertechbrasilDataSet1.camera'. Você pode movê-la ou removê-la conforme necessário.
            this.cameraTableAdapter.Fill(this.lasertechbrasilDataSet1.camera);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}
