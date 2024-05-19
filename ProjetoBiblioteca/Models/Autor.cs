namespace Biblioteca.Models;

public class Autor
{
    //Construtor
    public Autor(string nome)
    {
        Nome = nome;
    }

    public string? Nome { get; set; }

}