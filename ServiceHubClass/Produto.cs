using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ServiceHubClass
{
        // Propriedades
    public class Produto
    {

        // Propiedades

        public int Id { get; set; }

        public string? CodBarras { get; set; }

        public string? Descricao { get; set; }

        public double ValorUnit { get; set; }

        public string? UnidadeVenda { get; set; }

        public Categoria? Categoria { get; set; }

        public double EstoqueMinimo { get; set; }

        public double ClasseDesconto { get; set; }

        public byte[] Imagem { get; set; }

        public DateTime DataCad { get; set; }

        public bool Descontinuado { get; set; }

        // Métodos Construtores

        public Produto()

        {

        }

        public Produto(string? codBarras, string? descricao, double valorUnit, string? unidadeVenda,

            Categoria? categoria, double estoqueMinimo, double classeDesconto)

        {

            CodBarras = codBarras;

            Descricao = descricao;

            ValorUnit = valorUnit;

            UnidadeVenda = unidadeVenda;

            Categoria = categoria;

            EstoqueMinimo = estoqueMinimo;

            ClasseDesconto = classeDesconto;

        }

        public Produto(int id, string? codBarras, string? descricao, double valorUnit, string? unidadeVenda,

            Categoria? categoria, double estoqueMinimo, double classeDesconto)

        {

            Id = id;

            CodBarras = codBarras;

            Descricao = descricao;

            ValorUnit = valorUnit;

            UnidadeVenda = unidadeVenda;

            Categoria = categoria;

            EstoqueMinimo = estoqueMinimo;

            ClasseDesconto = classeDesconto;

        }

        public Produto(int id, string? codBarras, string? descricao, double valorUnit, string? unidadeVenda,

            Categoria? categoria, double estoqueMinimo, double classeDesconto, byte[] imagem, DateTime dataCad, bool descontinuado)

        {

            Id = id;

            CodBarras = codBarras;

            Descricao = descricao;

            ValorUnit = valorUnit;

            UnidadeVenda = unidadeVenda;

            Categoria = categoria;

            EstoqueMinimo = estoqueMinimo;

            ClasseDesconto = classeDesconto;

            Imagem = imagem;

            DataCad = dataCad;

            Descontinuado = descontinuado;

        }

        // Métodos (Inserir, BuscarPorId, ObterLista(texte = ""), Atualizar)

        public void Inserir()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", CodBarras);
            cmd.Parameters.AddWithValue("spclasse_desconto", CodBarras);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }

        public bool Atualizar()
        {
            bool atualizado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spids", Id);
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            if (cmd.ExecuteNonQuery() > 0)
                atualizado = true;
            cmd.Connection.Close();
            return atualizado;
        }

        public static Produto ObterPorId(int id)
        {
            Produto produto = new();// vazio
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from produtos where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                produto = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6), 
                    dr.GetDouble(7),
                    (byte[])dr.GetValue(8),
                    dr.GetDateTime(9),
                    dr.GetBoolean(10)
                );
            }
            dr.Close();
            cmd.Connection.Close();
            return produto;
        }

        public static List<Produto> ObterLista()
        {
            List<Produto> produtos = new();// vazio
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from produtos order by descricao";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    (byte[])dr.GetValue(8),
                    dr.GetDateTime(9),
                    dr.GetBoolean(10)
                ));
            }
            dr.Close();
            cmd.Connection.Close();
            return produtos;
        }

    }
}
