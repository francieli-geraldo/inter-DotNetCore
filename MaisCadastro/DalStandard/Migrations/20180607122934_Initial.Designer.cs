﻿// <auto-generated />
using System;
using DalStandard;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DalStandard.Migrations
{
    [DbContext(typeof(MaisCadastrosContext))]
    [Migration("20180607122934_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DalStandard.Models.Cliente", b =>
                {
                    b.Property<long>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CPF");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Name");

                    b.Property<long>("Telefone");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("DalStandard.Models.Fornecedor", b =>
                {
                    b.Property<long>("FornecedorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CNPJ");

                    b.Property<string>("Name");

                    b.Property<long>("Telefone");

                    b.HasKey("FornecedorId");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("DalStandard.Models.Funcionario", b =>
                {
                    b.Property<long>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CPF");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<bool>("Gerente");

                    b.Property<long?>("LojaId");

                    b.Property<string>("Name");

                    b.Property<long>("Telefone");

                    b.HasKey("FuncionarioId");

                    b.HasIndex("LojaId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("DalStandard.Models.Loja", b =>
                {
                    b.Property<long>("LojaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CNPJ");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Name");

                    b.Property<long>("Telefone");

                    b.HasKey("LojaId");

                    b.ToTable("Lojas");
                });

            modelBuilder.Entity("DalStandard.Models.Marca", b =>
                {
                    b.Property<long>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("MarcaId");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("DalStandard.Models.Produto", b =>
                {
                    b.Property<long>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaoProduto");

                    b.Property<long?>("FornecedorId");

                    b.Property<string>("MarcaId");

                    b.Property<long?>("MarcaId1");

                    b.Property<string>("Name");

                    b.Property<string>("SetorId");

                    b.Property<long?>("SetorId1");

                    b.Property<decimal>("Valor");

                    b.HasKey("ProdutoId");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("MarcaId1");

                    b.HasIndex("SetorId1");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("DalStandard.Models.Produto_Venda", b =>
                {
                    b.Property<int>("Produto_VendaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProdutoId");

                    b.Property<long?>("ProdutoId1");

                    b.Property<long>("QuantidadeProduto");

                    b.Property<decimal>("ValorUnitario");

                    b.Property<int>("VendaId");

                    b.Property<long?>("VendaId1");

                    b.HasKey("Produto_VendaId");

                    b.HasIndex("ProdutoId1");

                    b.HasIndex("VendaId1");

                    b.ToTable("Produtos_Vendas");
                });

            modelBuilder.Entity("DalStandard.Models.Setor", b =>
                {
                    b.Property<long>("SetorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("SetorId");

                    b.ToTable("Setores");
                });

            modelBuilder.Entity("DalStandard.Models.Venda", b =>
                {
                    b.Property<long>("VendaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ClienteId");

                    b.Property<DateTime>("DataVenda");

                    b.Property<string>("DescricaoVenda");

                    b.Property<bool>("Fechado");

                    b.Property<string>("FormaPagamento");

                    b.Property<long?>("ProdutoId");

                    b.Property<int>("QuantidadeProduto");

                    b.Property<decimal>("ValorTotal");

                    b.HasKey("VendaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("DalStandard.Models.Funcionario", b =>
                {
                    b.HasOne("DalStandard.Models.Loja", "Loja")
                        .WithMany()
                        .HasForeignKey("LojaId");
                });

            modelBuilder.Entity("DalStandard.Models.Produto", b =>
                {
                    b.HasOne("DalStandard.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId");

                    b.HasOne("DalStandard.Models.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId1");

                    b.HasOne("DalStandard.Models.Setor", "Setor")
                        .WithMany()
                        .HasForeignKey("SetorId1");
                });

            modelBuilder.Entity("DalStandard.Models.Produto_Venda", b =>
                {
                    b.HasOne("DalStandard.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId1");

                    b.HasOne("DalStandard.Models.Venda", "Venda")
                        .WithMany()
                        .HasForeignKey("VendaId1");
                });

            modelBuilder.Entity("DalStandard.Models.Venda", b =>
                {
                    b.HasOne("DalStandard.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DalStandard.Models.Produto")
                        .WithMany("Vendas")
                        .HasForeignKey("ProdutoId");
                });
#pragma warning restore 612, 618
        }
    }
}
