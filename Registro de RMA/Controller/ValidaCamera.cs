using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_RMA.Controller
{
     public class ValidaCamera
    {
        //pendência de validação, sera o ultimo ponto a ser verificado
        private String mensagem = "";
        public Validacao()
        {

        }

        public string Mensagem { get => mensagem; set => mensagem = value; }
    }
}
}
