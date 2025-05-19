using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace ComercialTDSClass
{
    class Produto
    {


        public int Id { get; set; }
        public string? CodBarras { get; set; }
        public string? Descricao { get; set; }
        public double? ValorUnit { get; set; }
        public string? UnidadeVenda { get; set; }
        public Categoria? Categoria { get; set; }
        public double? EstoqueMinimo { get; set; }
        public double? ClasseDesconto { get; set; }
        public Stream Imagem { get; set; }       
        
        public DateTime DataCard { get; set; }

        public  bool Descontinuado { get; set; }
        public Produto() 
        {
            Categoria = new();
        }
       


        public Produto(int id, string? codBarras, string? descricao, double? valorUnit, string? unidadeVenda, Categoria? categoria, double? estoqueMinimo, double? classedesconto, Stream imagem, DateTime dataCard, bool descontinuado)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classedesconto;
            Imagem = imagem;
            DataCard = dataCard;
            Descontinuado = descontinuado;
        }

        public Produto( string? codBarras, string? descricao, double? valorUnit, string? unidadeVenda, Categoria? categoria, double? estoqueMinimo, double? classedesconto, Stream imagem, DateTime dataCard, bool descontinuado)
        {
            
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classedesconto;
            Imagem = imagem;
            DataCard = dataCard;
            Descontinuado = descontinuado;
        }
        public Produto ( string? codBarras, string? descricao, double? valorUnit, string? unidadeVenda, Categoria? categoria, double? estoqueMinimo, double? classedesconto, Stream imagem)
        {
          
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classedesconto;
            Imagem = imagem;
           
        }
        public void Inserir() 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras",CodBarras);
            cmd.Parameters.AddWithValue("spdescricao",Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit",ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda",ValorUnit);
            cmd.Parameters.AddWithValue("spcategoria_id",Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo",EstoqueMinimo);
            cmd.Parameters.AddWithValue("spcasse_desconto",ClasseDesconto);
            cmd.Parameters.AddWithValue("spimagem",Imagem);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }
        public bool Atualizar()
        {
            bool atualizado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spid",Id);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", ValorUnit);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spcasse_desconto", ClasseDesconto);
            cmd.Parameters.AddWithValue("spimagem", Imagem);
            if (cmd.ExecuteNonQuery() > 0)
                atualizado = true;
            cmd.Connection.Close();
                return atualizado;
               
        }
        public static Produto ObterPorId(int id)
        {
            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produto whre id = {id}";
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
                    dr.GetStream(8),
                    dr.GetDateTime(9),
                    dr.GetBoolean(10)
                    );
            }
            dr.Close();
            cmd.Connection.Close();
            return produto;
        }
        public static List<Produto> ObterLista(int id)
        {
            List<Produto> produtos= new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produto whre id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                produtos.Add ( new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    dr.GetStream(8),
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
