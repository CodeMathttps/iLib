﻿// <auto-generated />
using System;
using BibliotecaDados.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BibliotecaDados.Migrations
{
    [DbContext(typeof(BibliotecaContext))]
    partial class BibliotecaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BibliotecaDominio.Entidades.Emprestimo", b =>
                {
                    b.Property<int>("EmprestimoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDevolucao");

                    b.Property<DateTime>("DataEmprestimo");

                    b.Property<int>("ExemplarLivroId");

                    b.Property<int>("PessoaId");

                    b.HasKey("EmprestimoId");

                    b.HasIndex("ExemplarLivroId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Emprestimos");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CEP")
                        .IsRequired();

                    b.Property<string>("Complemento");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<int>("MunicipioId");

                    b.Property<int>("NumeroResidencial");

                    b.HasKey("EnderecoId");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.ExemplarLivro", b =>
                {
                    b.Property<int>("ExemplarLivroId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LivroId");

                    b.Property<int>("NumeroExemplar");

                    b.Property<string>("Registro")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ExemplarLivroId");

                    b.HasIndex("LivroId");

                    b.ToTable("Exemplares");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.Livro", b =>
                {
                    b.Property<int>("LivroId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssuntoId");

                    b.Property<int>("AutorId");

                    b.Property<int>("ClassificacaoId");

                    b.Property<int>("EditoraId");

                    b.Property<int>("LocalizacaoId");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("LivroId");

                    b.HasIndex("AssuntoId");

                    b.HasIndex("AutorId");

                    b.HasIndex("ClassificacaoId");

                    b.HasIndex("EditoraId");

                    b.HasIndex("LocalizacaoId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.Localizacao", b =>
                {
                    b.Property<int>("LocalizacaoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocalizacaoObra")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("LocalizacaoId");

                    b.ToTable("Localizacoes");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.ObjetosValor.Assunto", b =>
                {
                    b.Property<int>("AssuntoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssuntoObra")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("AssuntoId");

                    b.ToTable("Assuntos");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.ObjetosValor.Autor", b =>
                {
                    b.Property<int>("AutorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeAutor")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("AutorId");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.ObjetosValor.CPF", b =>
                {
                    b.Property<string>("Cpf")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Cpf");

                    b.ToTable("CPF");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.ObjetosValor.Classificacao", b =>
                {
                    b.Property<int>("ClassificacaoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassificacaoObra")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ClassificacaoId");

                    b.ToTable("Classificacoes");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.ObjetosValor.DadosLogin", b =>
                {
                    b.Property<int>("PessoaId");

                    b.Property<string>("Login")
                        .IsRequired();

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.HasKey("PessoaId");

                    b.ToTable("DadosLogin");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.ObjetosValor.Editora", b =>
                {
                    b.Property<int>("EditoraId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnderecoId");

                    b.Property<string>("NomeEditora")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("EditoraId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Editoras");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.ObjetosValor.Estado", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeEstado")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("PaisId");

                    b.HasKey("EstadoId");

                    b.HasIndex("PaisId");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.ObjetosValor.Municipio", b =>
                {
                    b.Property<int>("MunicipioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EstadoId");

                    b.Property<string>("NomeMunicipio")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MunicipioId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.ObjetosValor.Pais", b =>
                {
                    b.Property<int>("PaisId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomePais")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("PaisId");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.Pessoa", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<DateTime>("DataDeNascimento");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("EnderecoId");

                    b.Property<int>("Idade");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Profissao");

                    b.Property<string>("RG")
                        .IsRequired();

                    b.Property<string>("Telefone");

                    b.HasKey("PessoaId");

                    b.HasIndex("Cpf");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.Emprestimo", b =>
                {
                    b.HasOne("BibliotecaDominio.Entidades.ExemplarLivro", "ExemplarLivro")
                        .WithMany("Emprestimo")
                        .HasForeignKey("ExemplarLivroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BibliotecaDominio.Entidades.Pessoa", "Pessoa")
                        .WithMany("Emprestimo")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.Endereco", b =>
                {
                    b.HasOne("BibliotecaDominio.Entidades.ObjetosValor.Municipio", "Municipio")
                        .WithMany("Enderecos")
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.ExemplarLivro", b =>
                {
                    b.HasOne("BibliotecaDominio.Entidades.Livro", "Livro")
                        .WithMany("Exemplares")
                        .HasForeignKey("LivroId");
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.Livro", b =>
                {
                    b.HasOne("BibliotecaDominio.Entidades.ObjetosValor.Assunto", "Assunto")
                        .WithMany("Livros")
                        .HasForeignKey("AssuntoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BibliotecaDominio.Entidades.ObjetosValor.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BibliotecaDominio.Entidades.ObjetosValor.Classificacao", "Classificacao")
                        .WithMany("Livros")
                        .HasForeignKey("ClassificacaoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BibliotecaDominio.Entidades.ObjetosValor.Editora", "Editora")
                        .WithMany("Livros")
                        .HasForeignKey("EditoraId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BibliotecaDominio.Entidades.Localizacao", "Localizacao")
                        .WithMany("Livros")
                        .HasForeignKey("LocalizacaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.ObjetosValor.DadosLogin", b =>
                {
                    b.HasOne("BibliotecaDominio.Entidades.Pessoa")
                        .WithOne("Login")
                        .HasForeignKey("BibliotecaDominio.Entidades.ObjetosValor.DadosLogin", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.ObjetosValor.Editora", b =>
                {
                    b.HasOne("BibliotecaDominio.Entidades.Endereco", "Endereco")
                        .WithMany("Editoras")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.ObjetosValor.Estado", b =>
                {
                    b.HasOne("BibliotecaDominio.Entidades.ObjetosValor.Pais", "Pais")
                        .WithMany("Estados")
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.ObjetosValor.Municipio", b =>
                {
                    b.HasOne("BibliotecaDominio.Entidades.ObjetosValor.Estado", "Estado")
                        .WithMany("Municipios")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BibliotecaDominio.Entidades.Pessoa", b =>
                {
                    b.HasOne("BibliotecaDominio.Entidades.ObjetosValor.CPF", "CPF")
                        .WithMany()
                        .HasForeignKey("Cpf")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BibliotecaDominio.Entidades.Endereco", "Endereco")
                        .WithMany("Pessoas")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
