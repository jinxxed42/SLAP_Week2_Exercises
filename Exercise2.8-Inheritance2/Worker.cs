using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._8_Inheritance2
{
    internal abstract class Worker
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public int HoursPerWeek { get; } = 37;

        public Worker(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public new virtual string ToString()
        {
            return $"Name: {Name}, Address: {Address}";
        }

        public abstract double CalcWeeklyWage();

    }
}
