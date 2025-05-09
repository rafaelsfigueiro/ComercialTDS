using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;


namespace ComercialTDSClass
{
    public static class Banco
    {
        public static string? Strconn { get; set; }

        public static MySqlCommand Abrir(String strconn = "")
        {
            MySqlCommand cmd = new();
            Strconn = Strconn;
            if(Strconn ==string.Empty)
            Strconn = $@"server=127.0.0.1;database = comercialtdsdb01;user=root;password=";// caminho do server
            MySqlConnection cn = new(Strconn);
            //cn.connectionString = strconn;
            try
            {
                cn.Open(); //ao paasar por aqui terá uma conezão aberta
                cmd.Connection = cn;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                
            }
            return cmd;

        }
    }
}
