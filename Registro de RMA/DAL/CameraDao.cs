using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_de_RMA.Modelo;
using System.Data.SqlClient;
using Registro_de_RMA.Entities;

namespace Registro_de_RMA.DAL
{
    public class CameraDao
    {
        public String Mensagem { get; set; }
        public String CadastrarCamera(Camera camera)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"insert into camera(fornecedor, camera, mac, acessorio, observacao, dataDeEntrada, dataDeSaida, statusCamera)
                                values(fornecedor = @fornecedor,camera = @camera, mac = @mac, acessorio = @acessorio, observacao = @observacao, dataDeEntrada = @dataDeEntrada, dataDeSaida = @dataDeSaida, statusCamera = @statusCamera)";

            cmd.Parameters.AddWithValue("@fornecedor", camera.Fornecedor);
            cmd.Parameters.AddWithValue("@camera", camera.CameraPuma);
            cmd.Parameters.AddWithValue("@mac", camera.Mac);
            cmd.Parameters.AddWithValue("@acessorio", camera.Acessorio);
            cmd.Parameters.AddWithValue("@observacao", camera.Observacao);
            cmd.Parameters.AddWithValue("@dataDeEntrada", camera.CameraDataDeEntrada);
            cmd.Parameters.AddWithValue("@dataDeSaida", camera.CameraDataDeSaida);
            cmd.Parameters.AddWithValue("@statusCamera", camera.CameraStatus);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                Mensagem = "Cadastrado o item com sucesso!";
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
