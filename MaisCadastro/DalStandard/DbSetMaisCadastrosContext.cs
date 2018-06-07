using DalStandard.Models;

namespace DalStandard
{
    public partial class MaisCadastrosContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Funcionario> Funcionarios { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Loja> Lojas { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Cliente> Clientes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Produto> Produtos { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Produto_Venda> Produtos_Vendas { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Venda> Vendas { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Setor> Setores { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Marca> Marcas { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
