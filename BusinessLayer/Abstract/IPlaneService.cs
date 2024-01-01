using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPlaneService
    {
        List<Plane> GetPlanes();
        void PlaneAdd(Plane plane);
        void PlaneDelete(Plane plane);
        void PlaneUpdate(Plane plane);
        Plane GetPlane(int? id);
    }
}
