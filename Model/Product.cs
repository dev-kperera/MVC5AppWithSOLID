using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;//include this with adding assembly "System.ComponentModel.DataAnnotations"

namespace Model
{
    [Table("ProductTable")]// Name for the product table
    public class Product
    {
        public int ProductID { get; set; }
        public string Description { get; set; }

        [Range(0,1000)]
        public decimal Price { get; set; }
    }
}
