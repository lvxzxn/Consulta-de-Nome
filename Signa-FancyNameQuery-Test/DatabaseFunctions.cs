using MySql.Data.MySqlClient;

namespace Signa_FancyNameQuery_Test
{
    public class DatabaseFunctions
    {
        private static MySqlCommand Command = DatabaseQuery.Conexao.CreateCommand();
        public static void AdicionarDados() 
        {
            Command.CommandText = "SELECT COUNT(*) FROM pessoa";
            int count = Convert.ToInt32(Command.ExecuteScalar());

            if (count > 0) return;

            List <PessoaModel> Pessoas = new() 
            {
                new PessoaModel { Codigo = 0, NomeFantasia = "Leandro Danilo da Luz", CPF_CNPJ = "683.382.068-65" },
                new PessoaModel { Codigo = 1, NomeFantasia = "Sônia Giovana Cecília Ramos", CPF_CNPJ = "405.296.641-43" },
                new PessoaModel { Codigo = 2, NomeFantasia = "Thiago Felipe Enrico Brito", CPF_CNPJ = "951.595.538-60" },
                new PessoaModel { Codigo = 3, NomeFantasia = "Diogo Anthony Ribeiro", CPF_CNPJ = "397.674.400-03" },
                new PessoaModel { Codigo = 4, NomeFantasia = "Mariane Letícia Lara Alves", CPF_CNPJ = "073.683.239-40" },
                new PessoaModel { Codigo = 5, NomeFantasia = "Filipe Carlos Eduardo Vieira", CPF_CNPJ = "019.495.514-15" },
                new PessoaModel { Codigo = 6, NomeFantasia = "Rita Natália Flávia Sales", CPF_CNPJ = "045.271.851-10" },
                new PessoaModel { Codigo = 7, NomeFantasia = "Daniela Bruna Alice Carvalho", CPF_CNPJ = "320.837.875-01" },
                new PessoaModel { Codigo = 8, NomeFantasia = "Mariah Vanessa Rita Barbosa", CPF_CNPJ = "352.258.185-79" },
                new PessoaModel { Codigo = 9, NomeFantasia = "Samuel Pedro Henrique da Mata", CPF_CNPJ = "748.086.854-50" },
                new PessoaModel { Codigo = 10, NomeFantasia = "Erick Ryan Nunes", CPF_CNPJ = "767.790.896-99" },
            };

            foreach (var Pessoa in Pessoas) 
            {
                string SqlStatement = string.Format("INSERT INTO pessoa (PESSOA_ID, NOME_FANTASIA, CNPJ_CPF) VALUES ({0}, '{1}', '{2}')", Pessoa.Codigo, Pessoa.NomeFantasia, Pessoa.CPF_CNPJ);
                Command.CommandText = SqlStatement;
                Command.ExecuteNonQuery();
            }
        }
    }
}
