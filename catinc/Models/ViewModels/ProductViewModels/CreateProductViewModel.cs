using System;
using System.ComponentModel.DataAnnotations;

namespace catinc.Models.ViewModels.ProductViewModels
{
    public class CreateProductViewModel
    {
        [Display(Name = "SKU")]
        public string ProductSKU { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal ProductPrice { get; set; }
        [Required]
        [Display(Name = "Inventory Amount")]
        public int ProductInventory { get; set; }
        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public string ProductImageURL { get; set; }
        [Display(Name = "Expiration Date")]
        [DataType(DataType.DateTime)]
        public DateTime ProductExpirationDate { get; set; }
        [Display(Name = "Product's Short Description")]
        public string ProductShortDescription { get; set; }
        [Display(Name = "Product's Long Description")]
        public string ProductLongDescription { get; set; }
    }
}