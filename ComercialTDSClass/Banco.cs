using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;


namespace ComercialTDSClass
{
    public static class Banco
    {
        public static string StrConn { get; set; }
        public static MySqlCommand Abrir(string strconn = "")
        {
            MySqlCommand cmd = new();
            StrConn = strconn;

            if (StrConn == string.Empty)
                StrConn = $@"server=localhost;database=comercialtdsdb01;user=root;password=";
            MySqlConnection cn = new(StrConn);
            //cn.ConnectionString = Strconn;
            try
            {
                cn.Open();// ao passar por aqui terá uma connexão aberta
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