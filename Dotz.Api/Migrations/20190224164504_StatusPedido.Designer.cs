﻿// <auto-generated />
using System;
using Dotz.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dotz.Api.Migrations
{
    [DbContext(typeof(DzContext))]
    [Migration("20190224164504_StatusPedido")]
    partial class StatusPedido
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dotz.Api.Consumidor", b =>
                {
                    b.Property<int>("IdConsumidor")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF")
                        .IsRequired();

                    b.Property<DateTime>("DtNascimento");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.Property<int>("Sexo");

                    b.Property<string>("Sobrenome")
                        .IsRequired();

                    b.Property<string>("TelefoneCelular")
                        .IsRequired();

                    b.Property<string>("TelefoneResidencial");

                    b.HasKey("IdConsumidor");

                    b.ToTable("Consumidores");
                });

            modelBuilder.Entity("Dotz.Api.ConsumidorEndereco", b =>
                {
                    b.Property<int>("IdConsumidorEndereco")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Complemento");

                    b.Property<int>("IdConsumidor");

                    b.Property<string>("Logradouro")
                        .IsRequired();

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("Principal");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.HasKey("IdConsumidorEndereco");

                    b.HasIndex("IdConsumidor");

                    b.ToTable("ConsumidorEndereco");
                });

            modelBuilder.Entity("Dotz.Api.ConsumidorMovimentacao", b =>
                {
                    b.Property<int>("IdConsumidorMovimentacao")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int>("IdConsumidor");

                    b.Property<int?>("IdParceiroCredito");

                    b.Property<int?>("IdPedidoItem");

                    b.Property<int>("Natureza");

                    b.Property<double>("Valor");

                    b.HasKey("IdConsumidorMovimentacao");

                    b.HasIndex("IdConsumidor");

                    b.HasIndex("IdParceiroCredito");

                    b.HasIndex("IdPedidoItem");

                    b.ToTable("ConsumidorMovimentacoes");
                });

            modelBuilder.Entity("Dotz.Api.Parceiro", b =>
                {
                    b.Property<int>("IdParceiro")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CNPJ")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("FatorDZ");

                    b.Property<string>("LogoURL");

                    b.Property<int>("MoedaTroca");

                    b.Property<string>("NomeFantasia")
                        .IsRequired();

                    b.Property<string>("RazaoSocial")
                        .IsRequired();

                    b.Property<string>("Regulamento")
                        .IsRequired();

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.Property<string>("URLRedirecionamento")
                        .IsRequired();

                    b.HasKey("IdParceiro");

                    b.ToTable("Parceiros");
                });

            modelBuilder.Entity("Dotz.Api.ParceiroCredito", b =>
                {
                    b.Property<int>("IdParceiroCredito")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int>("IdConsumidor");

                    b.Property<int>("IdParceiro");

                    b.Property<int?>("MoedaOriginal");

                    b.Property<double>("ValorDZ");

                    b.Property<double?>("ValorMoedaOriginal");

                    b.HasKey("IdParceiroCredito");

                    b.HasIndex("IdConsumidor");

                    b.HasIndex("IdParceiro");

                    b.ToTable("ParceiroCreditos");
                });

            modelBuilder.Entity("Dotz.Api.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Complemento");

                    b.Property<DateTime?>("DataCancelamento");

                    b.Property<DateTime?>("DataEmissaoNF");

                    b.Property<DateTime?>("DataEnvio");

                    b.Property<DateTime>("DataPedido");

                    b.Property<DateTime?>("DataRecebimento");

                    b.Property<DateTime?>("DataSeparacao");

                    b.Property<int>("IdConsumidor");

                    b.Property<string>("Logradouro")
                        .IsRequired();

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Observacoes");

                    b.Property<int>("Status");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.HasKey("IdPedido");

                    b.HasIndex("IdConsumidor");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Dotz.Api.PedidoItem", b =>
                {
                    b.Property<int>("IdPedidoItem")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdPedido");

                    b.Property<int>("IdProduto");

                    b.Property<int>("Quantidade");

                    b.Property<double>("ValorDZ");

                    b.HasKey("IdPedidoItem");

                    b.HasIndex("IdPedido");

                    b.HasIndex("IdProduto");

                    b.ToTable("PedidoItem");
                });

            modelBuilder.Entity("Dotz.Api.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<string>("EAN")
                        .IsRequired();

                    b.Property<int>("IdSubcategoria");

                    b.Property<string>("Marca")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("QuantidadeEstoque");

                    b.Property<double>("ValorDotz");

                    b.Property<double?>("ValorDotzPromocional");

                    b.HasKey("IdProduto");

                    b.HasIndex("IdSubcategoria");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Dotz.Api.ProdutoCategoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("IdCategoria");

                    b.ToTable("ProdutoCategorias");
                });

            modelBuilder.Entity("Dotz.Api.ProdutoImagem", b =>
                {
                    b.Property<int>("IdProdutoImagem")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdProduto");

                    b.Property<string>("URL")
                        .IsRequired();

                    b.HasKey("IdProdutoImagem");

                    b.HasIndex("IdProduto");

                    b.ToTable("ProdutoImagem");
                });

            modelBuilder.Entity("Dotz.Api.ProdutoSubcategoria", b =>
                {
                    b.Property<int>("IdSubcategoria")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<int>("IdCategoria");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("IdSubcategoria");

                    b.HasIndex("IdCategoria");

                    b.ToTable("ProdutoSubcategorias");
                });

            modelBuilder.Entity("Dotz.Api.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Papel");

                    b.Property<string>("Senha");

                    b.Property<string>("Token");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Dotz.Api.ConsumidorEndereco", b =>
                {
                    b.HasOne("Dotz.Api.Consumidor")
                        .WithMany("Enderecos")
                        .HasForeignKey("IdConsumidor")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dotz.Api.ConsumidorMovimentacao", b =>
                {
                    b.HasOne("Dotz.Api.Consumidor")
                        .WithMany("Movimentacoes")
                        .HasForeignKey("IdConsumidor")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dotz.Api.ParceiroCredito", "Credito")
                        .WithMany()
                        .HasForeignKey("IdParceiroCredito");

                    b.HasOne("Dotz.Api.PedidoItem", "Pedido")
                        .WithMany()
                        .HasForeignKey("IdPedidoItem");
                });

            modelBuilder.Entity("Dotz.Api.ParceiroCredito", b =>
                {
                    b.HasOne("Dotz.Api.Consumidor", "Consumidor")
                        .WithMany()
                        .HasForeignKey("IdConsumidor")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dotz.Api.Parceiro", "Parceiro")
                        .WithMany()
                        .HasForeignKey("IdParceiro")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dotz.Api.Pedido", b =>
                {
                    b.HasOne("Dotz.Api.Consumidor", "Consumidor")
                        .WithMany()
                        .HasForeignKey("IdConsumidor")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dotz.Api.PedidoItem", b =>
                {
                    b.HasOne("Dotz.Api.Pedido")
                        .WithMany("Itens")
                        .HasForeignKey("IdPedido")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dotz.Api.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dotz.Api.Produto", b =>
                {
                    b.HasOne("Dotz.Api.ProdutoSubcategoria")
                        .WithMany("Produtos")
                        .HasForeignKey("IdSubcategoria")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dotz.Api.ProdutoImagem", b =>
                {
                    b.HasOne("Dotz.Api.Produto")
                        .WithMany("Imagens")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dotz.Api.ProdutoSubcategoria", b =>
                {
                    b.HasOne("Dotz.Api.ProdutoCategoria")
                        .WithMany("Subcategorias")
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
