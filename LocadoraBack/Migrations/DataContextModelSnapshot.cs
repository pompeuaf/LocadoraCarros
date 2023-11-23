﻿// <auto-generated />
using System;
using LocadoraBack.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocadoraBack.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocadoraBack.Models.PedidoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("PessoaId")
                        .HasColumnType("bigint");

                    b.Property<long>("VeiculoId")
                        .HasColumnType("bigint");

                    b.Property<bool>("ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("data_devolucao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("data_locacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("data_retirada")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("forma_pgto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<decimal>("valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("PEDIDOS");
                });

            modelBuilder.Entity("LocadoraBack.Models.PessoaModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("cpfcnpj")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("pessoa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("pessoa_act")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("pessoa_tipo")
                        .HasColumnType("int");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PESSOAS");
                });

            modelBuilder.Entity("LocadoraBack.Models.TelefoneEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("DDD")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("PessoaId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("TELEFONES");
                });

            modelBuilder.Entity("LocadoraBack.Models.UserModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("user")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("user_act")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("USUARIOS");
                });

            modelBuilder.Entity("LocadoraBack.Models.VeiculoModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ano")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("combustivel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("modelo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("valor")
                        .HasColumnType("float");

                    b.Property<bool>("veiculo_act")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("VEICULOS");
                });

            modelBuilder.Entity("LocadoraBack.Models.PedidoModel", b =>
                {
                    b.HasOne("LocadoraBack.Models.PessoaModel", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LocadoraBack.Models.VeiculoModel", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("LocadoraBack.Models.TelefoneEntidade", b =>
                {
                    b.HasOne("LocadoraBack.Models.PessoaModel", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}