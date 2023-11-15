﻿// <auto-generated />
using System;
using AEproiect.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AEproiect.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231113111518_ProductDateFix")]
    partial class ProductDateFix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AEproiect.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "book",
                            Name = "Romanian Books",
                            Url = "romanian-books"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "book",
                            Name = "English Books",
                            Url = "english-books"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "musical-note",
                            Name = "Albums",
                            Url = "albums"
                        });
                });

            modelBuilder.Entity("AEproiect.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "In „Cronica pasarii-arc”, Haruki Murakami redeschide o alta usa catre acel tarim de granita dintre vis si realitate, pe care ii place atit de mult sa-l exploreze. Actiunea romanului debuteaza intr-o suburbie linistita din Tokyo, unde tinarul Toru Okada isi duce existenta deloc iesita din comun alaturi de sotia sa. O intimplare aparent banala – disparitia motanului familiei – da peste cap viata protagonistului, care se vede prins in paienjenisul unei lumi fantastice, ce intersecteaza in mod straniu realitatea de zi cu zi.",
                            Image = "https://cdn.dc5.ro/img-prod/9789736816253-1713110-240.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 12.9m,
                            Price = 9.99m,
                            Title = "Cronica pasarii-arc"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DateCreated = new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Mallory Quinn, abia ieșită dintr-un centru de dezintoxicare, se angajează ca babysitter pentru a avea grijă de Tedy, puștiul de cinci anișori al cuplului Ted și Caroline Maxwell. Tânăra descoperă că-i place nespus de mult noua ei slujbă, care-i oferă stabilitatea de care are atâta nevoie. În plus, ajunge să țină cu adevărat la băiețelul dulce și timid, care nu pleacă nicăieri fără creionul și caietul lui de schițe. Desenele lui sunt, la început, la fel ca ale oricărui alt puști: copăcei, iepurași și balonașe. Dar, într-o bună zi, copilul mâzgălește ceva cu totul neașteptat: un bărbat care târăște în pădure cadavrul unei femei. Încet, încet, imaginile pe care le așterne pe hârtie devin tot mai sinistre, iar personajele sale – din ce în ce mai pline de viață, Teddy dând dovadă de o măiestrie care îi depășește cu mult vârsta.",
                            Image = "https://nemira.ro/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/j/a/jason-rekulak---imagini-ascunse---c1.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 15.9m,
                            Price = 8.99m,
                            Title = "Imagini ascunse"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            DateCreated = new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "When he hears her favourite Beatles song, Toru Watanabe recalls his first love Naoko, the girlfriend of his best friend Kizuki. Immediately he is transported back almost twenty years to his student days in Tokyo, adrift in a world of uneasy friendships, passion, loss and desire - to a time when an impetuous young woman called Midori marches into his life and he has to choose between the future and the past.",
                            Image = "https://m.media-amazon.com/images/I/81zqVhvbHbL._AC_UF894,1000_QL80_.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 12.9m,
                            Price = 9.99m,
                            Title = "Norwegian Wood"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            DateCreated = new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fine Line is the second studio album by English singer and songwriter Harry Styles, released on 13 December 2019 by Columbia Records and Erskine. The album's themes revolve around breakups, happiness, sex and sadness.[2] The record has been described as pop rock, with elements of progressive-pop, psychedelic pop, folk, soul, funk and indie pop. It was primarily written with and produced by frequent collaborator Tyler Johnson and Kid Harpoon.",
                            Image = "https://media.pitchfork.com/photos/5df3f10129131e0008fbae41/1:1/w_3600,h_3600,c_limit/Harry-Styles.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 25.9m,
                            Price = 19.99m,
                            Title = "Fine Line"
                        });
                });

            modelBuilder.Entity("AEproiect.Shared.Product", b =>
                {
                    b.HasOne("AEproiect.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
