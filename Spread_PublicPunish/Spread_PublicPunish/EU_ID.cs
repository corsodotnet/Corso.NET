using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spread_PublicPunish
{
    //NOOOOOOOOOOOO internal class EU_ID    
    public class EU_ID
    {
        string _idNumber;
        string _name;
        string _surname;
        string _birthDate;
        string _residenceCountry;

        public EU_ID(string id, string name, string surname, string birth, string residence)
        {
            this._idNumber = id;
            this._name = name;
            this._surname = surname;
            this._birthDate = birth;
            this._residenceCountry = residence;
        }
        public string IdNumber { get { return _idNumber; } }
        public string  Name { get { return _name; } }
        public string Surname { get { return _surname; } }
        public string BirthDate {  get { return _birthDate; } }
        public string ResidenceCountry {  get { return _residenceCountry; } private set {  _residenceCountry = value; } }
        public void ChangeEUCountry(EUCountry newEUCountry)
        {
            ResidenceCountry = newEUCountry.Name;
        }
    }
    
}
