using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Spread_PublicPunish
{
    public class EURegion : Region
    {
        public EUParlament parliament;
        private new EUCounty[] _counties;
        public new EUCountry country;
        public int CountyNumber;
        public EURegion(EUParlament parliament, EUCountry Country, EUCounty county, String name, double area) : base(name, area)
        {
            this.parliament = parliament;
            this.country = country;
            this._counties = new EUCounty[20];
        }
        public override void AddCounty()
        {
            _counties[number] = new EUCounty(this.parliament, this, "placeholder", 0)
            {
                _counties[] = new
                CountyNumber++;
            }
        }
    }
}
