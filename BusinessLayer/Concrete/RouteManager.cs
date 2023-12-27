using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RouteManager : IRouteService
    {
        IRoute _IRoute;

        public RouteManager(IRoute ıRoute)
        {
            _IRoute = ıRoute;
        }

        public Route GetRoute(int? id)
        {
            return _IRoute.Get(x => x.RouteID == id);
        }

        public List<Route> GetRoutes()
        {
            return _IRoute.List();
        }

        public void RouteAdd(Route route)
        {
            _IRoute.insert(route);
        }

        public void RouteDelete(Route route)
        {
            _IRoute.delete(route);
        }

        public void RouteUpdate(Route route)
        {
            _IRoute.update(route);
        }
    }
}
