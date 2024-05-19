namespace Biblioteca.Models;

public class Emprestimo
{
    //Construtor
    public Emprestimo()
    {
        DataEmprestimo = DateTime.Now;
        DataDevolucao = DateTime.Now;
    }

    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucao { get; set; }

}