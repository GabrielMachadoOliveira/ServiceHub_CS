using ServiceHubClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ServiceHubClass
{
    public class Nivel
    {
        //Atributos
        private int id;
        private string? nome;
        private string? sigla;

        //Getters e Setters
        public int Id { get => id; set => id = value; }
        public string? Nome { get => nome; set => nome = value; }
        public string? Sigla { get => sigla; set => sigla = value; }

        //Construtores
        public Nivel()
        {

        }
        public Nivel(int id, string? nome, string? sigla)
        {
            this.id = id;
            this.nome = nome;
            this.sigla = sigla;
        }

        public Nivel(int id, string? nome)
        {
            this.id = id;
            this.nome = nome;
        }
        public Nivel(string? nome, string? sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
        }
        public Nivel(int id)
        {
            this.id = id;
        }

        //Métodos
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_nivel_insert";
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spsigla", Sigla);
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
        }

        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new Nivel();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from niveis where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                nivel = new Nivel(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            dr.Close();
            cmd.Connection.Close();
            return nivel;
        }

        public static List<Nivel> ObterLista(string busca = "")
        {
            List<Nivel> niveis = new List<Nivel>();
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                if (busca != "")
                {
                    cmd.CommandText = $"select * from niveis where nome like '%{busca}%' order by nome";
                }
                else
                {
                    cmd.CommandText = $"select * from niveis order by nome";
                }
                cmd.CommandType = CommandType.Text;
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    niveis.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)));
                }
                dr.Close();
                cmd.Connection.Close();
            }
            return niveis;
        }

        public bool Atualizar()
        {
            bool atualizada = false;
            if (Id < 1)
            {
                return atualizada;
            }
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update niveis set nome = nome, sigla = sigla where id = {id}";
            cmd.Parameters.AddWithValue("id", Id);
            cmd.Parameters.AddWithValue("nome", Nome);
            cmd.Parameters.AddWithValue("sigla", Sigla);
            if (cmd.ExecuteNonQuery() > 0)
            {
                atualizada = true;
            }
            cmd.Connection.Close();
            return atualizada;

        }


        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"DELETE FROM niveis WHERE id = {id}";
            cmd.Parameters.AddWithValue("id", Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}