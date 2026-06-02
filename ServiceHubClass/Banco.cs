using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ServiceHubClass
{
    public class Banco
    {

        // string de conexão com o banco de dados (Mariadb)
        public static string? StrConn {  get; set; }

        // Método para abrir conexão com o banco - entrega uma conexão aberta,
        // no objeto de comando Sql (Um objeto do tipo MySqlCommand)
        public static MySqlCommand Abrir(string strconn = "")
        {
            MySqlCommand cmd = new MySqlCommand();
            StrConn = strconn;
            if (strconn == string.Empty)
                // StrConn = $@"server=10.91.47.48;database = servicehubdb01;user=root;password=Password";
                StrConn = $@"server=10.91.47.45;database = comercialti101;user=root;password=P@ssw0rd";
            MySqlConnection cn = new MySqlConnection(StrConn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message);
            
            }
            return cmd;
        }


        

    }
}
