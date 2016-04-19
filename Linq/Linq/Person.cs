using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Person
    {
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Pesel { get; set; }
        public Person(string firstName, DateTime birthDate, int pesel)
        {
            FirstName = firstName;
            BirthDate = birthDate;
            Pesel = pesel;
        }
    }
}
