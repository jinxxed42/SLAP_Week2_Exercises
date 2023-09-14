using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._7_Inheritance
{
    internal class Worker
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Worker(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public new virtual string ToString()
        {
            return $"Name: {Name}, Address: {Address}";
        }
    }
}
