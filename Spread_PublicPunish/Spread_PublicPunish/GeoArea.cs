using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spread_PublicPunish
{
    public abstract class GeoArea {
        string _name;
        double _area;
        public GeoArea(string name, double area)
        {
            _name = name;
            _area = area;
        }
        public double Area { get { return _area; } }
        public string Nmae { get { return _name; } }    
    }

}
