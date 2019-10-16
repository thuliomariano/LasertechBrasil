using System.Data.SqlClient;

namespace Registro_de_RMA.DAL
{
    public class Conexao
    {
        SqlConnection connection;

        public Conexao()
        {
            connection = new SqlConnection();

            connection.ConnectionString = @"Data Source=Manutenção;Initial Catalog=lasertechbrasil;Integrated Security=True";
   
        }

        public SqlConnection Conectar()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public void Desconectar()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();

            }
        }

    }
}
