using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Route
    {
        [Key]
        public int RouteID { get; set; }
        [Display(Name = "Route Name")]
        [StringLength(40,MinimumLength =5,ErrorMessage ="Please enter between 5-40 characters")]
        public string RouteName { get; set; }
        [Display(Name = "From")]
        [StringLength(40, ErrorMessage = "Please enter maximum 40 characters")]
        public string TakeOff { get; set; }
        [Display(Name = "To")]
        [StringLength(40, ErrorMessage = "Please enter maximum 40 characters")]
        public string Landing { get; set; }

        [Display(Name = "Date And Time")]

        public DateTime DateTime { get; set; }

        public ICollection<Plane> Planes { get; set; }

        public int? CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        
    }
}
