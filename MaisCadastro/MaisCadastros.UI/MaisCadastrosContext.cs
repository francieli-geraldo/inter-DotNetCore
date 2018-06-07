namespace DAL
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
}