using System;
using System.Collections.Generic;
using System.Text;

namespace Inherit
{
    class CheckYear:Check
    {
        public int Year { get; set; }

        public CheckYear(decimal price, int count, int year):base(price,count)
        {
            Year = year;
        }

        public int Age()
        {
            DateTime date = DateTime.Now;
            return date.Year - Year;
        }
    }
}
