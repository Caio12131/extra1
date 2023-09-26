using System.Net;
using System;

namespace extra1
{
    public partial class txtName : Form
    {
        private object txtNome;



        private List<Pessoa> peopleList = new List<Pessoa>();

        public txtName()
        {
            InitializeComponent();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seja Bem Vindo, " + PrimeiroNome.Text + ' '+ UltimoNome.Text, "Saudação!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Obtém as informações inseridas pelo usuário nos controles de entrada
            string primeiroNome = PrimeiroNome.Text;
            string ultimoNome = UltimoNome.Text;
            string rua = RuaInfo.Text;
            string cidade = CidadeInfo.Text;
            string cep = CepInfo.Text;

            // Cria um objeto Address com as informações do endereço
            Endereco address = new Endereco(rua, cidade, cep);

            // Cria um objeto Person com as informações do usuário
            Pessoa person = new Pessoa(primeiroNome, ultimoNome, address);

            // Adiciona a pessoa à lista peopleList
            peopleList.Add(person);

            // Limpa os controles de entrada após adicionar a pessoa
            PrimeiroNome.Clear();
            UltimoNome.Clear();
            RuaInfo.Clear();
            CidadeInfo.Clear();
            CepInfo.Clear();

            // Exibe uma mensagem de sucesso (opcional)
            MessageBox.Show("Pessoa adicionada com sucesso!");
        }

        private void começo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        // Outros métodos e eventos do formulário



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {



        }
  
        
            private void CadPes_Click(object sender, EventArgs e)
            {
                string searchName = CadNome.Text; // Obtém o nome digitado pelo usuário

                // Encontra todas as pessoas cujo FirstName corresponde ao nome pesquisado
                List<Pessoa> matchingPeople = peopleList.FindAll(person =>
                    string.Equals(person.PrimeiroNome, searchName, StringComparison.OrdinalIgnoreCase));

                if (matchingPeople.Count > 0)
                {
                    // Cria uma mensagem com as informações de todas as pessoas correspondentes
                    string message = "Pessoa encontrada com o nome " + searchName + ":\n\n";

                    foreach (var person in matchingPeople)
                    {
                        message += $"Nome: {person.PrimeiroNome} {person.UltimoNome}\n" +
                                   $"Endereço: {person.Endereco.Rua}, {person.Endereco.Cidade}, {person.Endereco.Cep}\n\n";
                    }

                    // Exibe a mensagem em um MessageBox
                    MessageBox.Show(message, "Informações da Pessoa Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Se não houver correspondências, exibe uma mensagem de aviso
                    MessageBox.Show("Nenhuma pessoa encontrada com o nome " + searchName + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
    


