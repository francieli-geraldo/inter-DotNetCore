namespace MaisCadastros.UI.Models
{
    public class CadastrosContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public CadastrosContext(Microsoft.EntityFrameworkCore.DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public class Cliente
    {
        public long Id { get; set; }

        public string Name { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime DataNascimento { get; set; }

        public string Endereco { get; set; }

        public long Telefone { get; set; }

        public string Email { get; set; }

        public long CPF { get; set; }

    }
}
