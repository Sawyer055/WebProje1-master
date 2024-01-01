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
    public class PlaneManager : IPlaneService
    {
        IPlane _IPlane;

        public PlaneManager(IPlane ıPlane)
        {
            _IPlane = ıPlane;
        }
        public Plane GetPlane(int? id)
        {
            return _IPlane.Get(x=>x.PlaneID==id);
        }

        public List<Plane> GetPlanes()
        {
            return _IPlane.List();
        }

        public void PlaneAdd(Plane plane)
        {
            _IPlane.insert(plane);
        }

        public void PlaneDelete(Plane plane)
        {
            _IPlane?.delete(plane);
        }

        public void PlaneUpdate(Plane plane)
        {
            _IPlane.update(plane);
        }
    }
}
