using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_RMA.Modelo
{
    public class Sensor
    {
        private int idSensor;
        private String numeroDeSerie;
        private String cliente;
        private String rma;
        private int patrimonio;
        private String recebimento;
        private String os;
        private String apontamento;
        private String observacao;
        private DateTime dataDeEntrada;
        private DateTime dataDeSaida;
        private String status;

        public int IdSensor { get => idSensor; set => idSensor = value; }
        public string NumeroDeSerie { get => numeroDeSerie; set => numeroDeSerie = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Rma { get => rma; set => rma = value; }
        public int Patrimonio { get => patrimonio; set => patrimonio = value; }
        public string Recebimento { get => recebimento; set => recebimento = value; }
        public string Os { get => os; set => os = value; }
        public string Apontamento { get => apontamento; set => apontamento = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public DateTime DataDeEntrada { get => dataDeEntrada; set => dataDeEntrada = value; }
        public DateTime DataDeSaida { get => dataDeSaida; set => dataDeSaida = value; }
        public string Status { get => status; set => status = value; }
    }
}
