using Registro_de_RMA.Modelo;
using System;
using System.Data.SqlClient;

namespace Registro_de_RMA.DAL
{
    public class SensorDAO
    {
        private String mensagem;

        public string Mensagem { get => mensagem; set => mensagem = value; }

        
        Sensor sensor = new Sensor();

        public String CadatrarSensor(Sensor sensor)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into sensor(numero,cliente,rma,patrimonio,recebimento,os,apontamento,observacao, dataDeEntrada, dataDeSaida, statusDaOs) 
                                values(@numero, @cliente, @rma, @patrimonio, @recebimento, @os, @apontamento, @observacao, @dataDeEntrada, @dataDeSaida, @statusDaOs)";

            cmd.Parameters.AddWithValue("@numero", sensor.NumeroDeSerie);
            cmd.Parameters.AddWithValue("@cliente", sensor.Cliente);
            cmd.Parameters.AddWithValue("@rma", sensor.Rma);
            cmd.Parameters.AddWithValue("@patrimonio", sensor.Patrimonio);
            cmd.Parameters.AddWithValue("@recebimento", sensor.Recebimento);
            cmd.Parameters.AddWithValue("@os", sensor.Os);
            cmd.Parameters.AddWithValue("@apontamento", sensor.Apontamento);
            cmd.Parameters.AddWithValue("@observacao", sensor.Observacao);
            cmd.Parameters.AddWithValue("@dataDeEntrada", sensor.DataDeEntrada);
            cmd.Parameters.AddWithValue("@dataDeSaida", sensor.DataDeSaida);
            cmd.Parameters.AddWithValue("@statusDaOs", sensor.Status);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                mensagem = "Cadastrado com sucesso!";
            }
            catch (Exception)
            {

                mensagem = "Erro de comunicação com o BD ao cadastrar!";
            }
            finally
            {
                con.Desconectar();
            }

            return Mensagem;
        }

        public String DeletarSensor()
        {
            return mensagem;
        }

        public String AtualizarSensor()
        {
            return mensagem;
        }

    }
}
