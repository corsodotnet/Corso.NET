using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifake.Entities
{
    public class Person
    {
        string _name;
        string _surname;
        string _birthDtae;

        public Person(string name, string surname, string birthDtae)
        {
            this._name = name;
            this._surname = surname;
            this._birthDtae = birthDtae;
        }
    }
}
