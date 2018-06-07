using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Produto_Venda
    {

        public int Produto_VendaId { get; set; }

        public Decimal ValorUnitario { get; set; }

        public long QuantidadeProduto { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int VendaId { get; set; }
        public Venda Venda { get; set; }

    }
}
