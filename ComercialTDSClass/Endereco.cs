using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ComercialTDSClass
{
    class Endereco
    {


        public int Id { get; set; }
        public int ClienteID { get; set; }
        public int Cep { get; set; }
        public string? Logradouro { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? TipoEndereco { get; set; }

        public Endereco(int id, int clienteID, int cep, string? logradouro, int numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoEndereco)
        {
            Id = id;
            ClienteID = clienteID;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }
        public Endereco(int id, int cep, string? logradouro, int numero, string? bairro, string? cidade, string? uf, string? tipoEndereco)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }
        public Endereco(int cep, string? logradouro, int numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoEndereco)
        {


            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }
        public Endereco(string? bairro, string? cidade, string? uf, string? tipoEndereco)
        {

            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }
        public Endereco(int id, int cep)
        {
            Id = id;
            Cep = cep;

        }



        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipoendereco", TipoEndereco);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public void Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipoendereco", TipoEndereco);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public List<Endereco> ObterListaPorClienteId(int idCliente)
        {
            List<Endereco> enderecos = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = "sp_endereco_insert";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add(new Endereco(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    dr.GetInt32(2),
                    dr.GetString(3),
                    dr.GetInt32(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetString(9)
                ));
            }
            dr.Close();
            return enderecos;
        }
        public List<Endereco> DeletarEndereco(int idendereco)
        {
            List<Endereco> enderecos = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = "sp_endereco_delete";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add(new Endereco(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    dr.GetInt32(2),
                    dr.GetString(3),
                    dr.GetInt32(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetString(9)
                ));
            }
            dr.Close();
            return enderecos;

        }

    }
}
