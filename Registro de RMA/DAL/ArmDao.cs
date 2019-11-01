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

            cmd.CommandText = @"insert into arm(patrimonio, versaoDeHardwarePc, versaoDeSoftwarePc, mac, serialIris, SerialColibri, windowsCe, bootloader, softwareTrufix, softwareToradex, patrimonioPcAtualizado, versaoDeHardwareAtualizadoPc, versaoDeSoftwareAtualizadoPc, windowsCeAtualizado, bootLoaderAtualizado, softwareTrufixAtualizado, softwareToradexAtualizado, dataDeEntrada, dataDesaida) 
                                values(@Patrimonio, @VersaoDeHardwarePC,@VersaoDeSoftwarerPC, @Mac, @SerialIris, @SerialColibri, @WindowsCe, @BootLoader, @SoftwareTrufix, @SoftwareToradex, @PatrimonioPcAtualizado, @VersaoDeHardwareAtualizadoPc, @VersaoDeSoftwareAtualizadoPC, @WindowsCeAtualizado, @BootLoaderAtualizado, @SoftwareTrufixAtualizado, @SoftwareToradexAtualizado, @DataDeEntrada, @DataDeSaida)";

            
            cmd.Parameters.AddWithValue("@Patrimonio", arm.Patrimonio);
            cmd.Parameters.AddWithValue("@VersaoDeHardwarePC", arm.VersaoDeHardwarePC);
            cmd.Parameters.AddWithValue("@VersaoDeSoftwarerPC", arm.VersaoDeSoftwarerPC);
            cmd.Parameters.AddWithValue("@Mac", arm.Mac);
            cmd.Parameters.AddWithValue("@SerialIris", arm.SerialIris);
            cmd.Parameters.AddWithValue("@SerialColibri", arm.SerialColibri);
            cmd.Parameters.AddWithValue("@WindowsCe", arm.WindowsCe);
            cmd.Parameters.AddWithValue("@BootLoader", arm.BootLoader);
            cmd.Parameters.AddWithValue("@SoftwareTrufix", arm.SoftwareTrufix);
            cmd.Parameters.AddWithValue("@SoftwareToradex", arm.SoftwareToradex);
            cmd.Parameters.AddWithValue("@PatrimonioPcAtualizado", arm.PatrimonioPcAtualizado);
            cmd.Parameters.AddWithValue("@VersaoDeHardwareAtualizadoPc", arm.VersaoDeHardwareAtualizadoPc);
            cmd.Parameters.AddWithValue("@VersaoDeSoftwareAtualizadoPC", arm.VersaoDeSoftwareAtualizadoPC);
            cmd.Parameters.AddWithValue("@WindowsCeAtualizado", arm.WindowsCeAtualizado);
            cmd.Parameters.AddWithValue("@BootLoaderAtualizado", arm.BootLoaderAtualizado);
            cmd.Parameters.AddWithValue("@SoftwareTrufixAtualizado", arm.SoftwareTrufixAtualizado);
            cmd.Parameters.AddWithValue("@SoftwareToradexAtualizado", arm.SoftwareToradexAtualizado);
            cmd.Parameters.AddWithValue("@DataDeEntrada", arm.DataDeEntrada);
            cmd.Parameters.AddWithValue("@DataDeSaida", arm.DataDeSaida);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                Mensagem = "Cadastrado com sucesso!";
            }
            catch (SqlException erro)
            {

                Mensagem = erro.ToString();
            }
            finally
            {
                con.Desconectar();
            }

            return Mensagem;
        }
    }
}
