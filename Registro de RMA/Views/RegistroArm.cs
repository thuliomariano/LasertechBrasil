using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void toolStripLabel2_ButtonClick(object sender, EventArgs e)
        {
            Close();        }

        private void btnConsultarSerie_Click(object sender, EventArgs e)
        {
           
        }
        
    }
}
