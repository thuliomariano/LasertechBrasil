﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_de_RMA.Modelo;

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
            Sensor sensor = new Sensor();
            Controle controle = new Controle();

            DateTime d1 = DateTime.Now;
            String date = d1.ToString("yyyy-MM-dd HH:mm:ss");

            sensor.IdSensor = Convert.ToInt32(txtId.Text.ToUpper());
            sensor.Status = comboBox1.Text.ToUpper();
            sensor.Observacao = txtObservacao.Text.ToUpper();
            sensor.DataDeSaida = date;
            controle.AtualizarStatus(sensor);
            MessageBox.Show(controle.Mensagem, "Anteção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AtualizarSensor_Load(object sender, EventArgs e)
        {
          
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtObservacao.Text = "";
        }
    }
}
