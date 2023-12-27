using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email area cannot be empty!")]
        [EmailAddress]
        public string AdminEmail { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password area cannot be empty!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please enter between 3-20 characters")]
        public string AdminPassword { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name area cannot be empty!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Please enter between 3-30 characters")]
        public string AdminName { get; set; }

        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Surname area cannot be empty!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Please enter between 3-30 characters")]

        public string AdminSurname { get; set; }



    }
}
