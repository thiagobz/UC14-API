using Microsoft.EntityFrameworkCore;
using UC14Chapter.Models;

namespace UC14Chapter.Contexts
{
    //dbcontext é a ponte entre o modelo de classe e o banco de dados
    public class SqlContext : DbContext
    {
        public SqlContext(){}

        public SqlContext(DbContextOptions<SqlContext> options)
            : base(options){}

        //vamos utilizar esse método para configurar o banco de dados

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=GABRIELLE-NOTEB\\SQLEXPRESS; initial catalog=Chapter; Integrated Security=True");
                //optionsBuilder.UseSqlServer("Data Source=GABRIELLE-NOTEB\\SQLEXPRESS; initial catalog=Chapter; User ID = sa; Password = 123");

            }
        }
        //Dbset representa as entidades que seram utilizadas nas operações de leitura, criação, atualziação e deleção

        public DbSet<Livro> Livros { get; set; }

    }
}
