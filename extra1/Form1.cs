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
            MessageBox.Show("Seja Bem Vindo, " + PrimeiroNome.Text + ' '+ UltimoNome.Text, "Sauda��o!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Obt�m as informa��es inseridas pelo usu�rio nos controles de entrada
            string primeiroNome = PrimeiroNome.Text;
            string ultimoNome = UltimoNome.Text;
            string rua = RuaInfo.Text;
            string cidade = CidadeInfo.Text;
            string cep = CepInfo.Text;

            // Cria um objeto Address com as informa��es do endere�o
            Endereco address = new Endereco(rua, cidade, cep);

            // Cria um objeto Person com as informa��es do usu�rio
            Pessoa person = new Pessoa(primeiroNome, ultimoNome, address);

            // Adiciona a pessoa � lista peopleList
            peopleList.Add(person);

            // Limpa os controles de entrada ap�s adicionar a pessoa
            PrimeiroNome.Clear();
            UltimoNome.Clear();
            RuaInfo.Clear();
            CidadeInfo.Clear();
            CepInfo.Clear();

            // Exibe uma mensagem de sucesso (opcional)
            MessageBox.Show("Pessoa adicionada com sucesso!");
        }

        private void come�o_Load(object sender, EventArgs e)
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


        // Outros m�todos e eventos do formul�rio



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
                string searchName = CadNome.Text; // Obt�m o nome digitado pelo usu�rio

                // Encontra todas as pessoas cujo FirstName corresponde ao nome pesquisado
                List<Pessoa> matchingPeople = peopleList.FindAll(person =>
                    string.Equals(person.PrimeiroNome, searchName, StringComparison.OrdinalIgnoreCase));

                if (matchingPeople.Count > 0)
                {
                    // Cria uma mensagem com as informa��es de todas as pessoas correspondentes
                    string message = "Pessoa encontrada com o nome " + searchName + ":\n\n";

                    foreach (var person in matchingPeople)
                    {
                        message += $"Nome: {person.PrimeiroNome} {person.UltimoNome}\n" +
                                   $"Endere�o: {person.Endereco.Rua}, {person.Endereco.Cidade}, {person.Endereco.Cep}\n\n";
                    }

                    // Exibe a mensagem em um MessageBox
                    MessageBox.Show(message, "Informa��es da Pessoa Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Se n�o houver correspond�ncias, exibe uma mensagem de aviso
                    MessageBox.Show("Nenhuma pessoa encontrada com o nome " + searchName + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
    


