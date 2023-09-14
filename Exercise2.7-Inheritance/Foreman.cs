using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._7_Inheritance
{
    internal class Foreman : Mechanic
    {
        public int AppointmentYear { get; set; }
        public double Bonus { get; set; }

        public Foreman(string name, string address, int journeymanYear, double hourlyWage, int appointmentYear, double bonus)
            : base(name, address, journeymanYear, hourlyWage)
        {
            AppointmentYear = appointmentYear;
            Bonus = bonus;
        }

        public override string ToString()
        {
            return base.ToString() + $", was appointed in {AppointmentYear}, gets {Bonus}kr as bonus";
        }
    }
}
