using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._8_Inheritance2
{
    internal class Mechanic : Worker
    {
        public int JourneymanYear { get; set; }
        public double HourlyWage { get; set; }

        public Mechanic(string name, string address, int journeymanYear, double hourlyWage) : base(name, address)
        {
            JourneymanYear = journeymanYear;
            HourlyWage = hourlyWage;
        }

        public override string ToString()
        {
            return base.ToString() + $", passed journeyman test in {JourneymanYear}, gets {HourlyWage}kr an hour";
        }

        public override double CalcWeeklyWage()
        {
            return HourlyWage * HoursPerWeek;
        }
    }
}
