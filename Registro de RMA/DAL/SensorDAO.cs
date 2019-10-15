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




        public Sensor ConsultarTodos(Sensor sensor)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"select * from sensor";
            
            try
            {
                cmd.Connection = con.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    sensor.IdSensor = Convert.ToInt32(dr["idsensor"]);
                    sensor.NumeroDeSerie = dr["numero"].ToString();
                    sensor.Cliente = dr["cliente"].ToString();
                    sensor.Rma = dr["rma"].ToString();
                    sensor.Patrimonio = Convert.ToInt32(dr["patrimonio"]);
                    sensor.Recebimento = dr["recebimento"].ToString();
                    sensor.Os = dr["os"].ToString();
                    sensor.Apontamento = dr["apontamento"].ToString();
                    sensor.Observacao = dr["observacao"].ToString();
                    sensor.DataDeEntrada = dr["datadeentrada"].ToString();
                    sensor.DataDeSaida = dr["datadesaida"].ToString();
                    sensor.Status = dr["statusdaos"].ToString();
                    return sensor;
                }

            }
            catch (Exception)
            {

                mensagem = "Erro de comunicação com o banco de dados!";
            }
            return sensor;

        }

        public String AtualizarSensor()
        {
            return mensagem;
        }

    }
}
