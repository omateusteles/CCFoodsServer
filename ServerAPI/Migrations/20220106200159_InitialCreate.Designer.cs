﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerAPI.Persistencia;

#nullable disable

namespace ServerAPI.Migrations
{
    [DbContext(typeof(CCFoodsContext))]
    [Migration("20220106200159_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ServerAPI.Models.ConfiguracaoDispositivo", b =>
                {
                    b.Property<long?>("ConfiguracaoDispositivoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("ConfiguracaoDispositivoId"), 1L, 1);

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConfiguracaoDispositivoId");

                    b.ToTable("ConfiguracoesDispositivos");
                });

            modelBuilder.Entity("ServerAPI.Models.Garcom", b =>
                {
                    b.Property<string>("GarcomId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long?>("DispositivoId")
                        .HasColumnType("bigint");

                    b.Property<long?>("EntityId")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("Foto")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OperacaoSincronismo")
                        .HasColumnType("int");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GarcomId");

                    b.ToTable("Garcons");
                });
#pragma warning restore 612, 618
        }
    }
}
