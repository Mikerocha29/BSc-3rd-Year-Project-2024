using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace site2024.Models
{
   
    public class Supplement
    {
        public int SupplementId { get; set; } 

        // Name of the supplement
        [Required(ErrorMessage = "The name of the supplement must be provided")]
        [Display(Name = "Name of the supplement")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "The {0} must have a minimum of {1} and a maximum of {2} characters")]
        public string Name { get; set; }

        // Short description Short of the supplement
        [Required(ErrorMessage = "The description of the supplement must be provided")]
        [Display(Name = "Description of the Supplement")]
        [MinLength(20, ErrorMessage = "Description must be at least {1} characters long")]
        [MaxLength(200, ErrorMessage = "Description can exceed {1} characters")]
        public string DescriptionShort { get; set; }

        // Detailed description Long of the supplement
        [Required(ErrorMessage = "A detailed description of the supplement must be provided")]
        [Display(Name = "Detailed Description of the Supplement")]
        [MinLength(20, ErrorMessage = "Detailed description must be at least {1} characters long")]
        [MaxLength(200, ErrorMessage = "Detailed description can exceed {1} characters")]
        public string DescriptionLong { get; set; }

        // Price of the supplement
        [Required(ErrorMessage = "Please enter the supplement price")]
        [Display(Name = "Price")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "The price must be between 1 and 999.99")]
        public decimal Price { get; set; }

        // Path to the normal image of the supplement
        [Display(Name = "Normal Image Path")]
        [StringLength(200, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string ImageUrl { get; set; }

        // Path to the thumbnail image of the supplement
        [Display(Name = "Thumbnail Image Path")]
        [StringLength(200, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string ImageThumbnailUrl { get; set; }

        // Indicates whether the supplement is a bestseller
        [Display(Name = "Bestseller!")]
        public bool Bestsellers { get; set; }

        // Indicates whether the supplement is in stock
        [Display(Name = "Stock")]
        public bool Stock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
