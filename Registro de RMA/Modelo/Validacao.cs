using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_RMA.Modelo
{
    public class Validacao
    {
        private String mensagem = "";
        public Validacao(Sensor sensor)
        {
            
        }

        public string Mensagem { get => mensagem; set => mensagem = value; }
    }
}
