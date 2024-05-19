namespace Biblioteca.Models;

public class Livros
{
    //Construtor
   public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
    public string Genero { get; set; }
    public int ExemplaresDisponiveis { get; set; }

}