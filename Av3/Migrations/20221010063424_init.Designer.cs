﻿// <auto-generated />
using System;
using Av3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace Av3.Migrations
{
    [DbContext(typeof(Av3.Data.DbContext))]
    [Migration("20221010063424_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Av3.Models.Disciplina", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"), 1L, 1);

                    b.Property<string>("NomeDisciplina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CargaHoraria")
                            .HasColumnType("bigint");

                    b.HasKey("Codigo");

                    b.ToTable("disciplinas");
                });
        }
    }
}