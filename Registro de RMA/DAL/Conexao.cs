using System.Data.SqlClient;

namespace Registro_de_RMA.DAL
{
    public class Conexao
    {

        SqlConnection connection;

        //informa para o BD qual é a conexão a ser feita
        public Conexao()
        {
            //instância o objeto
            connection = new SqlConnection();

            connection.ConnectionString = @"Data Source=Manutenção;Initial Catalog=lasertechbrasil;Integrated Security=True";

        }
        //se a conexão estiver fechada o método abre a conexão
        public SqlConnection Conectar()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
        //se a conexao estiver aberta o método abre a conexao
        public void Desconectar()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();

            }
        }

    }
}
