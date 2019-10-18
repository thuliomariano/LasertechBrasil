using Registro_de_RMA.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        public String AtualizarSensor()
        {
            return mensagem;
        }

       /* public String DeletarSensor(Sensor sensor)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = @"delete from sensor where idsensor = @id";

            cmd.Parameters.AddWithValue("@id", sensor.IdSensor);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                mensagem = "Deletado com sucesso!";

            }
            catch (Exception)
            {
                con.Desconectar();
                mensagem = "Erro  de comunicação com o banco de dados!";
               
            }
            return mensagem;
        }*/

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

            cmd.CommandText = @"update sensor set statusDaOs = @status, dataDeSaida = @datas, observacao = @observacao where idSensor = @id";

            cmd.Parameters.AddWithValue("@id", sensor.IdSensor);
            cmd.Parameters.AddWithValue("@status", sensor.Status);
            cmd.Parameters.AddWithValue("@observacao", sensor.Observacao);
            cmd.Parameters.AddWithValue("@datas", sensor.DataDeSaida);


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

        /*
        public Sensor BuscarPorID(Sensor sensor)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = @"select * from sensor where idsensor = @id";

            cmd.Parameters.AddWithValue("@id", sensor.IdSensor);

            cmd.Connection = con.Conectar();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            try
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    sensor.NumeroDeSerie = dr["numero"].ToString();
                    sensor.Cliente = dr["cliente"].ToString();
                    sensor.Rma = dr["rma"].ToString();
                    sensor.Patrimonio = Convert.ToInt32(dr["patrimonio"]);
                    sensor.Recebimento = dr["recebimento"].ToString();
                    sensor.Os = dr["os"].ToString();
                    sensor.Apontamento = dr["apontamento"].ToString();
                    sensor.Observacao = dr["observacao"].ToString();

                }
                else
                {
                    sensor.IdSensor = 0;
                }

            }
            catch (Exception)
            {

                //não ira mensagem por se tratar de leitura de dados
            }
            finally
            {
                dr.Close();
                con.Desconectar();
            }
            return sensor;
        }
        */
         


    }
}
