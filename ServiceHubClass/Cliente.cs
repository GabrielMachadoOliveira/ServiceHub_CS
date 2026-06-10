using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceHubClass;

namespace ServiceHubClass
{
    internal class Cliente
    {
        //Getters e Setters
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime DataCad { get; set; }
        public bool Ativo { get; set; }

        //Construtores
        //Vazio
        public Cliente()
        {

        }
        //Completo
        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime dataNasc, DateTime dataCad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = dataNasc;
            DataCad = dataCad;
            Ativo = ativo;
        }
        //Procedure Insert
        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime dataNasc)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = dataNasc;
        }

        //Procedure Update
        public Cliente(int id, string? nome, string? cpf, string? telefone, DateTime dataNasc)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            DataNasc = dataNasc;
        }


        //Métodos
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";

            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
            Id = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
        }

        public bool Atualizar()
        {
            bool atualizado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
            if (cmd.ExecuteNonQuery() > 0)
            {
                atualizado = true;
            }
            cmd.Connection.Close();
            return atualizado;
        }

        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new Cliente();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7)
                    );
            }
            return cliente;

        }

        public static List<Cliente> ObterLista(string busca = "")
        {
            List<Cliente> clientes = new();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            if (busca != "")
            {
                cmd.CommandText = @"SELECT * FROM clientes WHERE nome LIKE @busca ORDER BY nome";

                cmd.Parameters.AddWithValue("@busca", "%" + busca + "%");
            }
            else
            {
                cmd.CommandText = @"SELECT * FROM clientes ORDER BY nome";
            }

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                clientes.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7)
                ));
            }

            dr.Close();
            cmd.Connection.Close();

            return clientes;
        }

        public static bool Excluir(int id)
        {
            bool excluido = false;

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "DELETE FROM clientes WHERE id = @id";
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