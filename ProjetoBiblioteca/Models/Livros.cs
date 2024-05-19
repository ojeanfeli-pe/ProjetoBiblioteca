namespace Biblioteca.Models;

public class Livros
{
    //Construtor
    public Livros(int id, string titulo, int anoPublicacao)
    {
        Id = id;
        Titulo = titulo;
        AnoPublicacao = anoPublicacao;
    }

    public int Id { get; set; }
    public string? Titulo { get; set; }
    public int AnoPublicacao { get; set; }

}