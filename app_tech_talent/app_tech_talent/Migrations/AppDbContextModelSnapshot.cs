﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using app_tech_talent.Models;

#nullable disable

namespace app_tech_talent.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);



            modelBuilder.Entity("app_tech_talent.Models.Candidatura", b =>
                {
                    b.Property<int>("CandidaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("serial");

                    b.Property<int>("ProfissionalId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("VagaId")
                        .HasColumnType("int");

                    b.HasKey("CandidaturaId");

                    b.ToTable("Candidaturas");
                });

            modelBuilder.Entity("app_tech_talent.Models.Curriculo", b =>
                {
                    b.Property<int>("IdCurriculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("serial");

                    b.Property<string>("CPF")
                        .HasColumnType("varchar");

                    b.Property<string>("ResumoProfissional")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.HasKey("IdCurriculo");

                    b.ToTable("Curriculo");
                });

            modelBuilder.Entity("app_tech_talent.Models.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("serial");

                    b.Property<string>("Bairro")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CEP")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("Cidade")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Descricao")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Logradouro")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UF")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("WebSite")
                        .HasColumnType("varchar");

                    b.HasKey("EmpresaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("app_tech_talent.Models.ExperienciaProfissional", b =>
                {
                    b.Property<int>("IdExperienciaProfissional")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("serial");

                    b.Property<string>("Cargo")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("DataDeInicio")
                        .HasColumnType("timestamptz");

                    b.Property<DateTime>("DataDeTermino")
                        .HasColumnType("timestamptz");

                    b.Property<string>("Empresa")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("IdCurriculo")
                        .HasColumnType("int");

                    b.Property<string>("ResumoDaAtuacao")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.HasKey("IdExperienciaProfissional");

                    b.ToTable("ExperienciaProfissional");
                });

            modelBuilder.Entity("app_tech_talent.Models.FormacaoAcademica", b =>
                {
                    b.Property<int>("IdFormacaoAcademica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("serial");

                    b.Property<DateTime>("AnoDeConclusao")
                        .HasColumnType("timestamptz");

                    b.Property<string>("AreaDeEstudo")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("IdCurriculo")
                        .HasColumnType("int");

                    b.Property<string>("InstituicaoDeEnsino")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("grauObtido")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdFormacaoAcademica");

                    b.ToTable("FormacaoAcademica");
                });

            modelBuilder.Entity("app_tech_talent.Models.Habilidades", b =>
                {
                    b.Property<int>("IdHabilidades")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("serial");

                    b.Property<bool>("AnaliseDeDados")
                        .HasColumnType("bit");

                    b.Property<bool>("BancoDeDados")
                        .HasColumnType("bit");

                    b.Property<string>("CPF")
                        .HasColumnType("varchar");

                    b.Property<bool>("DesignDeExperienciaDeUsuario")
                        .HasColumnType("bit");

                    b.Property<bool>("DesignDeInterfacesDeUsuario")
                        .HasColumnType("bit");

                    b.Property<bool>("DevOps")
                        .HasColumnType("bit");

                    b.Property<bool>("Ingles")
                        .HasColumnType("bit");

                    b.Property<bool>("MachineLearningEInteligenciaArtificial")
                        .HasColumnType("bit");

                    b.Property<bool>("Programacao")
                        .HasColumnType("bit");

                    b.HasKey("IdHabilidades");

                    b.ToTable("Habilidades");
                });

            modelBuilder.Entity("app_tech_talent.Models.Profissional", b =>
                {
                    b.Property<int>("ProfissionalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("serial");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ProfissionalId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Profissionais");
                });

            modelBuilder.Entity("app_tech_talent.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("serial");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("RecoveryKey")
                        .HasColumnType("varchar");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("app_tech_talent.Models.Vaga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("serial");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("ExperienciaProficional")
                        .HasColumnType("varchar");

                    b.Property<string>("Habilidades")
                        .HasColumnType("varchar");

                    b.Property<string>("Localizacao")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<DateTime>("dataFechamento")
                        .HasColumnType("timestamptz");

                    b.Property<DateTime>("dateAbertura")
                        .HasColumnType("timestamptz");

                    b.Property<string>("formacao")
                        .HasColumnType("varchar");

                    b.Property<double>("salario")
                        .HasColumnType("float");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Vagas");
                });

            modelBuilder.Entity("app_tech_talent.Models.Empresa", b =>
                {
                    b.HasOne("app_tech_talent.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("app_tech_talent.Models.Profissional", b =>
                {
                    b.HasOne("app_tech_talent.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
