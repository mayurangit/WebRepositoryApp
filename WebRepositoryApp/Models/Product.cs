using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebRepositoryApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("product_name")]
        [DisplayName("Product Name")]
        public string? ProductName { get; set; }

        [Required]
        public String Price { get; set; }
    }
}
