﻿// <auto-generated />
using System;
using BlueBirdSnowboardingApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlueBirdSnowboardingApp.Data.Migrations
{
    [DbContext(typeof(SnowboardingDbContext))]
    [Migration("20231203043851_AdicionarDadosIniciaisMarca")]
    partial class AdicionarDadosIniciaisMarca
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("BlueBirdSnowboardingApp.models.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MarcaId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("BlueBirdSnowboardingApp.models.Snowboard", b =>
                {
                    b.Property<int>("Snowboardid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EntregaExpressa")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImagemUri")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<double>("Preco")
                        .HasColumnType("REAL");

                    b.HasKey("Snowboardid");

                    b.ToTable("Snowboard");
                });
#pragma warning restore 612, 618
        }
    }
}