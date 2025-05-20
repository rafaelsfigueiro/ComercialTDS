using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
     public class Categoria
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        public Categoria() { }

        public Categoria(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;

        }
        public Categoria(string nome, string sigla)
        {

            Nome = nome;
            Sigla = sigla;
        }
        // Método Inserir, atualizar, listar, ObterPorID(id)
        public void Inserir()
        {
            // Implementar lógica para inserir um novo nível no banco de dados
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_inserir";
            //cmd.Parameters.Add("spnome", MySqlDbType.VarChar).Value = Nome; //a mesma coisa que a linha de Biaxo
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);

            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        public static Categoria ObterPorId(int id)
        {
            Categoria categoria = new();
            // código do método
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from categoria where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                categoria.Id = dr.GetInt32(0);
                categoria.Nome = dr.GetString(1);
                categoria.Sigla = dr.GetString(2);
                // categoria = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));// esse método também funcionária, porem o de cima é mais elegante, e justifica os metodos contrutores criado
            }
            dr.Close(); // Abriu o dr Fechar para abrir um novo  select ou comando de banco
            cmd.Connection.Close(); // fechar a conexão
            return categoria;
        }
        public static List<Categoria> ObterLista()
        {
            List<Categoria> niveis = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from categoria order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                niveis.Add(new Categoria(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2))
                    );
                dr.Close(); // Abriu o dr Fechar para abrir um novo  select ou comando de banco
                cmd.Connection.Close(); // fechar a conexão
            }
            return niveis;
        }
        public bool Atualizar()
        {
            // como esse método não é estatico precisamos considerar que
            // as propriedadees já possuem valores atribuidos
            bool atualizado = false;
            if (Id < 1) return atualizado;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            if (cmd.ExecuteNonQuery() > 0)// comando de alteração 
            {
                atualizado = true;
            }
            cmd.Connection.Close(); // fechar a conexão
            return atualizado;
        }
    }
}
