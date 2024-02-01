﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SAD.Infrastructure.DB;

#nullable disable

namespace SAD.Infrastructure.Migrations
{
    [DbContext(typeof(SaDDbContext))]
    [Migration("20240201161423_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SAD.Domain.Entities.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hardnes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("SEOName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thickness")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Warehauses");
                });

            modelBuilder.Entity("SAD.Domain.Entities.Warehouse", b =>
                {
                    b.OwnsOne("SAD.Domain.Entities.PalletRack", "PalletRack", b1 =>
                        {
                            b1.Property<int>("WarehauseId")
                                .HasColumnType("int");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Position")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("WarehauseId");

                            b1.ToTable("Warehauses");

                            b1.WithOwner()
                                .HasForeignKey("WarehauseId");
                        });

                    b.Navigation("PalletRack")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
