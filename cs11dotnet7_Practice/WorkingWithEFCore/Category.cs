using System.ComponentModel.DataAnnotations.Schema;

namespace WorkingWithEFCore
{
    public class Category
    {
        /*Create three conventions for Category
         * Three of the four properties (mapped all columns in the database table)
         * The primary key
         * The one-to-many relationship to the Products table
         */
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        [Column(TypeName = "ntext")]
        public string? Description { get; set; }

        //defines a navigation property for related rows
        public virtual ICollection<Product> Products { get; set; }

        public Category() 
        {
            //To enable developers to add products to a Category, we must
            //initialize the navigation property to an empty collection
            Products = new HashSet<Product>();
        }
    }
}
