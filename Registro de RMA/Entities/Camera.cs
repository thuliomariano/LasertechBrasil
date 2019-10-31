using System;

namespace Registro_de_RMA.Entities
{
    public class Camera
    {
        public int idCamera { get; set; }
        public String Fornecedor { get; set; }
        public String CameraPuma { get; set; }
        public string Mac { get; set; }
        public String Acessorio { get; set; }
        public String Observacao { get; set; }
        public String CameraDataDeEntrada { get; set; }
        public String CameraDataDeSaida { get; set; }
        public String CameraStatus { get; set; }
    }
}
