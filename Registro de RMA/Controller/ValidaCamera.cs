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
            if (camera.Fornecedor.Length > 50)
            {
                mensagem = "Favor Inserir no campo 'Fornecedor' valor menor que 50 caracteres!";
            }
            if (camera.CameraPuma.Length > 50)
            {
                mensagem = "Favor Inserir no campo 'Câmera' valor menor que 50 caracteres!";
            }
            if (camera.Mac.Length > 16)
            {
                mensagem = "Favor Inserir no campo 'MAC adress' valor menor que 12 caracteres!";
            }
            if (camera.Acessorio.Length > 50)
            {
                mensagem = "Favor Inserir no campo 'Acessorio' valor menor que 50 caracteres!";
            }
            if (camera.Observacao.Length >250)
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

