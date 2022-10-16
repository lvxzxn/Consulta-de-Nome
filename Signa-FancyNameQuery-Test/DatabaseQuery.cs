using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Signa_FancyNameQuery_Test
{
    public class DatabaseQuery
    {
        private static string Username = "root";
        private static string Password = "";
        private static string Database = "fmq_db";
        private static readonly string connection = $"Server=localhost;Database={Database};Uid={Username};Pwd={Password}";

        public static MySqlConnection Conexao;

        public static async Task Conectar()
        {
            Conexao = new MySqlConnection(connection);
            try
            {
                await Conexao.OpenAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
        }
    }
}
