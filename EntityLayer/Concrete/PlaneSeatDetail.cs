using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PlaneSeatDetail
    {
        public int SeatId { get; set; }
        [Range(1, 50)]
        public int SeatNumber { get; set; }
        public int PlaneId { get; set; }

        public Plane Plane { get; set; }
        public SeatStatus SeatStatus { get; set; }

        
    }
    public enum SeatStatus
    {

        Taken,
        Untaken
    }
}
