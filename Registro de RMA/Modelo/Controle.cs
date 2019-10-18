using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_de_RMA.DAL;

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
                SensorDAO sensorDAO = new SensorDAO();
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
                SensorDAO sensorDAO = new SensorDAO();
                return Mensagem = sensorDAO.AtualizarStatus(sensor);
            }
            else
            {
                Mensagem = validacao.Mensagem;
            }
            return mensagem;
        }

      

       
    }
}
