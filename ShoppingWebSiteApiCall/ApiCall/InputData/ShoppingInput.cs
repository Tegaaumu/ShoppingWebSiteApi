using System.ComponentModel.DataAnnotations;

namespace ApiCall.InputData
{
    public class ShoppingInput
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProductImage { get; set; }

        [Required]
        public string ProductName{ get; set; }

        [Required]
        public double ProductPriceM { get; set; }
        public double ProductPriceF { get; set; }
        public string BrandName { get; set; }

        public string CompanyImage { get; set; }

        [Required]
        public string Categpories { get; set; }
        
        [Required]
        public double StarRatings { get; set; }


        [Required]
        public int ItemsRemaining { get; set; }
    }
}
