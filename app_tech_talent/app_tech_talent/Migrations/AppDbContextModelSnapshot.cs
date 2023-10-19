﻿// <auto-generated />
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
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("app_tech_talent.Models.Curriculo", b =>
                {
                    b.Property<int>("IdCurriculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCurriculo"), 1L, 1);

                    b.Property<string>("ResumoProfissional")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCurriculo");

                    b.ToTable("Curriculos");
                });
#pragma warning restore 612, 618
        }
    }
}
