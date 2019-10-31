using Registro_de_RMA.Modelo;
using System;
using System.Data.SqlClient;

namespace Registro_de_RMA.DAL
{

    public class SensorDao
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


        public String AtualizarSensor()
        {
            return mensagem;
        }

        public String AtualizarPorId(Sensor sensor)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = @"update sensor set numero = @numero,cliente = @cliente,rma = @rma,patrimonio= @patrimonio, recebimento = @recebimento, os = @os, apontamento = @apontamento, observacao = @observacao where idSensor = @id";


            cmd.Parameters.AddWithValue("@id", sensor.IdSensor);
            cmd.Parameters.AddWithValue("@numero", sensor.NumeroDeSerie);
            cmd.Parameters.AddWithValue("@cliente", sensor.Cliente);
            cmd.Parameters.AddWithValue("@rma", sensor.Rma);
            cmd.Parameters.AddWithValue("@patrimonio", sensor.Patrimonio);
            cmd.Parameters.AddWithValue("@recebimento", sensor.Recebimento);
            cmd.Parameters.AddWithValue("@os", sensor.Os);
            cmd.Parameters.AddWithValue("@apontamento", sensor.Apontamento);
            cmd.Parameters.AddWithValue("@observacao", sensor.Observacao);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                mensagem = "Item atualizado com sucesso!";
            }
            catch (Exception)
            {

                mensagem = "Erro de comunitação com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }

            return mensagem;
        }
        public String AtualizarStatus(Sensor sensor)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"update sensor set statusDaOs = @status, dataDeSaida = @datas, observacao = @observacao, preco = @preco, informacoeslti = @lti where idSensor = @id";

            cmd.Parameters.AddWithValue("@id", sensor.IdSensor);
            cmd.Parameters.AddWithValue("@status", sensor.Status);
            cmd.Parameters.AddWithValue("@observacao", sensor.Observacao);
            cmd.Parameters.AddWithValue("@datas", sensor.DataDeSaida);
            cmd.Parameters.AddWithValue("@preco", sensor.SensorPrice);
            cmd.Parameters.AddWithValue("@Lti", sensor.Lti);


            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                mensagem = "Atualização realizada com sucesso";

            }
            catch (Exception)
            {

                mensagem = "Erro de conexão com o banco de dados";
            }
            finally
            {
                con.Desconectar();
            }

            return mensagem;
        }

    }
}
