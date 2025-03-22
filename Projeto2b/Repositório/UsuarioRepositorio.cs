using Projeto2b.Models;

namespace Projeto2b.Repositório
{
    public class UsuarioRepositorio
    {

        // Preparando a estrutura da conexao 

        private readonly string _connectionString;

        // Construtor
        public UsuarioRepositorio(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // Criando o metodo adicionar usuario 

        public void AdicionarUsuario(Usuario usuario)
        {
            using (var db = new Conexao(_connectionString))
            {
                var cmd = db.MySqlCommand();
                cmd.CommandText = "INSERT INTO Usuario (Nome, Email, Senha) VALUES (@Nome,@Email,@Senha)";
                cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
                cmd.ExecuteNonQuery();

            }
        }

        public Usuario ObterUsuario(string email)
        {
            using (var db = new Conexao(_connectionString))
            {
                var cmd = db.MySqlCommand();
                cmd.CommandText = "SELECT * FROM Usuario WHERE Email = @Email";
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Usuario
                        {
                            Id = reader.GetInt32("Id"),
                            Nome = reader.GetString("Nome"),
                            Email = reader.GetString("Email"),
                            Senha = reader.GetString("Senha"),

                        };

                    }

                }
                return null;
            }
        }
    }
}









