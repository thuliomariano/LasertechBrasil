using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_RMA.Entities
{
    public class Arm
    {
        public int Patrimonio { get; set; }
        public String BootloaderVersion { get; set; }
        public String SerialNumber { get; set; }
        public int SerialId { get; set; }
        public String BordVersion { get; set; }
        public String ProgramBord { get; set; }
        public String ProgramTdx { get; set; }
    }
}
    