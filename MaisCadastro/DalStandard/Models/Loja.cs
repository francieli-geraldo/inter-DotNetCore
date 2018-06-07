namespace DalStandard.Models
{
    public class Loja
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Endereco { get; set; }

        public long Telefone { get; set; }

        public string Email { get; set; }

        public long CNPJ { get; set; }
    }
}