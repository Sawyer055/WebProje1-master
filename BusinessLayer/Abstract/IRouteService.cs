using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRouteService
    {
        List<Route> GetRoutes();
        void RouteAdd(Route route);
        void RouteDelete(Route route);
        void RouteUpdate(Route route);
        Route GetRoute(int? id);

    }
}
