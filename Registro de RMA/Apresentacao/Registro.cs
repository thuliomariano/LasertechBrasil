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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            if (radNumerDeSerie.Checked == true)
            {
                btnConsultarData.Enabled = true;

            }
            if (radData.Checked == true)
            {
                btnConsultarData.Enabled = false;
            }
        }
    }
}
