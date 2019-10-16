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

       public String DeletarSensor(Sensor sensor)
        {
            Validacao validacao = new Validacao(sensor);
            if (validacao.Mensagem.Equals(""))
            {
                SensorDAO sensorDAO = new SensorDAO();
                return Mensagem = sensorDAO.DeletarSensor(sensor);
            }
            else
            {
                Mensagem = validacao.Mensagem;
            }
            return mensagem;
        }

        public String AtualizarPorId(Sensor sensor)
        {
            Validacao validacao = new Validacao(sensor);
            if (validacao.Mensagem.Equals(""))
            {
                SensorDAO sensorDAO = new SensorDAO();
                return Mensagem = sensorDAO.AtualizarPorId(sensor);
            }
            else
            {
                Mensagem = validacao.Mensagem;
            }
            return mensagem;
        }

        public Sensor BuscaPorId(Sensor sensor)
        {
            Validacao validacao = new Validacao(sensor);
            if (validacao.Mensagem.Equals(""))
            {
                SensorDAO sensorDAO = new SensorDAO();
                sensorDAO.BuscarPorID(sensor);
            }
            else
            {
                Mensagem = validacao.Mensagem;
            }

            return sensor;
        }
    }
}
