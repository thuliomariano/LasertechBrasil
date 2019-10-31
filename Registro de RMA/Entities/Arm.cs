using System;

namespace Registro_de_RMA.Entities
{
    public class Arm
    {
        //padrão
        public int IdBoard { get; set; }
        public String PatrimonioPc { get; set; }
        public String Mac { get; set; }
        public int CbIris { get; set; }
        public int Colibri { get; set; }
        public String VersaoDeHardware { get; set; }
        public String VersaoDeSoftwarer { get; set; }

        //atual
        public String WindowsCe { get; set; }
        public String BootLoader { get; set; }
        public String SoftwareTrufix { get; set; }
        public String SoftwareToradex { get; set; }

        //atualizada

        public String PatrimonioPcAtualizado { get; set; }
        public String VersaoDeHardwareAtualizado { get; set; }
        public String VersaoDesoftwareAtualizado { get; set; }
        public int MyProperty { get; set; }
    }
}
