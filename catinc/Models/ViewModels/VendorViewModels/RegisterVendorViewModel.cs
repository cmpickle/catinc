using System.ComponentModel.DataAnnotations;
using catinc.Models.Domain;

namespace catinc.Models.ViewModels.VendorViewModels
{
    public class RegisterVendorViewModel
    {
        [Required]
        [Display(Name = "Vendor Name")]
        public string VendorName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telephone Number")]
        public string TelephoneNo { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.CreditCard)]
        [Display(Name = "Credit Card Number")]
        public int CreditcardNo { get; set; }

        public int UserID { get; set; }

        public string UserName { get; set; }
    }
}