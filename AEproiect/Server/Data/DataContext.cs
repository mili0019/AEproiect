using AEproiect.Shared;
using Microsoft.EntityFrameworkCore;

namespace AEproiect.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariants>()
                .HasKey(p => new { p.ProductId, p.EditionId });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Romanian Books", Url = "romanian-books", Icon = "book" },
                new Category { Id = 2, Name = "English Books", Url = "english-books", Icon = "book" },
                new Category { Id = 3, Name = "Albums", Url = "albums", Icon = "musical-note" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Cronica pasarii-arc",
                    Description = "In „Cronica pasarii-arc”, Haruki Murakami redeschide o alta usa catre acel tarim de granita dintre vis si realitate, pe care ii place atit de mult sa-l exploreze. Actiunea romanului debuteaza intr-o suburbie linistita din Tokyo, unde tinarul Toru Okada isi duce existenta deloc iesita din comun alaturi de sotia sa. O intimplare aparent banala – disparitia motanului familiei – da peste cap viata protagonistului, care se vede prins in paienjenisul unei lumi fantastice, ce intersecteaza in mod straniu realitatea de zi cu zi.",
                    Image = "https://cdn.dc5.ro/img-prod/9789736816253-1713110-240.jpg",
                    DateCreated = new DateTime(2023, 11, 11)
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Imagini ascunse",
                    Description = "Mallory Quinn, abia ieșită dintr-un centru de dezintoxicare, se angajează ca babysitter pentru a avea grijă de Tedy, puștiul de cinci anișori al cuplului Ted și Caroline Maxwell. Tânăra descoperă că-i place nespus de mult noua ei slujbă, care-i oferă stabilitatea de care are atâta nevoie. În plus, ajunge să țină cu adevărat la băiețelul dulce și timid, care nu pleacă nicăieri fără creionul și caietul lui de schițe. Desenele lui sunt, la început, la fel ca ale oricărui alt puști: copăcei, iepurași și balonașe. Dar, într-o bună zi, copilul mâzgălește ceva cu totul neașteptat: un bărbat care târăște în pădure cadavrul unei femei. Încet, încet, imaginile pe care le așterne pe hârtie devin tot mai sinistre, iar personajele sale – din ce în ce mai pline de viață, Teddy dând dovadă de o măiestrie care îi depășește cu mult vârsta.",
                    Image = "https://nemira.ro/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/j/a/jason-rekulak---imagini-ascunse---c1.jpg",
                    DateCreated = new DateTime(2023, 11, 11)
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 2,
                    Title = "Norwegian Wood",
                    Description = "When he hears her favourite Beatles song, Toru Watanabe recalls his first love Naoko, the girlfriend of his best friend Kizuki. Immediately he is transported back almost twenty years to his student days in Tokyo, adrift in a world of uneasy friendships, passion, loss and desire - to a time when an impetuous young woman called Midori marches into his life and he has to choose between the future and the past.",
                    Image = "https://m.media-amazon.com/images/I/81zqVhvbHbL._AC_UF894,1000_QL80_.jpg",
                    DateCreated = new DateTime(2023, 11, 11)
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 3,
                    Title = "Fine Line",
                    Description = "Fine Line is the second studio album by English singer and songwriter Harry Styles, released on 13 December 2019 by Columbia Records and Erskine. The album's themes revolve around breakups, happiness, sex and sadness.[2] The record has been described as pop rock, with elements of progressive-pop, psychedelic pop, folk, soul, funk and indie pop. It was primarily written with and produced by frequent collaborator Tyler Johnson and Kid Harpoon.",
                    Image = "https://media.pitchfork.com/photos/5df3f10129131e0008fbae41/1:1/w_3600,h_3600,c_limit/Harry-Styles.jpg",
                    DateCreated = new DateTime(2023, 11, 11)
                }
            );

            modelBuilder.Entity<Edition>().HasData(
                new Edition { Id = 1, Name = "Default" },
                new Edition { Id = 2, Name = "Paperback" },
                new Edition { Id = 3, Name = "e-Book" },
                new Edition { Id = 4, Name = "Audiobook" },
                new Edition { Id = 5, Name = "CD" },
                new Edition { Id = 6, Name = "Vinyl" }
            );

            modelBuilder.Entity<ProductVariants>().HasData(
                new ProductVariants
                {
                    ProductId = 1,
                    EditionId = 1, 
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariants
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 34.99m,
                    OriginalPrice = 44.99m
                },
                new ProductVariants
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 10.99m,
                    OriginalPrice = 25.99m
                },
                new ProductVariants
                {
                    ProductId = 1,
                    EditionId = 4,
                    Price = 20.99m,
                    OriginalPrice = 46.99m
                },
                new ProductVariants
                {
                    ProductId = 2,
                    EditionId = 1,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariants
                {
                    ProductId = 2,
                    EditionId = 2,
                    Price = 10.99m,
                    OriginalPrice = 22.99m
                },
                new ProductVariants
                {
                    ProductId = 2,
                    EditionId = 3,
                    Price = 4.99m,
                    OriginalPrice = 25.99m
                },
                new ProductVariants
                {
                    ProductId = 2,
                    EditionId = 4,
                    Price = 23.99m,
                    OriginalPrice = 25.99m
                },
                new ProductVariants
                {
                    ProductId = 3,
                    EditionId = 1,
                    Price = 21.99m,
                    OriginalPrice = 25.99m
                },
                new ProductVariants
                {
                    ProductId = 3,
                    EditionId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariants
                {
                    ProductId = 3,
                    EditionId = 3,
                    Price = 12.99m,
                    OriginalPrice = 18.99m
                },
                new ProductVariants
                {
                    ProductId = 4,
                    EditionId = 1,
                    Price = 45.99m,
                    OriginalPrice = 63.99m
                },
                new ProductVariants
                {
                    ProductId = 4,
                    EditionId = 5,
                    Price = 50.99m,
                    OriginalPrice = 69.99m
                },
                new ProductVariants
                {
                    ProductId = 4,
                    EditionId = 6,
                    Price = 10.99m,
                    OriginalPrice = 51.99m
                }
            );

            //modelBuilder.SharedTypeEntity<Dictionary<string, object>>("EditionProduct").HasData(
            //    new { EditionsId = 1, ProductsId = 1 },
            //    new { EditionsId = 2, ProductsId = 1 },
            //    new { EditionsId = 3, ProductsId = 1 },
            //    new { EditionsId = 1, ProductsId = 2 },
            //    new { EditionsId = 2, ProductsId = 2 },
            //    new { EditionsId = 1, ProductsId = 3 },
            //    new { EditionsId = 3, ProductsId = 3 },
            //    new { EditionsId = 2, ProductsId = 3 },
            //    new { EditionsId = 4, ProductsId = 4 },
            //    new { EditionsId = 5, ProductsId = 4 }
            //);
        }
    }
}
