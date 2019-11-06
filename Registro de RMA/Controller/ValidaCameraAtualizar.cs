using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_de_RMA.Entities;

namespace Registro_de_RMA.Controller
{
    class ValidaCameraAtualizar
    {
        //pendência de validação, sera o ultimo ponto a ser verificado
        private String mensagem = "";
        public ValidaCameraAtualizar(Camera camera)
        {
            if (Convert.ToString( camera.idCamera) == "")
            {
                mensagem = "Id não  pode ser vazio, por favor digite um valor valido";
            }
            if (camera.Observacao.Length > 250)
            {
                mensagem = "Favor Inserir no campo 'Observação' valor menor que 250 caracteres!";
            }
            if (camera.CameraStatus.Length > 20)
            {
                mensagem = "Favor Inserir no campo 'Status' valor menor que 20 caracteres!";
            }
        }

        public string Mensagem { get => mensagem; set => mensagem = value; }
    }
}

