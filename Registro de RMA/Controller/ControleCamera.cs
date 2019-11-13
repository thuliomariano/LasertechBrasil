using Registro_de_RMA.DAL;
using Registro_de_RMA.Entities;
using System;

namespace Registro_de_RMA.Controller
{
    class ControleCamera
    {
        private String mensagem;

        public string Mensagem { get => mensagem; set => mensagem = value; }


        public String AtualizarCamera(Camera camera)
        {

            ValidaCamera validaCamera = new ValidaCamera(camera);
            if (validaCamera.Mensagem.Equals(""))
            {
                CameraDao cameraDao = new CameraDao();
                return Mensagem = cameraDao.AtualizarCamera(camera);
            }
            else
            {
                Mensagem = validaCamera.Mensagem;
            }

            return Mensagem;
        }

        public String CadastrarCamera(Camera camera)
        {

            ValidaCamera validaCamera = new ValidaCamera(camera);
            if (validaCamera.Mensagem.Equals(""))
            {
                CameraDao cameraDao = new CameraDao();
                return Mensagem = cameraDao.CadastrarCamera(camera);
            }
            else
            {
                Mensagem = validaCamera.Mensagem;
            }

            return Mensagem;
        }

    }
}
