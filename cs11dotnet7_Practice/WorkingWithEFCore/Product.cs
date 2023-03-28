using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WorkingWithEFCore
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(40)]
        public string ProductName { get; set; } = null!;

        [Column("UnitPrice", TypeName = "money")]
        public decimal? Cost { get; set; }

        [Column("UnitsInStock")]
        public short? Stock { get; set; }

        public bool Discontinued { get; set; }

        //These two define the foreign key relationship
        //to the Categories table
        /* Category.Products and Product.Category are both marked as
         * virtual. This allows EF Core to inherit and override the
         * properties to provide extra features, such as lazy loading.
         */
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!; 

    }
}
