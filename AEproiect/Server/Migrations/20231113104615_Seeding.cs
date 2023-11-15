using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AEproiect.Server.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "book", "Romanian Books", "romanian-books" },
                    { 2, "book", "English Books", "english-books" },
                    { 3, "musical-note", "Albums", "albums" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 13, 12, 46, 15, 799, DateTimeKind.Local).AddTicks(8080), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In „Cronica pasarii-arc”, Haruki Murakami redeschide o alta usa catre acel tarim de granita dintre vis si realitate, pe care ii place atit de mult sa-l exploreze. Actiunea romanului debuteaza intr-o suburbie linistita din Tokyo, unde tinarul Toru Okada isi duce existenta deloc iesita din comun alaturi de sotia sa. O intimplare aparent banala – disparitia motanului familiei – da peste cap viata protagonistului, care se vede prins in paienjenisul unei lumi fantastice, ce intersecteaza in mod straniu realitatea de zi cu zi.", "https://cdn.dc5.ro/img-prod/9789736816253-1713110-240.jpg", false, false, 12.9m, 9.99m, "Cronica pasarii-arc" },
                    { 2, 1, new DateTime(2023, 11, 13, 12, 46, 15, 799, DateTimeKind.Local).AddTicks(8128), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mallory Quinn, abia ieșită dintr-un centru de dezintoxicare, se angajează ca babysitter pentru a avea grijă de Tedy, puștiul de cinci anișori al cuplului Ted și Caroline Maxwell. Tânăra descoperă că-i place nespus de mult noua ei slujbă, care-i oferă stabilitatea de care are atâta nevoie. În plus, ajunge să țină cu adevărat la băiețelul dulce și timid, care nu pleacă nicăieri fără creionul și caietul lui de schițe. Desenele lui sunt, la început, la fel ca ale oricărui alt puști: copăcei, iepurași și balonașe. Dar, într-o bună zi, copilul mâzgălește ceva cu totul neașteptat: un bărbat care târăște în pădure cadavrul unei femei. Încet, încet, imaginile pe care le așterne pe hârtie devin tot mai sinistre, iar personajele sale – din ce în ce mai pline de viață, Teddy dând dovadă de o măiestrie care îi depășește cu mult vârsta.", "https://nemira.ro/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/j/a/jason-rekulak---imagini-ascunse---c1.jpg", false, false, 15.9m, 8.99m, "Imagini ascunse" },
                    { 3, 2, new DateTime(2023, 11, 13, 12, 46, 15, 799, DateTimeKind.Local).AddTicks(8131), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "When he hears her favourite Beatles song, Toru Watanabe recalls his first love Naoko, the girlfriend of his best friend Kizuki. Immediately he is transported back almost twenty years to his student days in Tokyo, adrift in a world of uneasy friendships, passion, loss and desire - to a time when an impetuous young woman called Midori marches into his life and he has to choose between the future and the past.", "https://m.media-amazon.com/images/I/81zqVhvbHbL._AC_UF894,1000_QL80_.jpg", false, false, 12.9m, 9.99m, "Norwegian Wood" },
                    { 4, 3, new DateTime(2023, 11, 13, 12, 46, 15, 799, DateTimeKind.Local).AddTicks(8134), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fine Line is the second studio album by English singer and songwriter Harry Styles, released on 13 December 2019 by Columbia Records and Erskine. The album's themes revolve around breakups, happiness, sex and sadness.[2] The record has been described as pop rock, with elements of progressive-pop, psychedelic pop, folk, soul, funk and indie pop. It was primarily written with and produced by frequent collaborator Tyler Johnson and Kid Harpoon.", "https://media.pitchfork.com/photos/5df3f10129131e0008fbae41/1:1/w_3600,h_3600,c_limit/Harry-Styles.jpg", false, false, 25.9m, 19.99m, "Fine Line" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
