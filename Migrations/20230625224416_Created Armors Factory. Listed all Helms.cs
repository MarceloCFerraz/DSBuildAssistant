using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSR.Migrations
{
    public partial class CreatedArmorsFactoryListedallHelms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Armors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Durability = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "double", nullable: false),
                    PhysicalProtection = table.Column<double>(type: "double", nullable: false),
                    StrikeProtection = table.Column<double>(type: "double", nullable: false),
                    SlashProtection = table.Column<double>(type: "double", nullable: false),
                    ThrustProtection = table.Column<double>(type: "double", nullable: false),
                    MagicProtection = table.Column<double>(type: "double", nullable: false),
                    FireProtection = table.Column<double>(type: "double", nullable: false),
                    LightningProtection = table.Column<double>(type: "double", nullable: false),
                    BleedResistence = table.Column<double>(type: "double", nullable: false),
                    PoisonResistence = table.Column<double>(type: "double", nullable: false),
                    CurseResistence = table.Column<double>(type: "double", nullable: false),
                    PoiseResistence = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armors", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CriticalBonus = table.Column<int>(type: "int", nullable: false),
                    Stability = table.Column<int>(type: "int", nullable: false),
                    Durability = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "double", nullable: false),
                    UpgradePath = table.Column<int>(type: "int", nullable: false),
                    PhysicalDamage = table.Column<int>(type: "int", nullable: false),
                    MagicalDamage = table.Column<int>(type: "int", nullable: false),
                    FireDamage = table.Column<int>(type: "int", nullable: false),
                    LightningDamage = table.Column<int>(type: "int", nullable: false),
                    DivineDamage = table.Column<int>(type: "int", nullable: false),
                    OccultDamage = table.Column<int>(type: "int", nullable: false),
                    StrengthScale = table.Column<int>(type: "int", nullable: false),
                    DexterityScale = table.Column<int>(type: "int", nullable: false),
                    IntelligenceScale = table.Column<int>(type: "int", nullable: false),
                    FaithScale = table.Column<int>(type: "int", nullable: false),
                    PhysicalDefense = table.Column<int>(type: "int", nullable: false),
                    MagicalDefense = table.Column<int>(type: "int", nullable: false),
                    FireDefence = table.Column<int>(type: "int", nullable: false),
                    LightningDefence = table.Column<int>(type: "int", nullable: false),
                    StrenghtRequirement = table.Column<int>(type: "int", nullable: false),
                    DexterityRequirement = table.Column<int>(type: "int", nullable: false),
                    IntelligenceRequirement = table.Column<int>(type: "int", nullable: false),
                    FaithRequirement = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Armors",
                columns: new[] { "ID", "BleedResistence", "CurseResistence", "Durability", "FireProtection", "LightningProtection", "MagicProtection", "Name", "PhysicalProtection", "PoiseResistence", "PoisonResistence", "SlashProtection", "StrikeProtection", "ThrustProtection", "Type", "Weight" },
                values: new object[,]
                {
                    { 1, 8.0, 6.0, 450, 9.0, 6.0, 8.0, "Balder Helm", 14.0, 0.0, 8.0, 17.0, 14.0, 13.0, 1, 4.2000000000000002 },
                    { 2, 15.0, 0.0, 250, 6.0, 6.0, 5.0, "Big Hat", 14.0, 0.0, 18.0, 15.4, 15.4, 12.6, 1, 3.0 },
                    { 3, 15.0, 5.0, 600, 19.0, 8.0, 11.0, "Black Iron Helm", 27.0, 12.0, 10.0, 31.0, 26.0, 27.0, 1, 6.0 },
                    { 4, 12.0, 0.0, 550, 18.0, 6.0, 11.0, "Black Knight Helm", 21.0, 8.0, 6.0, 23.699999999999999, 19.899999999999999, 20.600000000000001, 1, 5.0 },
                    { 5, 12.0, 2.0, 200, 8.0, 8.0, 11.0, "Black Sorcerer Hat", 5.0, 0.0, 12.0, 6.0, 5.0, 5.0, 1, 0.69999999999999996 },
                    { 6, 16.0, 10.0, 150, 9.0, 11.0, 17.0, "Bloated Head", 17.0, 0.0, 32.0, 17.0, 17.0, 17.0, 1, 2.5 },
                    { 7, 8.0, 15.0, 150, 9.0, 13.0, 22.0, "Bloated Sorcerer Head", 14.0, 0.0, 38.0, 14.0, 14.0, 14.0, 1, 2.2000000000000002 },
                    { 8, 11.0, 6.0, 600, 11.0, 11.0, 12.0, "Brass Helm", 22.0, 8.0, 9.0, 24.899999999999999, 21.100000000000001, 22.0, 1, 5.0999999999999996 },
                    { 9, 8.0, 0.0, 200, 5.0, 6.0, 8.0, "Brigand Hood", 9.0, 0.0, 8.0, 10.0, 10.0, 9.0, 1, 1.2 },
                    { 10, 13.0, 0.0, 400, 13.0, 7.0, 12.0, "Catarina Helm", 22.0, 8.0, 9.0, 25.0, 22.0, 22.0, 1, 4.5 },
                    { 11, 10.0, 0.0, 300, 8.0, 3.0, 10.0, "Chain Helm", 12.0, 5.0, 6.0, 14.4, 12.0, 11.6, 1, 3.0 },
                    { 12, 12.6, 0.0, 500, 19.399999999999999, 14.5, 21.800000000000001, "Cleric Helm", 36.299999999999997, 8.0, 8.4000000000000004, 41.700000000000003, 36.299999999999997, 36.299999999999997, 1, 4.7999999999999998 },
                    { 13, 5.0, 20.0, 150, 2.0, 6.0, 11.0, "Crown of Dusk", 5.0, 0.0, 5.0, 5.0, 5.0, 5.0, 1, 0.40000000000000002 },
                    { 14, 9.0, 12.0, 300, 6.0, 6.0, 12.0, "Crown of the Dark Sun", 12.0, 0.0, 9.0, 12.0, 12.0, 12.0, 1, 3.0 },
                    { 15, 15.0, 20.0, 900, 21.0, 21.0, 16.0, "Crown of the Great Lord", 16.0, 0.0, 8.0, 18.399999999999999, 17.300000000000001, 14.699999999999999, 1, 3.0 },
                    { 16, 6.0, 0.0, 150, 6.0, 2.0, 8.0, "Crystalline Helm", 11.0, 6.0, 0.0, 13.0, 9.0, 11.0, 1, 4.2000000000000002 },
                    { 17, 12.0, 0.0, 300, 12.0, 10.0, 12.0, "Dark Mask", 18.0, 6.0, 8.0, 19.800000000000001, 18.0, 16.899999999999999, 1, 3.7999999999999998 },
                    { 18, 9.0, 9.0, 150, 5.0, 6.0, 8.0, "Dingy Hood", 6.0, 0.0, 7.0, 6.0, 8.0, 6.0, 1, 0.80000000000000004 },
                    { 19, 15.0, 0.0, 450, 12.0, 7.0, 6.0, "Eastern Helm", 17.0, 8.0, 11.0, 21.0, 16.0, 16.0, 1, 4.7000000000000002 },
                    { 20, 9.0, 0.0, 450, 9.0, 6.0, 9.0, "Elite Knight Helm", 17.0, 8.0, 6.0, 21.0, 16.0, 17.0, 1, 4.5 },
                    { 21, 13.0, 0.0, 600, 4.0, 4.0, 5.0, "Fang Boar Helm", 26.0, 12.0, 8.0, 31.199999999999999, 23.399999999999999, 26.0, 1, 8.0 },
                    { 22, 22.0, 0.0, 200, 15.0, 15.0, 15.0, "Gargoyle Helm", 15.0, 8.0, 19.0, 19.100000000000001, 12.300000000000001, 13.699999999999999, 1, 3.5 },
                    { 23, 13.0, 0.0, 600, 19.0, 13.0, 13.0, "Giant Helm", 27.0, 14.0, 8.0, 30.5, 24.800000000000001, 27.0, 1, 6.2999999999999998 },
                    { 24, 16.0, 0.0, 400, 22.0, 8.0, 15.0, "Gold-Hemmed Black Hood", 11.0, 0.0, 36.0, 11.0, 11.800000000000001, 11.0, 1, 1.3999999999999999 },
                    { 25, 17.0, 0.0, 700, 16.0, 6.0, 17.0, "Golem Helm", 35.0, 13.0, 12.0, 40.899999999999999, 32.200000000000003, 35.0, 1, 6.2999999999999998 },
                    { 26, 11.0, 0.0, 450, 21.0, 11.0, 14.0, "Gough's Helm", 25.0, 9.0, 6.0, 26.199999999999999, 25.0, 23.800000000000001, 1, 6.5 },
                    { 27, 17.0, 0.0, 800, 19.0, 23.0, 23.0, "Guardian Helm", 41.0, 15.0, 6.0, 47.100000000000001, 38.5, 41.0, 1, 7.2000000000000002 },
                    { 28, 18.0, 9.0, 900, 22.0, 18.0, 22.0, "Havel's Helm", 36.0, 18.0, 4.0, 41.399999999999999, 30.600000000000001, 36.0, 1, 7.5 },
                    { 29, 9.0, 6.0, 600, 19.0, 9.0, 9.0, "Helm of Artorias", 18.0, 9.0, 9.0, 20.699999999999999, 16.199999999999999, 18.899999999999999, 1, 4.2000000000000002 },
                    { 30, 11.0, 5.0, 500, 11.0, 7.0, 10.0, "Helm of Favor", 18.0, 8.0, 8.0, 20.899999999999999, 17.100000000000001, 18.0, 1, 4.5 },
                    { 31, 10.0, 0.0, 250, 12.0, 8.0, 10.0, "Helm of Thorns", 17.0, 8.0, 7.0, 18.5, 16.100000000000001, 17.0, 1, 4.0999999999999996 },
                    { 32, 11.0, 18.0, 500, 13.0, 10.0, 12.0, "Helm of the Wise", 19.0, 8.0, 7.0, 20.699999999999999, 17.100000000000001, 18.0, 1, 5.0999999999999996 },
                    { 33, 7.0, 0.0, 200, 6.0, 4.0, 6.0, "Hollow Soldier Helm", 10.0, 5.0, 5.0, 11.1, 10.0, 8.8000000000000007, 1, 3.0 },
                    { 34, 9.0, 0.0, 250, 9.0, 6.0, 9.0, "Hollow Thief's Hood", 17.0, 8.0, 6.0, 21.0, 16.0, 17.0, 1, 1.1000000000000001 },
                    { 35, 5.0, 0.0, 250, 5.0, 6.0, 6.0, "Hollow Warrior Helm", 10.0, 3.0, 5.0, 10.300000000000001, 9.6999999999999993, 9.5, 1, 2.6000000000000001 },
                    { 36, 8.0, 2.0, 350, 10.0, 9.0, 10.0, "Iron Helm", 14.0, 8.0, 12.0, 14.0, 14.0, 13.699999999999999, 1, 4.5 },
                    { 37, 9.0, 0.0, 400, 9.0, 5.0, 8.0, "Knight Helm", 14.0, 8.0, 6.0, 16.0, 13.0, 14.0, 1, 4.2000000000000002 },
                    { 38, 9.0, 3.0, 150, 5.0, 6.0, 8.0, "Maiden Hood", 7.0, 0.0, 7.0, 7.0, 8.1999999999999993, 7.0, 1, 0.80000000000000004 },
                    { 39, 9.0, 20.0, 400, 10.0, 7.0, 12.0, "Mask of Velka", 12.0, 0.0, 9.0, 12.0, 13.0, 12.0, 1, 2.5 },
                    { 40, 6.0, 0.0, 200, 8.0, 10.0, 10.0, "Mask of the Child", 6.0, 0.0, 0.0, 6.0, 6.0, 6.0, 1, 1.2 },
                    { 41, 6.0, 0.0, 200, 6.0, 8.0, 10.0, "Mask of the Father", 6.0, 0.0, 0.0, 6.0, 6.0, 6.0, 1, 1.2 },
                    { 42, 10.0, 0.0, 200, 6.0, 8.0, 12.0, "Mask of the Mother", 6.0, 0.0, 0.0, 6.0, 6.0, 6.0, 1, 1.2 },
                    { 43, 8.0, 8.0, 400, 7.0, 9.0, 12.0, "Mask of the Sealer", 12.0, 0.0, 8.0, 12.0, 13.0, 12.0, 1, 1.5 },
                    { 44, 18.0, 8.0, 700, 6.0, 6.0, 5.0, "Ornstein's Helm", 32.0, 9.0, 8.0, 36.200000000000003, 30.399999999999999, 32.0, 1, 5.5 },
                    { 45, 12.0, 0.0, 150, 11.0, 8.0, 31.0, "Painting Guardian Hood", 3.0, 0.0, 30.0, 3.0, 3.6000000000000001, 3.0, 1, 0.59999999999999998 },
                    { 46, 13.0, 22.0, 500, 13.0, 7.0, 12.0, "Paladin Helm", 22.0, 8.0, 9.0, 25.300000000000001, 20.899999999999999, 22.0, 1, 5.0 },
                    { 47, 6.0, 0.0, 250, 7.0, 7.0, 5.0, "Pharis's Hat", 7.0, 0.0, 5.0, 7.0, 7.0, 7.0, 1, 1.2 },
                    { 48, 11.0, 11.0, 250, 12.0, 8.0, 10.0, "Porcelain Mask", 13.0, 3.0, 19.0, 13.6, 13.0, 14.300000000000001, 1, 2.5 },
                    { 49, 9.0, 0.0, 350, 5.0, 7.0, 9.0, "Priest's Hat", 9.0, 0.0, 8.0, 8.0, 9.4000000000000004, 8.0, 1, 1.2 },
                    { 50, 16.0, 0.0, 500, 10.0, 6.0, 10.0, "Royal Helm", 16.0, 8.0, 12.0, 16.0, 13.9, 16.0, 1, 4.5 },
                    { 51, 12.0, 0.0, 150, 8.0, 4.0, 6.0, "Sack", 6.0, 0.0, 10.0, 6.0, 10.0, 5.0, 1, 0.59999999999999998 },
                    { 52, 15.0, 0.0, 200, 6.0, 6.0, 5.0, "Shadow Mask", 9.0, 0.0, 18.0, 9.0, 9.9000000000000004, 9.0, 1, 0.90000000000000002 },
                    { 53, 9.0, 1.0, 600, 11.0, 14.0, 10.0, "Silver Knight Helm", 21.0, 8.0, 5.0, 24.100000000000001, 19.699999999999999, 20.600000000000001, 1, 4.7999999999999998 },
                    { 54, 15.0, 0.0, 300, 17.0, 13.0, 18.0, "Six-Eyed Helm of the Channelers", 20.0, 5.0, 13.0, 22.800000000000001, 19.199999999999999, 20.0, 1, 3.8999999999999999 },
                    { 55, 21.0, 5.0, 700, 26.0, 21.0, 19.0, "Smough's Helm", 40.0, 14.0, 12.0, 46.0, 34.799999999999997, 40.0, 1, 6.7999999999999998 },
                    { 56, 19.0, 0.0, 300, 9.0, 12.0, 13.0, "Snickering Top Hat", 12.0, 0.0, 14.0, 12.0, 16.199999999999999, 12.0, 1, 2.0 },
                    { 57, 6.0, 0.0, 200, 5.0, 6.0, 10.0, "Sorcerer Hat", 8.0, 0.0, 5.0, 8.0, 9.0, 8.0, 1, 1.2 },
                    { 58, 9.0, 0.0, 250, 8.0, 3.0, 8.0, "Standard Helm", 14.0, 5.0, 8.0, 16.0, 8.0, 14.0, 1, 3.5 },
                    { 59, 9.0, 0.0, 500, 8.0, 5.0, 8.0, "Steel Helm", 16.0, 9.0, 6.0, 18.399999999999999, 15.0, 16.0, 1, 5.4000000000000004 },
                    { 60, 17.0, 0.0, 800, 21.0, 21.0, 17.0, "Stone Helm", 35.0, 15.0, 6.0, 40.299999999999997, 32.899999999999999, 35.0, 1, 6.7999999999999998 },
                    { 61, 0.0, 0.0, 80, 24.0, 13.0, 5.0, "Sunlight Maggot", 6.0, 0.0, 0.0, 6.0, 6.0, 6.0, 1, 1.3999999999999999 },
                    { 62, 10.0, 0.0, 300, 2.0, 2.0, 8.0, "Symbol of Avarice", 21.0, 15.0, 0.0, 21.0, 10.9, 21.0, 1, 10.0 },
                    { 63, 9.0, 1.0, 400, 12.0, 6.0, 9.0, "Tattered Cloth Hood", 8.0, 0.0, 23.0, 8.0, 8.9000000000000004, 8.0, 1, 1.1000000000000001 },
                    { 64, 9.0, 0.0, 250, 5.0, 6.0, 8.0, "Thief Mask", 9.0, 0.0, 12.0, 9.0, 10.0, 9.0, 1, 1.2 },
                    { 65, 8.0, 0.0, 400, 9.0, 10.0, 8.0, "Wanderer Hood", 9.0, 0.0, 8.0, 10.0, 10.0, 9.0, 1, 1.3999999999999999 },
                    { 66, 10.0, 11.0, 250, 6.0, 7.0, 12.0, "Witch Hat", 9.0, 0.0, 10.0, 9.0, 10.0, 9.0, 1, 1.1000000000000001 },
                    { 67, 8.0, 35.0, 400, 3.0, 8.0, 15.0, "Xanthous Crown", 18.0, 0.0, 11.0, 18.0, 28.0, 15.0, 1, 5.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armors");

            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}
