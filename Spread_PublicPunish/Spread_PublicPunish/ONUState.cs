using Spread_PublicPunish.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spread_PublicPunish
{
    public class ONUState : State, IPoliticOrgIONU
    {
        public void PopulationControl() { }
        public void TerritoryControl() { }
        public ONUState(string Name, string State, string Government, string Constitution) :
           base(Name, State, Government, Constitution)
        {

        }
    }
}
