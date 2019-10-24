using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_de_RMA.Entities;

namespace Registro_de_RMA.Controller
{
     public class ValidaCamera
    {
        //pendência de validação, sera o ultimo ponto a ser verificado
        private String mensagem = "";
        public ValidaCamera(Camera camera)
        {

        }

        public string Mensagem { get => mensagem; set => mensagem = value; }
    }
}

