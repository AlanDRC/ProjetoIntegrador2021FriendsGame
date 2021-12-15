using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace PROJETO01.Dados.EntityFramework
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = @"Data source = 201.62.57.93; 
                                     Database = bd040157; 
                                     User ID = ra040157; 
                                     Password = 040157";
            optionsBuilder.UseSqlServer(conn);
        }

        //Nome das Classes que representarão o Banco de Dados
        //public DbSet<Estado> Estado { get; set; }


        public DbSet<usuario> usuario { get; set; }
        public DbSet<TipoJogos> TipoJogos { get; set; }
        public DbSet<Fornecedorjogos> Fornecedorjogos { get; set; }
        public DbSet<jogo> jogo { get; set; }


        //Definição das características das classes com as tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            //usuario
            modelBuilder.Entity<usuario>()
                .ToTable("usuario")
                .HasKey("codPlayer");

            modelBuilder.Entity<usuario>()
                .Property("codPlayer")
                 .HasColumnName("codPlayer")
                 .HasColumnType("varchar(4)")
                 .IsRequired();

            modelBuilder.Entity<usuario>()
                .Property("IdLogin")
                .HasColumnName("IdLogin")
                .HasColumnType("varchar(16)")
                 .IsRequired();

            modelBuilder.Entity<usuario>()
               .Property("NickJogador")
               .HasColumnName("NickJogador")
               .HasColumnType("varchar(16)")
                .IsRequired();

            modelBuilder.Entity<usuario>()
               .Property("senha")
               .HasColumnName("senha")
               .HasColumnType("varchar(16)")
                .IsRequired();

            modelBuilder.Entity<usuario>()
             .Property("codJogo")
             .HasColumnName("codJogo")
              .HasColumnType("int")
                 .IsRequired();

            modelBuilder.Entity<usuario>()
             .HasOne(f => f.jogo)
                .WithMany()
                .HasForeignKey(f => f.codJogo);

            //tipo de jogo

            modelBuilder.Entity<TipoJogos>()
            .ToTable("TipoJogos")
             .HasKey("codTipoJogo");

            modelBuilder.Entity<TipoJogos>()
                .Property("codTipoJogo")
                .HasColumnName("codTipoJogo")
                .HasColumnType("varchar(4)")
                .IsRequired();

            modelBuilder.Entity<TipoJogos>()
                .Property("descrisaoTipoJogo")
                .HasColumnName("descrisaoTipoJogo")
                .HasColumnType("varchar(50)")
                .IsRequired();

            //fornecedor

            modelBuilder.Entity<Fornecedorjogos>()
              .ToTable("Fornecedorjogos")
                .HasKey("codFornecedor");

            modelBuilder.Entity<Fornecedorjogos>()
                .Property("codFornecedor")
                .HasColumnName("codFornecedor")
                .HasColumnType("varchar(4)")
                .IsRequired();

            modelBuilder.Entity<Fornecedorjogos>()
                .Property("nomefornecedor")
                .HasColumnName("nomefornecedor")
                .HasColumnType("varchar(50)")
                .IsRequired();

            modelBuilder.Entity<Fornecedorjogos>()
              .Property("Descricaofornecedor")
              .HasColumnName("Descricaofornecedor")
              .HasColumnType("varchar(500)")
              .IsRequired();

            //Jogo
            modelBuilder.Entity<jogo>()
              .ToTable("jogos")
              .HasKey("codJogo");

            modelBuilder.Entity<jogo>()
                .Property("codJogo")
                 .HasColumnName("codJogo")
                 .HasColumnType("int")
                 .IsRequired();

            modelBuilder.Entity<jogo>()
                .Property("nomeDoJogo")
                .HasColumnName("nomeDoJogo")
                .HasColumnType("varchar(50)")
                 .IsRequired();

            modelBuilder.Entity<jogo>()
                .Property("codFornecedor")
                 .HasColumnName("codFornecedor")
                 .HasColumnType("varchar(4)")
                 .IsRequired();

            modelBuilder.Entity<jogo>()
               .Property("anolancamento")
               .HasColumnName("anolancamento")
               .HasColumnType("date")
                .IsRequired();

            modelBuilder.Entity<jogo>()
               .Property("requisitos")
               .HasColumnName("requisitos")
               .HasColumnType("varchar(500)")
                .IsRequired();

            modelBuilder.Entity<jogo>()
                .Property("codTipoJogo")
                 .HasColumnName("codTipoJogo")
                 .HasColumnType("varchar(4)")
                 .IsRequired();

            modelBuilder.Entity<jogo>()
                .HasOne(f => f.TipoJogos)
                .WithMany()
                .HasForeignKey(f => f.codTipoJogo);

            modelBuilder.Entity<jogo>()
            .HasOne(f => f.Fornecedorjogos)
            .WithMany()
            .HasForeignKey(f => f.codFornecedor);

            base.OnModelCreating(modelBuilder);
        }
    }
}

