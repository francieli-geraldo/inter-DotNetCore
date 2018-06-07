using Microsoft.EntityFrameworkCore;

namespace DalStandard
{
    public partial class MaisCadastrosContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public MaisCadastrosContext(Microsoft.EntityFrameworkCore.DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public class MaisCadastrosContexttFactory : Microsoft.EntityFrameworkCore.Design.IDesignTimeDbContextFactory<MaisCadastrosContext>
    {
        public MaisCadastrosContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new Microsoft.EntityFrameworkCore.DbContextOptionsBuilder<MaisCadastrosContext>();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True; MultipleActiveResultSets=True;");

            return new MaisCadastrosContext(optionsBuilder.Options);
        }
    }
}