﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect1.Data;

#nullable disable

namespace Proiect1.Migrations
{
    [DbContext(typeof(Proiect1Context))]
    partial class Proiect1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Proiect1.Models.BrandB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("BrandB");
                });

            modelBuilder.Entity("Proiect1.Models.ForF", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("For")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ForF");
                });

            modelBuilder.Entity("Proiect1.Models.ToyT", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("BrandID")
                        .HasColumnType("int");

                    b.Property<int?>("ForID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("Toy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BrandID");

                    b.HasIndex("ForID");

                    b.ToTable("ToyT");
                });

            modelBuilder.Entity("Proiect1.Models.ToyT", b =>
                {
                    b.HasOne("Proiect1.Models.BrandB", "Brand")
                        .WithMany("Toys")
                        .HasForeignKey("BrandID");

                    b.HasOne("Proiect1.Models.ForF", "For")
                        .WithMany("Toys")
                        .HasForeignKey("ForID");

                    b.Navigation("Brand");

                    b.Navigation("For");
                });

            modelBuilder.Entity("Proiect1.Models.BrandB", b =>
                {
                    b.Navigation("Toys");
                });

            modelBuilder.Entity("Proiect1.Models.ForF", b =>
                {
                    b.Navigation("Toys");
                });
#pragma warning restore 612, 618
        }
    }
}