using System;

namespace Registro_de_RMA.Entities
{
    public class Arm
    {
        //padrão
        public int ArmId { get; set; }
        public String Patrimonio { get; set; }
        public String Mac { get; set; }
        public int SerialIris { get; set; }
        public int SerialColibri { get; set; }
        public String VersaoDeHardwarePC { get; set; }
        public String VersaoDeSoftwarerPC { get; set; }

        //atual
        public String WindowsCe { get; set; }
        public String BootLoader { get; set; }
        public String SoftwareTrufix { get; set; }
        public String SoftwareToradex { get; set; }

        //atualizada

        public String PatrimonioPcAtualizado { get; set; }
        public String VersaoDeHardwareAtualizadoPc { get; set; }
        public String VersaoDeSoftwareAtualizadoPC { get; set; }
        public String WindowsCeAtualizado { get; set; }
        public String BootLoaderAtualizado { get; set; }
        public String SoftwareTrufixAtualizado { get; set; }
        public String SoftwareToradexAtualizado { get; set; }

        //Data para registrar entrada e saída do equipamento

        public DateTime DataDeEntrada { get; set; }
        public DateTime DataDeSaida { get; set; }
    }
}
