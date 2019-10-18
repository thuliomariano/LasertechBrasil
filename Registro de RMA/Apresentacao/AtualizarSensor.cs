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
    public partial class AtualizarSensor : Form
    {
        public AtualizarSensor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            btnAndamento.Enabled = true;
            btnFechar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPausar.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AtualizarSensor_Load(object sender, EventArgs e)
        {
            btnAndamento.Enabled = false;
            btnFechar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPausar.Enabled = false;
        }
    }
}
