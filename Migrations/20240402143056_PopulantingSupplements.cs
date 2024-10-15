using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace site2024.Migrations
{
    /// <inheritdoc />
    public partial class PopulantingSupplements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Supplements(CategoryId,DescriptionShort,DescriptionLong,stock,ImageThumbnailUrl,ImageUrl,Bestsellers,Name,Price) VALUES(2,'WHEY Protein Blend (98%) [MILK] (WHEY Protein Isolate.','Low in sugar fat and less than 90 calories.',1,'https://www.hpnutrition.ie/image/cache/catalog/Biotech%20Usa/Biotech-vegan-whey-free-shaker-1000x1000.jpg','https://www.hpnutrition.ie/image/cache/catalog/Biotech%20Usa/Biotech-vegan-whey-free-shaker-1000x1000.jpg',1,'Biotech USA Vegan',48.99)");
            migrationBuilder.Sql("INSERT INTO Supplements(CategoryId,DescriptionShort,DescriptionLong,stock,ImageThumbnailUrl,ImageUrl,Bestsellers,Name,Price) VALUES(1,'WHEY Protein Blend (98%) [MILK] (WHEY Protein Isolate.','Low in sugar fat and less than 120 calories.',1,'https://www.hpnutrition.ie/image/catalog/Optimum-Nutrition/Optimum-Nutrition-Gold-Standard-Whey/optimum-nutrition-gold-standard-whey-ireland.jpg','https://www.hpnutrition.ie/image/catalog/Optimum-Nutrition/Optimum-Nutrition-Gold-Standard-Whey/optimum-nutrition-gold-standard-whey-ireland.jpg',0,'Whey ',78.99)");
            migrationBuilder.Sql("INSERT INTO Supplements(CategoryId,DescriptionShort,DescriptionLong,stock,ImageThumbnailUrl,ImageUrl,Bestsellers,Name,Price) VALUES(1,'WHEY Protein Blend (98%) [MILK] (WHEY Protein Isolate.','Low in sugar.',1,'https://www.hpnutrition.ie/image/catalog/Optimum-Nutrition/Optimum-Nutrition-Gold-Standard-Whey/optimum-nutrition-gold-standard-whey-ireland.jpg','https://www.hpnutrition.ie/image/catalog/Optimum-Nutrition/Optimum-Nutrition-Gold-Standard-Whey/optimum-nutrition-gold-standard-whey-ireland.jpg',0,'Whey Protein',58.99)");
            migrationBuilder.Sql("INSERT INTO Supplements(CategoryId,DescriptionShort,DescriptionLong,stock,ImageThumbnailUrl,ImageUrl,Bestsellers,Name,Price) VALUES(1,'WHEY Protein Blend (98%) [MILK] (WHEY Protein Isolate.','Low in sugar fat and less.',1,'https://www.hpnutrition.ie/image/catalog/Optimum-Nutrition/Optimum-Nutrition-Gold-Standard-Whey/optimum-nutrition-gold-standard-whey-ireland.jpg','https://www.hpnutrition.ie/image/catalog/Optimum-Nutrition/Optimum-Nutrition-Gold-Standard-Whey/optimum-nutrition-gold-standard-whey-ireland.jpg',0,'Protein',58.99)");
            migrationBuilder.Sql("INSERT INTO Supplements(CategoryId,DescriptionShort,DescriptionLong,stock,ImageThumbnailUrl,ImageUrl,Bestsellers,Name,Price) VALUES(2,'WHEY Protein Blend (98%) [MILK] (WHEY Protein.','Low in sugar fat and less than 120 calories.',1,'https://www.hpnutrition.ie/image/catalog/Optimum-Nutrition/Optimum-Nutrition-Gold-Standard-Whey/optimum-nutrition-gold-standard-whey-ireland.jpg','https://www.hpnutrition.ie/image/catalog/Optimum-Nutrition/Optimum-Nutrition-Gold-Standard-Whey/optimum-nutrition-gold-standard-whey-ireland.jpg',1,'OPTIMUM',90.99)");
            migrationBuilder.Sql("INSERT INTO Supplements(CategoryId,DescriptionShort,DescriptionLong,stock,ImageThumbnailUrl,ImageUrl,Bestsellers,Name,Price) VALUES(2,'WHEY Protein Blend (98%) [MILK] (WHEY Protein Isolate.','Low in sugar fat and less than 100 calories.',1,'https://www.hpnutrition.ie/image/catalog/Optimum-Nutrition/Optimum-Nutrition-Gold-Standard-Whey/optimum-nutrition-gold-standard-whey-ireland.jpg','https://www.hpnutrition.ie/image/catalog/Optimum-Nutrition/Optimum-Nutrition-Gold-Standard-Whey/optimum-nutrition-gold-standard-whey-ireland.jpg',1,'Whey Protein',58.99)");
            migrationBuilder.Sql("INSERT INTO Supplements(CategoryId,DescriptionShort,DescriptionLong,stock,ImageThumbnailUrl,ImageUrl,Bestsellers,Name,Price) VALUES(2,'WHEY Protein Blend (98%) [MILK] (WHEY Protein Isolate.','Low in sugar fat and less than 90 calories.',1,'https://www.hpnutrition.ie/image/catalog/Optimum-Nutrition/Optimum-Nutrition-Gold-Standard-Whey/optimum-nutrition-gold-standard-whey-ireland.jpg','https://www.hpnutrition.ie/image/catalog/Optimum-Nutrition/Optimum-Nutrition-Gold-Standard-Whey/optimum-nutrition-gold-standard-whey-ireland.jpg',1,'Whey Protein',50.99)");
            migrationBuilder.Sql("INSERT INTO Supplements(CategoryId,DescriptionShort,DescriptionLong,stock,ImageThumbnailUrl,ImageUrl,Bestsellers,Name,Price) VALUES(2,'WHEY Protein Blend (98%) [MILK] (WHEY Protein Isolate.','Low in sugar fat and less than 90 calories.',1,'https://www.hpnutrition.ie/image/cache/catalog/Applied/2023/Stacks/applied-critical-whey-beef-xp-1000x1000.jpg','https://www.hpnutrition.ie/image/cache/catalog/Applied/2023/Stacks/applied-critical-whey-beef-xp-1000x1000.jpg',1,'OPTIMUM',48.99)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Supplements");
        }
    }
}
