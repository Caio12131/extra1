using System;
public class Pessoa
{
    public string PrimeiroNome { get; set; }
    public string UltimoNome { get; set; }
    public Endereco Endereco { get; set; }

    public Pessoa(string primeiroNome, string ultimoNome, Endereco endereco)
    {
        PrimeiroNome = primeiroNome;
        UltimoNome = ultimoNome;
        Endereco = endereco;
    }
}