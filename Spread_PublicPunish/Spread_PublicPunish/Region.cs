using Spread_PublicPunish.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spread_PublicPunish
{
    public class Region : GeoArea, IAdministrationEntity
    {
        public State state;
        public County provincia;

        public Region(State s, string name, double area) : base(name, area)
        {
            state = s;
        }
        public void addCounty(County c)
        {
            provincia = c;
        }
        public void removeCounty(County c)
        {
            provincia = null;
        }
        public void changeState(State newState)
        {
            state.removeState(this);
            newState.addRegion(this);
            state = newState;
        }
    }
}
