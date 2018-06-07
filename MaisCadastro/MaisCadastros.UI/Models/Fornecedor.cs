namespace DAL.Models
{
    public class Fornecedor
    {
        public long FornecedorId { get; set; }

        public string Name { get; set; }

        public long Telefone { get; set; }

        public long CNPJ { get; set; }
    }
}