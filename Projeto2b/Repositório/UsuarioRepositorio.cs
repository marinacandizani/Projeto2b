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







    }
}
