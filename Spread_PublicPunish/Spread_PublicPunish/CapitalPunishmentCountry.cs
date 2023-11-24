using Spread_PublicPunish.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spread_PublicPunish
{
    class CapitalPunishmentCountry : State, IONU, ICapitalPunishment
    {
        public CapitalPunishmentCountry(string Name, string State, string Government, string Constitution) :
            base(Name, State, Government, Constitution)
        {
        }
        public void Death()
        {
            Console.WriteLine("Apply death Punishment");
        }
        public virtual void PopulationControl()
        {
            Console.WriteLine("");
        }
        public void TerritoryControl()
        {
            Console.WriteLine("");
        }
    }
}
