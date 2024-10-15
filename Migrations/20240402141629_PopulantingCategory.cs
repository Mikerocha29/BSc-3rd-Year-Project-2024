using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace site2024.Migrations
{
    /// <inheritdoc />
    public partial class PopulantingCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Category(CategoryName, Description) " +
               "VALUES('Whey Vegan','Vegan protein complex (rice and peas) with added functional amino acids')");

            migrationBuilder.Sql("INSERT INTO Category(CategoryName, Description) " +
               "VALUES('Whey Beef','Beef-XP is a dairy-free source of protein and is 100% hydrolysed beef sourced from bovine.')");


            migrationBuilder.Sql("INSERT INTO Category(CategoryName, Description) " +
               "VALUES('Whey Vegan','Vegan protein complex (rice and peas) with added functional amino acids')");

            migrationBuilder.Sql("INSERT INTO Category(CategoryName, Description) " +
               "VALUES('Whey Vegan','Vegan protein complex (rice and peas) with added functional amino acids')");
            migrationBuilder.Sql("INSERT INTO Category(CategoryName, Description) " +

               "VALUES('Whey Vegan','Vegan protein complex (rice and peas) with added functional amino acids')");
            
            migrationBuilder.Sql("INSERT INTO Category(CategoryName, Description) " +
               "VALUES('Whey Isolate','25g of Primary Hydrolyzed Whey Protein Isolates')"); 

            migrationBuilder.Sql("INSERT INTO Category(CategoryName, Description) " +
               "VALUES('PhD Smart Breakfast 600g','PhD Smart Breakfast also contains vitamins, minerals and healthy Lactospore probiotics ')");

            migrationBuilder.Sql("INSERT INTO Category(CategoryName, Description) " +
               "VALUES('PhD Smart Breakfast 600g','PhD Smart Breakfast also contains vitamins, minerals and healthy Lactospore probiotics ')");

            migrationBuilder.Sql("INSERT INTO Category(CategoryName, Description) " +
                "VALUES('PhD Smart Breakfast 600g','PhD Smart Breakfast also contains vitamins, minerals and healthy Lactospore probiotics ')");

            migrationBuilder.Sql("INSERT INTO Category(CategoryName, Description) " +
               "VALUES('Whey Vegan','Vegan protein complex (rice and peas) with added functional amino acids')");

            migrationBuilder.Sql("INSERT INTO Category(CategoryName, Description) " +
               "VALUES('Whey Vegan','Vegan protein complex (rice and peas) with added functional amino acids')");





        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Category");
        }
    }
}
