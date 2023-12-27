using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        [Key]
        [Display(Name = "ID")]
        public int CustomerID { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name area cannot be empty!")]
        [StringLength(30,MinimumLength =3,ErrorMessage = "Please enter between 3-30 characters")]
        public string CustomerName { get; set; }

        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Surname area cannot be empty!")]
        [StringLength(30, MinimumLength = 3,ErrorMessage = "Please enter between 3-30 characters")]

        public string CustomerSurname { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password area cannot be empty!")]
        [StringLength(20, MinimumLength = 3,ErrorMessage = "Please enter between 3-20 characters")]

        public string CustomerPassword { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email area cannot be empty!")]
        [EmailAddress]
        public string CustomerEmail { get; set; }
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number area cannot be empty!")]
        [Phone]

        public string CustomerPhoneNumber { get; set; }

        public ICollection<Route> ?Routes { get; set; }

        
    }
}
