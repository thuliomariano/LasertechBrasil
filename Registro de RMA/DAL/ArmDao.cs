using Registro_de_RMA.DAL;
using Registro_de_RMA.Controller;
using Registro_de_RMA.Entities;
using System.Data.SqlClient;

namespace Registro_de_RMA.DAL

{
    public class ArmDao
    {
        public string Mensagem { get; set; }
        public string cadastrarArm(Arm arm)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"";

            /*cmd.Parameters.AddWithValue("", arm.PatrimonioPc);
            cmd.Parameters.AddWithValue("", arm.VersaoDeHardware);
            cmd.Parameters.AddWithValue("", arm.VersaoDeSoftwarer);
            cmd.Parameters.AddWithValue("", arm.Mac);
            cmd.Parameters.AddWithValue("", arm.seria);
            cmd.Parameters.AddWithValue("", arm.PatrimonioPc);
            cmd.Parameters.AddWithValue("", arm.PatrimonioPc);
            cmd.Parameters.AddWithValue("", arm.PatrimonioPc);
            cmd.Parameters.AddWithValue("", arm.PatrimonioPc);
            cmd.Parameters.AddWithValue("", arm.PatrimonioPc);
            cmd.Parameters.AddWithValue("", arm.PatrimonioPc);
            cmd.Parameters.AddWithValue("", arm.PatrimonioPc);
            cmd.Parameters.AddWithValue("", arm.PatrimonioPc);
            cmd.Parameters.AddWithValue("", arm.PatrimonioPc);
            cmd.Parameters.AddWithValue("", arm.PatrimonioPc);
            cmd.Parameters.AddWithValue("", arm.PatrimonioPc);
            cmd.Parameters.AddWithValue("", arm.PatrimonioPc);
            cmd.Parameters.AddWithValue("", arm.PatrimonioPc);*/

            return Mensagem;
        }
    }
}
