using System.Security.Cryptography.Xml;

namespace extra1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new txtName());
        }
    }
}
//private void Form1_Load(object sender, EventArgs e)
//{
///    Endereco address = new Endereco("123 Main St", "Cityville", "12345");
//
//
//    Pessoa person = new Pessoa("John", "Doe", address);
//
//
//    Nome1.Text = $"Name: {person.PrimeiroNome} {person.UltimoNome}";
//    RuaInfo.Text = $"Street: {person.Endereco.Rua}";
//    CidadeInfo.Text = $"City: {person.Endereco.Cidade}";
 //   CepInfo.Text = $"Zip Code: {person.Endereco.Cep}";
//}