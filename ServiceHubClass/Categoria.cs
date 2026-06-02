using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic; // List<T> está aqui
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHubClass
{
    public class Categoria
    {
        
        // Atributos (Campos)
        // private int id;
        // private string? nome;
        // private string? sigla;
        // Propriedades

        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Sigla { get; set; }

        // construtores (métodos)
        public Categoria()
        {
            Id = 0;
        }

        public Categoria(string? nome, string? sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        public Categoria(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        // Métodos (Funcionalidades RFs) - inserir, atualizar, listar, obterPorId(id), excluir(id)

        public void Inserir()
        {
            
            var cmd = Banco.Abrir(); // Abre a conexão com o banco de dados
            if (cmd.Connection.State == ConnectionState.Open) // Verifica se a conexão foi aberta com sucesso antes de prosseguir
            {
                cmd.CommandType = CommandType.StoredProcedure; // Define que o comando executado será uma Stored Procedure (Procedimento Armazenado)
                cmd.CommandText = "sp_categoria_insert"; // Especifica o nome da Stored Procedure que está no banco de dados
                // Passa as propriedades da classe (Nome e Sigla) como parâmetros para a Procedure
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spsigla", Sigla);
                Id = Convert.ToInt32(cmd.ExecuteScalar()); // Executa a Procedure no banco e converte o retorno para salvar no ID da categoria
                cmd.Connection.Close();
            }
        }

        public static Categoria ObterPorId(int id)
        {
            // ALERTA: Instanciação desnecessária. Se o ID não existir, você gastou memória à toa.
            // O ideal é iniciar como: Categoria cat = null;
            Categoria cat = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            // CRÍTICO (SQL INJECTION): Nunca use interpolação ($"") ou concatenação para passar parâmetros no SQL.
            // Embora 'id' seja int, isso é uma má prática perigosa. Use Command.Parameters.AddWithValue().
            // MELHORIA: Evite "SELECT *". Defina explicitamente as colunas que precisa (ex: SELECT id, nome...).
            cmd.CommandText = $"select * from categorias where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                cat = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            // RISCO DE VAZAMENTO (Memory Leak): Se ocorrer um erro no banco antes de chegar aqui,
            // o código trava, o .Close() nunca é executado e a conexão fica "presa" aberta no banco.
            // RESOLUÇÃO: Envolva o comando e o reader em um bloco 'using'.
            dr.Close();
            cmd.Connection.Close();
            return cat;
        }

        public static List<Categoria> ObterLista(string busca = "")
        {
            List<Categoria> categorias = new List<Categoria>();
            var cmd = Banco.Abrir();  // Abre a conexâo com o Banco de dados
            //if (cmd.Connection.State == ConnectionState.Open) // Validar se a conexão realmente abriu antes de prosseguir.
            //{
                if (busca!= "")
                {
                    cmd.CommandText = $"Select * from categorias" + "where nome like '%"+busca+"%' order by nome";
                }
                else
                {
                    cmd.CommandText = "select * from categorias order by nome";
                }
                cmd.CommandType = CommandType.Text;
                
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    categorias.Add(new(dr.GetInt32(0),dr.GetString(1),dr.GetString(2)??""));
                }
                dr.Close();
                cmd.Connection.Close();
           // }
            return categorias;
        }
       

        public bool Atualizar()
        {
            // como este método não é estático, precisamos considerar
            // que as propriedades já possuam valores atribuídos antes de chamá-lo
            bool atualizada = false;
            if (Id < 1) return atualizada;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            if (cmd.ExecuteNonQuery() > 0) atualizada = true;
            cmd.Connection.Close();
            return atualizada;
        }

        public void Excluir(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.ExecuteNonQuery(); // Retorna o numero de linhas afetadas
            cmd.Connection.Close();
        }

    }
}
