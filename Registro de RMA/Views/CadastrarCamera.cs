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
using Registro_de_RMA.Modelo;
using Registro_de_RMA.Entities.Enum;

namespace Registro_de_RMA.Views
{
    public partial class CadastrarCamera : Form
    {
        public CadastrarCamera()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Camera camera = new Camera();
            camera.Fornecedor = txtFornecedor.Text.ToUpper();
            camera.Observacao = txtObservacaoCamera.Text.ToUpper();
            camera.Mac = txtMac.Text.ToUpper();
            camera.CameraDataDeEntrada =  DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss");
            camera.CameraDataDeSaida = DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss");
            camera.Acessorio = txtAcessório.Text.ToUpper();
            camera.CameraPuma = txtProduto.Text.ToUpper();
            camera.CameraStatus = "ABERTO";
            Controle controle = new Controle();
            controle.CadastrarCamera(camera);
            MessageBox.Show(controle.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAcessório.Text = "";
            txtApontamento.Text = "";
            txtFornecedor.Text = "";
            txtMac.Text = "";
            txtObservacaoCamera.Text = "";
            txtPatrimonioCamera.Text = "";
            txtProduto.Text = "";
        }

        private void CadastrarCamera_Load(object sender, EventArgs e)
        {
            txtProduto.DataSource = Enum.GetValues(typeof(Entities.Enum.ModeloCamera));
            txtFornecedor.DataSource = Enum.GetValues(typeof(Entities.Enum.Fornecedor));
        }
    }
}
