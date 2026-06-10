using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using ServiceHubClass;

namespace ServiceHubClass
{
        // Propriedades
    public class Produto
    {

        // Propriedades / Getters e Setters
        public int Id { get; set; }
        public string? CodBarras { get; set; }
        public string? Descricao { get; set; }
        public double ValorUnit { get; set; }
        public string? UnidadeVenda { get; set; }
        public Categoria? Categoria { get; set; }
        public double EstoqueMinimo { get; set; }
        public double ClasseDesconto { get; set; }
        public byte[]? Imagem { get; set; } // Permitindo nulo caso o produto não tenha foto inicialmente
        public DateTime DataCad { get; set; }
        public bool Descontinuado { get; set; }

        // Construtor Vazio
        public Produto()
        {
        }

        // Construtor Procedure para Insert
        public Produto(string? codBarras, string? descricao, double valorUnit, string? unidadeVenda, Categoria? categoria, double estoqueMinimo, double classeDesconto, byte[]? imagem = null)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
        }

        // Construtor Procedure para Update
        public Produto(int id, string? codBarras, string? descricao, double valorUnit, string? unidadeVenda, Categoria? categoria, double estoqueMinimo, double classeDesconto, byte[]? imagem = null)
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
        }

        // Construtor Completo
        public Produto(int id, string? codBarras, string? descricao, double valorUnit, string? unidadeVenda, Categoria? categoria, double estoqueMinimo, double classeDesconto, byte[]? imagem, DateTime dataCad, bool descontinuado)
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

        // MÉTODOS DE BANCO DE DADOS

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";

            // Passa Valores para a Procedure
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria?.Id); // Uso do ?. previne quebras se nulo
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);

            // Tratamento seguro para persistência de imagens em formato binário (BLOB)
            cmd.Parameters.AddWithValue("spimagem", Imagem ?? (object)DBNull.Value);

            // ExecuteScalar recupera o ID auto-incremental gerado pela procedure
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public bool Atuaiszar() // Mantido o nome do seu escopo, caso queira corrigir digite 'Atualizar'
        {
            return Atualizar();
        }

        public bool Atualizar()
        {
            bool atualizado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";

            // Passa Valores para a Procedure
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria?.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            cmd.Parameters.AddWithValue("spimagem", Imagem ?? (object)DBNull.Value);

            if (cmd.ExecuteNonQuery() > 0)
            {
                atualizado = true;
            }
            cmd.Connection.Close();
            return atualizado;
        }

        public static Produto ObterPorId(int id)
        {
            Produto produto = new Produto();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from produtos where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                produto = new(dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    null, // Passa null direto no lugar dos bytes da imagem
                    dr.GetDateTime(9),
                    dr.GetBoolean(10));
            }
            dr.Close();
            cmd.Connection.Close();
            return produto;
        }

        public static List<Produto> ObterLista(string busca = "")
        {
            List<Produto> produtos = new List<Produto>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (string.IsNullOrWhiteSpace(busca))
            {
                cmd.CommandText = "SELECT * FROM produtos ORDER BY descricao";
            }
            else
            {
                cmd.CommandText = "SELECT * FROM produtos WHERE cod_barras LIKE @busca ORDER BY descricao";
                cmd.Parameters.AddWithValue("@busca", "%" + busca + "%");
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(new(dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    null, // Passa null direto no lugar dos bytes da imagem
                    dr.GetDateTime(9),
                    dr.GetBoolean(10)
                    )
                );
            }
            dr.Close();
            cmd.Connection.Close();
            return produtos;
        }

        public static bool Excluir(int id)
        {
            bool excluido = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            // Exclusão Lógica (Soft Delete) alterando o estado do produto para descontinuado
            cmd.CommandText = "UPDATE produtos SET descontinuado = 1 WHERE id = @id";
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