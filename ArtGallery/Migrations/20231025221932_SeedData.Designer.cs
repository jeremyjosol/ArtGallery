﻿// <auto-generated />
using ArtGallery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArtGallery.Migrations
{
    [DbContext(typeof(ArtGalleryContext))]
    [Migration("20231025221932_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ArtGallery.Models.Artwork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Artworks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Artist = "Damien Hirst",
                            Description = "A shark in formaldehyde",
                            Title = "The Physical Impossibility of Death in the Mind of Someone Living",
                            Year = 1991
                        },
                        new
                        {
                            Id = 2,
                            Artist = "Takashi Murakami",
                            Description = "Colorful flower artwork",
                            Title = "Flowers",
                            Year = 2010
                        },
                        new
                        {
                            Id = 4,
                            Artist = "Richard Serra",
                            Description = "Large-scale steel sculpture",
                            Title = "Tilted Arc",
                            Year = 1981
                        },
                        new
                        {
                            Id = 5,
                            Artist = "Mark Rothko",
                            Description = "Abstract expressionist painting",
                            Title = "No. 14",
                            Year = 1960
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
