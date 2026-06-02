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

        public Categoria(int id)
        {
            Id = id;
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

        // Métodos (Funcionalidades RFs)  - inserir, atualizar, ObterLista, obterPorId(id), excluir(id)
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_categoria_insert";
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spsigla", Sigla);
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
        }

        public static Categoria ObterPorId(int id)
        {
            Categoria cat = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from categorias where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cat = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            dr.Close();
            cmd.Connection.Close();
            return cat;
        }

        public static List<Categoria> ObterLista(string busca = "")
        {
            List<Categoria> categorias = new List<Categoria>();
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                if (busca != "")
                {
                    cmd.CommandText = $"Select * from categorias where nome like '%" + busca + "%'" +
                        "order by nome";
                }
                else
                {
                    cmd.CommandText = "Select * from categorias order by nome";
                }
                cmd.CommandType = CommandType.Text;

                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    categorias.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)));
                }
                dr.Close();
                cmd.Connection.Close();
            }
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

        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_delete";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

    }
}
