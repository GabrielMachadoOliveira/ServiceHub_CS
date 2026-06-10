using System.Data;

namespace ServiceHubClass
{
    public class Usuario
    {
        private bool updated;

        // Propriedades
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public Nivel? nivel { get; set; }
        public bool Ativo { get; set; }

        // Construtores
        public Usuario()
        {


        }

        //Construtor Completo
        public Usuario(int id, string? nome, string? email, string? senha, Nivel? nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            this.nivel = nivel;
            Ativo = ativo;
        }

        //Construtor para Procedure Insert
        public Usuario(string? nome, string? email, string? senha, Nivel nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            this.nivel = nivel;
        }

        //Construtor para Procedure Update
        public Usuario(int id, string? nome, string? email, string? senha, Nivel nivel)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            this.nivel = nivel;
        }

        // Métodos de Banco de Dados

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";

            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", nivel.Id);
            Id = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
        }

        public bool Atualizar()
        {
            bool atualizado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_altera";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", nivel.Id);
            if (cmd.ExecuteNonQuery() > 0)
            {
                atualizado = true;
            }
            cmd.Connection.Close();
            return atualizado;
        }

        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new Usuario();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                    );
            }
            return usuario;
        }

        public static List<Usuario> ObterLista(string busca = "")
        {
            List<Usuario> usuarios = new();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            if (busca != "")
            {
                cmd.CommandText = @"SELECT * FROM usuarios WHERE nome LIKE @busca ORDER BY nome";

                cmd.Parameters.AddWithValue("@busca", "%" + busca + "%");
            }
            else
            {
                cmd.CommandText = @"SELECT * FROM usuarios ORDER BY nome";
            }

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                usuarios.Add(new Usuario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                ));
            }

            dr.Close();
            cmd.Connection.Close();

            return usuarios;
        }

        public static bool Excluir(int id)
        {
            bool excluido = false;

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "DELETE FROM usuarios WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            if (cmd.ExecuteNonQuery() > 0)
            {
                excluido = true;
            }

            cmd.Connection.Close();

            return excluido;
        }
    }
}