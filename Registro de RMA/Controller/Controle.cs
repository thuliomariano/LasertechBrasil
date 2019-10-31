using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_de_RMA.DAL;
using Registro_de_RMA.Entities;
using Registro_de_RMA.Modelo;
using Registro_de_RMA.Controller;

namespace Registro_de_RMA.Modelo
{
    public class Controle
    {
        private String mensagem;

        public string Mensagem { get => mensagem; set => mensagem = value; }

        public String CadastrarSensor(Sensor sensor)
        {
            
            Validacao validacao = new Validacao(sensor);
            if (validacao.Mensagem.Equals(""))
            {
                SensorDao sensorDAO = new SensorDao();
                return Mensagem = sensorDAO.CadatrarSensor(sensor);
            }
            else
            {
                Mensagem = validacao.Mensagem;
            }

            return Mensagem;
        }

       

        public String AtualizarStatus(Sensor sensor)
        {
            Validacao validacao = new Validacao(sensor);
            if (validacao.Mensagem.Equals(""))
            {
                SensorDao sensorDAO = new SensorDao();
                return Mensagem = sensorDAO.AtualizarStatus(sensor);
            }
            else
            {
                Mensagem = validacao.Mensagem;
            }
            return mensagem;
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

        public String CadastrarArm(Arm arm)
        {

            ValidaArm validaArm = new ValidaArm(arm);
            if (validaArm.Mensagem.Equals(""))
            {
                ArmDao armDao = new ArmDao();
                return Mensagem = armDao.cadastrarArm(arm);
            }
            else
            {
                Mensagem = validaArm.Mensagem;
            }

            return Mensagem;
        }
    }
}
