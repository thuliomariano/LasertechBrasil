using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_de_RMA.Apresentacao;
using Registro_de_RMA.Views;


namespace Registro_de_RMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sensorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroSensor registro = new RegistroSensor();
            registro.ShowDialog();
        }

        private void cÇAmeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCamera registroCamera = new RegistroCamera();
            registroCamera.ShowDialog();
        }

        private void aRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aRMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroArm registroArm = new RegistroArm();
            registroArm.ShowDialog();
        }

        private void toolStripLabel1_ButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
