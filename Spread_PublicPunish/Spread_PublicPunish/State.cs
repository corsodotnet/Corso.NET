using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spread_PublicPunish.Interfaces;


namespace Spread_PublicPunish
{
    abstract public class State : GeoArea, IAdministrationEntity
    {
        private string name;
        // ATTENZIONE: questo va public
        public Region region;        
        string _government;
        string _constitution;
        public string Name { get => name; set => name = value; }
        public string Government { get => _government; set => _government = value; }
        public string Constitution { get => _constitution; set => _constitution = value; }

        public State(string name, double area, string state, string Government, string Constitution):base(name,area)
        {
            name = name;
            _government = Government;
            _constitution = Constitution;
            ShowState();
        }
        void ShowState()
        {
            Console.WriteLine($"{Name} -  {Constitution}");
        }
        public void addRegion(Region r)
        {
            region = r;
        }
        public void removeRegion(Region r)
        {
            region = null;
        }
    }

}
