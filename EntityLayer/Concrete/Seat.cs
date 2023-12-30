using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Seat
    {
        [Key]
        public int SeatID { get; set; }
        [Range(1,50)]
        public int SeatNumber { get; set; }
        public bool IsReserved { get; set; }
        public int PlaneID { get; set; }
        public Plane Plane { get; set; }

    }
}
