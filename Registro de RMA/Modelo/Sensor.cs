using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_RMA.Modelo
{
    public class Sensor
    {
        //declaração das variaveis como private
        private int idSensor;
        private String numeroDeSerie;
        private String cliente;
        private String rma;
        private int patrimonio;
        private String recebimento;
        private String os;
        private String apontamento;
        private String observacao;
        private String dataDeEntrada;
        private String dataDeSaida;
        private String status;
        private String mensagem;
        private String tipo;
        private String item;

        //encapsulamento(restrição de acesso)
        public int IdSensor { get => idSensor; set => idSensor = value; }
        public string NumeroDeSerie { get => numeroDeSerie; set => numeroDeSerie = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Rma { get => rma; set => rma = value; }
        public int Patrimonio { get => patrimonio; set => patrimonio = value; }
        public string Recebimento { get => recebimento; set => recebimento = value; }
        public string Os { get => os; set => os = value; }
        public string Apontamento { get => apontamento; set => apontamento = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public String DataDeEntrada { get => dataDeEntrada; set => dataDeEntrada = value; }
        public String DataDeSaida { get => dataDeSaida; set => dataDeSaida = value; }
        public string Status { get => status; set => status = value; }
        public string Mensagem { get => mensagem; set => mensagem = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Item { get => item; set => item = value; }
    }
}
