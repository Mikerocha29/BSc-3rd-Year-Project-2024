using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace site2024.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(100,ErrorMessage ="the maximum lenght is 800 characters")]
        [Required(ErrorMessage ="please provide the category name")]
        [Display(Name ="Name")]
        public string CategoryName { get; set; }
        [StringLength(200, ErrorMessage = "the maximum lenght is 800 characters")]
        [Required(ErrorMessage = "please provide the category description")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public List<Supplement> Supplements { get; set; }
        

    }
}
