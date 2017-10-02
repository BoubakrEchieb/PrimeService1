using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeService1
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            return false;
        }
        public bool IsOddNumber(int number)
        {
            return number%2 != 0;
        }
        public bool IsAboveForTeen(Person person)
        {
            return person.Age > 14;
        }
    }
}
