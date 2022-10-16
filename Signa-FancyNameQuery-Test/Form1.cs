using MySql.Data.MySqlClient;

namespace Signa_FancyNameQuery_Test
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            Execute();
            DatabaseFunctions.AdicionarDados();
        }

        private static PessoaModel? RegistroSelecionado;
        private static List<PessoaModel> Pessoas = new();

        public void AdicionarPessoa(int Cod, string NomeFant, string CPF_CNPJ) 
        {
            string[] Pessoa = { Cod.ToString(), NomeFant, CPF_CNPJ };

            Pessoas.Add(new PessoaModel() 
            {
                Codigo = Cod,
                NomeFantasia = NomeFant,
                CPF_CNPJ = CPF_CNPJ
            });


            ListViewItem PessoaItem = new(Pessoa);
            listPessoas.Items.Add(PessoaItem);
        }

        private void MontarLista() 
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM pessoa", DatabaseQuery.Conexao);

            using MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int PESSOA_ID = Convert.ToInt32(reader["PESSOA_ID"]);
                string? NOME_FANTASIA = reader["NOME_FANTASIA"].ToString();
                string? CNPJ_CPF = reader["CNPJ_CPF"].ToString();
                AdicionarPessoa(PESSOA_ID, NOME_FANTASIA!, CNPJ_CPF!);
            }
        }

        private void LimparLista() 
        {
            foreach (ListViewItem Item in listPessoas.Items)
                listPessoas.Items.Remove(Item);

            if (Pessoas.Count > 0)
                Pessoas.Clear();
        }

        private void listPessoas_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
                return;

            PessoaModel? Pessoa = Pessoas
                .Where(pessoa => pessoa.Codigo.ToString() == e.Item.Text)
                .Select(v => v).First();

            RegistroSelecionado = Pessoa;

            txtCpfCnpjPessoa.Text = RegistroSelecionado.CPF_CNPJ;
            txtNomePessoa.Text = RegistroSelecionado.NomeFantasia;
            txtCodigoPessoa.Text = RegistroSelecionado.Codigo.ToString();
        }

        private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            PessoaModel.UltimoNome = RegistroSelecionado!.NomeFantasia;

            RegistroSelecionado = new()
            {
                NomeFantasia = txtNomePessoa.Text,
                Codigo = int.Parse(txtCodigoPessoa.Text),
                CPF_CNPJ = txtCpfCnpjPessoa.Text
            };

            MySqlCommand PessoaExisteTratamento = new($"SELECT * FROM pessoa WHERE NOME_FANTASIA = '{PessoaModel.UltimoNome}' ", DatabaseQuery.Conexao);
            var Executar = PessoaExisteTratamento.ExecuteReader();

            if (!Executar.HasRows) 
            {
                MessageBox.Show("Nome não encontrado.", "Erro", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }

            Executar.Close();

            MySqlCommand? AtualizarRegistro = DatabaseQuery.Conexao.CreateCommand();

            AtualizarRegistro.CommandText = $"UPDATE pessoa SET NOME_FANTASIA = '{txtNomePessoa.Text}' WHERE NOME_FANTASIA = '{PessoaModel.UltimoNome}'";
            AtualizarRegistro.ExecuteNonQuery();

            LimparLista();
            MontarLista();
        }
        private void btnMontarLista_Click(object sender, EventArgs e) => MontarLista();
        private void btnLimpar_Click(object sender, EventArgs e) => LimparLista();
        private async void Execute() => await DatabaseQuery.Conectar();
    }
}