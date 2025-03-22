using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto2b.Repositório
{

        public class Conexao : IDisposable
        {
            private MySqlConnection _connection;

            //
            public MySqlCommand MySqlCommand()
            {
                return _connection.CreateCommand();
            }


            // Abre a conexão
            public Conexao(string connectionString)
            {
                _connection = new MySqlConnection(connectionString);
                _connection.Open();
            }

          

            // Fecha conexão
            public void Dispose()
            {
                if (_connection != null && _connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                    _connection.Dispose();
                }
            }
        }
    }
}
   
    

