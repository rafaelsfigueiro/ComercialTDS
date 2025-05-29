using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass;

public class Cliente
{


    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public DateTime DataCadastro { get; set; }
    public bool Ativo { get; set; }
    public List<Endereco>? Enderecos { get; set; } = new List<Endereco>();
    public Cliente() { }

    public Cliente(string nome, string cpf, string telefone, string email, DateTime dataNascimento, DateTime dataCadastro, bool ativo, List<Endereco>? enderecos)
    {// este é o construtor que utilizaremos para inserir o cliente
        Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
        Email = email;
        DataNascimento = dataNascimento;
    }
    public Cliente(int id, string nome, string cpf, string telefone, string email, DateTime dataNascimento, DateTime dataCadastro, bool ativo, List<Endereco>? enderecos)
    {
        Id = id;
        Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
        Email = email;
        DataNascimento = dataNascimento;
        DataCadastro = dataCadastro;
        Ativo = ativo;
        Enderecos = enderecos;
    }
    public Cliente(int id, string nome, string cpf, string telefone, string email, DateTime dataNascimento, DateTime dataCadastro, bool ativo)
    {
        Id = id;
        Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
        Email = email;
        DataNascimento = dataNascimento;
        DataCadastro = dataCadastro;
        Ativo = ativo;
    }


    public Cliente(string nome, string cpf, string telefone, string email, DateTime dataNascimento)
    {// este é o construtor que utilizaremos para inserir o cliente
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
    public static List<Cliente> ObterLista()
    {
        List<Cliente> clientes = new();
        var cmd = Banco.Abrir();
        cmd.CommandText = $"select * from clientes order by nome";
        var dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            clientes.Add(new(
                          dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetDateTime(4),
                        dr.GetDateTime(5),
                        dr.GetBoolean(6),
                       Endereco.ObterListaPorClienteId(dr.GetInt32(0))
                    )
            );
          
        }
        dr.Close(); // Fechar o dr para abrir um novo select ou comando de banco
        cmd.Connection.Close(); // fechar a conexão
        return clientes;
    }
        
        

    public static Cliente ObterPorId(int id)
    {
       Cliente cliente = new();
        var cmd = Banco.Abrir();
        cmd.CommandText = $"select * from clientes where id = {id}";
        var dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            cliente = new(
                             dr.GetInt32(0),
                             dr.GetString(1),
                             dr.GetString(2),
                             dr.GetString(3),
                             dr.GetString(4),
                             dr.GetDateTime(4),
                             dr.GetDateTime(5),
                             dr.GetBoolean(6),
                             Endereco.ObterListaPorClienteId(dr.GetInt32(0))
                 );
        }
        dr.Close(); // Fechar o dr para abrir um novo select ou comando de banco
        cmd.Connection.Close();
        return cliente;
    }

}