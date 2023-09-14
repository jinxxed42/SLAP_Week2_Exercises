using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._8_Inheritance2
{
    internal class VehicleInspector : Mechanic
    {
        public int Inspections { get; set; }
        public int WeeklyWage { get { return 290 * Inspections; } }

        public VehicleInspector(string name, string address, int journeymanTest, double weeklyWage, int inspections)
            : base(name, address, journeymanTest, weeklyWage)
        {
            Inspections = inspections;
        }

        public override string ToString()
        {
            return base.ToString() + $", does {Inspections} inspections in a week and gets {WeeklyWage}kr as weekly wage";
        }

        public override double CalcWeeklyWage()
        {
            return WeeklyWage;
        }
    }
}
