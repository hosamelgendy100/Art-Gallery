﻿// <auto-generated />
using System;
using ArtGalleryECommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtGalleryECommerce.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190524131523_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArtGalleryECommerce.Models.Artist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country");

                    b.Property<DateTime>("CreationDate");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("ID");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("ArtGalleryECommerce.Models.Product", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistID");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<double>("Price");

                    b.Property<string>("ProductDescription");

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.Property<string>("ProductSize")
                        .IsRequired();

                    b.Property<int>("ProductTypeID");

                    b.Property<int?>("ProductViewModelID");

                    b.HasKey("ID");

                    b.HasIndex("ProductViewModelID");

                    b.ToTable("Products");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");
                });

            modelBuilder.Entity("ArtGalleryECommerce.Models.ProductType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("ArtGalleryECommerce.Models.ViewModels.ProductViewModel", b =>
                {
                    b.HasBaseType("ArtGalleryECommerce.Models.Product");

                    b.Property<string>("Artist");

                    b.Property<int?>("ProductInstanceID");

                    b.Property<string>("ProductType");

                    b.Property<int?>("ProductViewModelID1");

                    b.HasIndex("ProductInstanceID");

                    b.HasIndex("ProductViewModelID1");

                    b.ToTable("ProductViewModel");

                    b.HasDiscriminator().HasValue("ProductViewModel");
                });

            modelBuilder.Entity("ArtGalleryECommerce.Models.Product", b =>
                {
                    b.HasOne("ArtGalleryECommerce.Models.ViewModels.ProductViewModel")
                        .WithMany("Products")
                        .HasForeignKey("ProductViewModelID");
                });

            modelBuilder.Entity("ArtGalleryECommerce.Models.ViewModels.ProductViewModel", b =>
                {
                    b.HasOne("ArtGalleryECommerce.Models.Product", "ProductInstance")
                        .WithMany()
                        .HasForeignKey("ProductInstanceID");

                    b.HasOne("ArtGalleryECommerce.Models.ViewModels.ProductViewModel")
                        .WithMany("ViewModelProducts")
                        .HasForeignKey("ProductViewModelID1");
                });
#pragma warning restore 612, 618
        }
    }
}
