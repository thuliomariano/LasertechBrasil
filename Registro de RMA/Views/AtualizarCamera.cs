using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_de_RMA.Entities;
using Registro_de_RMA.Controller;
using Registro_de_RMA.Modelo;
using Registro_de_RMA.Views;

namespace Registro_de_RMA.Views
{
    public partial class AtualizarCamera : Form
    {
        public AtualizarCamera()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAtualizarCamera_Click(object sender, EventArgs e)
        {
            Camera camera = new Camera();
            camera.CameraDataDeSaida = DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss");
            camera.idCamera = Convert.ToInt16(txtIdCamera.Text.ToUpper());
            camera.Observacao = txtObservacaoCamera.Text.ToUpper();
            camera.CameraStatus = cbStatusCamera.Text.ToUpper();
            Controle controle = new Controle();
            MessageBox.Show( controle.AtualizarCamera(camera), "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbStatusCamera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
           
private void AtualizarCamera_Load(object sender, EventArgs e)
        {
            cbStatusCamera.DataSource = Enum.GetValues(typeof(Entities.Enum.OrderStatus));
        }

        private void btnLimparCamera_Click(object sender, EventArgs e)
        {
            txtObservacaoCamera.Text = "";
            cbStatusCamera.Text = "";
            txtIdCamera.Text = "";
        }
    }
}
