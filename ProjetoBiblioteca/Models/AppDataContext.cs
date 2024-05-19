using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models;

//Classe que representa o EF dentro do projeto
public class AppDataContext : DbContext
{
    
    //Classes que vão representar as tabelas
    //no banco de dados
    public DbSet<Livros> Livro { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<Emprestimo> Emprestimos { get; set; }
    public DbSet<Editora> Editoras { get; set; }
    public DbSet<Devolucao> Devolucoes { get; set; }
    public DbSet<Autor> Autores { get; set; }

    //Configurando qual o banco de dados vai
    //ser utilizado
    //Configurando a string de conexão
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=biblioteca.db");
    }
}