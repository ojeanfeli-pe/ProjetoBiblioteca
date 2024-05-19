namespace Biblioteca.Models;

public class Devolucao
{
    //Construtor
    public Devolucao()
    {
        DataDevolucao = DateTime.Now;
    }

    public DateTime DataDevolucao { get; set; }

}