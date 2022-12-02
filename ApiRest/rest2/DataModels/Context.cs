using Microsoft.EntityFrameworkCore;

namespace rest2.DataModels
{
    public class Context : DbContext
    {
        public DbSet<Alunos> alunos { get; set; }

        public DbSet<Curso> Curso { get; set; }

        public Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; " +
           "initial Catalog=AtosApiRest2;User ID=AtosApiRest2; " +
           "password=AtosApiRest2;language=Portuguese;Trusted_Connection=True;" +
           "TrustServerCertificate=True;");

            optionsBuilder.UseLazyLoadingProxies();


        }

    }
}
