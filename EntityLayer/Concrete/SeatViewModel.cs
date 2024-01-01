using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SeatViewModel
    {
		public int SelectedRouteID { get; set; }
		public Route SelectedRoute { get; set; }
		public IEnumerable<Route> Routes { get; set; }
	}
}
