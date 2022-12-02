using Microsoft.EntityFrameworkCore;

namespace apiRestDotnet.DataModels
{
    public class Context : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }

        public Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; " +
           "initial Catalog=AtosApiRestDotnet;User ID=AtosApiRestDotnet; " +
           "password=AtosApiRestDotnet;language=Portuguese;Trusted_Connection=True;" +
           "TrustServerCertificate=True;");

            optionsBuilder.UseLazyLoadingProxies();


        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Email>()
        //        .HasOne(e => e.pessoa)
        //        .WithMany(e => e.Emails)
        //        .OnDelete(DeleteBehavior.ClientCascade);

        //}


    }
}
