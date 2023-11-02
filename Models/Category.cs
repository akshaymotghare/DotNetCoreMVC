using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace buybook.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [DisplayName("Category Name")]
        [Required (ErrorMessage ="Kuch to input de yarr")]
        [MaxLength(30)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage ="Tu kr kya raha hai bhai 1-100 accept krunga")]
        public int DisplayOrder { get; set; } 
    }
}
