using System;

namespace DalStandard.Models
{
    public class Produto_Venda
    {

        public int Id { get; set; }

        public Decimal ValorUnitario { get; set; }

        public long QuantidadeProduto { get; set; }

        public long ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public long VendaId { get; set; }
        public Venda Venda { get; set; }

    }
}
