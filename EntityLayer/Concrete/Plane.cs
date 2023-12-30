using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Plane
    {
        [Key]
        public int PlaneID { get; set; }
        [Display(Name = "Plane Name")]
        [StringLength(30,ErrorMessage = "Please enter maximum 30 characters")]
        public string PlaneName { get; set; }
        [Display(Name = "Total Seat Number")]
        [StringLength(3, ErrorMessage = "Please enter maximum 3 characters")]
        public int SeatNum { get; set; }
        [Display(Name = "Taken Seat ")]
        [StringLength(3, ErrorMessage = "Please enter maximum 3 characters")]
        public int UntakenSeat { get; set; }
        [Display(Name = "Untaken Seat ")]
        [StringLength(3, ErrorMessage = "Please enter maximum 3 characters")]
        public int TakenSeat { get; set; }
        [ForeignKey("Route")]

        public int? RouteID { get; set; }
        public virtual Route Route { get; set; }

        public ICollection<Seat> Seats { get; set; }

    }
}
