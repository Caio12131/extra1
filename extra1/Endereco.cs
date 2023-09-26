using System;

public class Endereco
{
    public string Rua { get; set; }
    public string Cidade { get; set; }
    public string Cep { get; set; }

    public Endereco(string rua, string cidade, string cep)
    {
        Rua = rua;
        Cidade = cidade;
        Cep = cep;
    }
}