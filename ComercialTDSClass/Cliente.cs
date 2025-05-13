using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass;

class Cliente
{


    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public DateTime DataCard { get; set; }
    public bool Ativo { get; set; }

    public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime dataNascimento, DateTime dataCard, bool ativo)
    {
        Id = id;
        Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
        Email = email;
        DataNascimento = dataNascimento;
        DataCard = dataCard;
        Ativo = ativo;
    }
    public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime dataNascimento)
    {

        Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
        Email = email;
        DataNascimento = dataNascimento;


    }
    public void Inserir()
    {
        // Implementar lógica para inserir cliente no banco de dados
        var cmd = Banco.Abrir();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "sp_cliente_insert";
        cmd.Parameters.AddWithValue("@nome", Nome);
        cmd.Parameters.AddWithValue("@cpf", Cpf);
        cmd.Parameters.AddWithValue("@telefone", Telefone);
        cmd.Parameters.AddWithValue("@email", Email);
        cmd.Parameters.AddWithValue("@data_nascimento", DataNascimento);
        cmd.ExecuteNonQuery();
        cmd.Connection.Close();
    }

    public void Update()
    {
        // Implementar lógica para alterar cliente no banco de dados
        var cmd = Banco.Abrir();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "sp_cliente_update";
        cmd.Parameters.AddWithValue("@id", Id);
        cmd.Parameters.AddWithValue("@nome", Nome);
        cmd.Parameters.AddWithValue("@cpf", Cpf);
        cmd.Parameters.AddWithValue("@telefone", Telefone);
        cmd.Parameters.AddWithValue("@email", Email);
        cmd.Parameters.AddWithValue("@data_nascimento", DataNascimento);
        cmd.ExecuteNonQuery();
        cmd.Connection.Close();
    }
    public static List<Endereco> ObterLista()
    {
        List<Endereco> enderecos = new();
        var cmd = Banco.Abrir();
        cmd.CommandText = $"select * from enderecos";
        var dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            enderecos.Add(new(dr.GetInt32(0),
                        dr.GetInt32(1),
                        dr.GetInt32(2),
                        dr.GetString(3),
                        dr.GetInt32(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(7),
                        dr.GetString(8),
                        dr.GetString(9)
                        )
                );
        }
        return enderecos;



    }
    public static List<Endereco> ObterListaPostCLienteID(int idCliente)
    {
        List<Endereco> enderecos = new();
        var cmd = Banco.Abrir();
        cmd.CommandText = $"select * from enderecos where id = {idCliente}";
        var dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            enderecos.Add(new(dr.GetInt32(0),
                        dr.GetInt32(1),
                        dr.GetInt32(2),
                        dr.GetString(3),
                        dr.GetInt32(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(7),
                        dr.GetString(8),
                        dr.GetString(9)
                        )
                );
        }
        return enderecos;
    }

}