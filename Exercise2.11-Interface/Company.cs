using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._11_Interface
{
    internal class Company : IHasAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Cvr { get; set; }

        public Company(string name, string address, string cvr)
        {
            Name = name;
            Address = address;
            Cvr = cvr;
        }

        public override string ToString()
        {
            return $"""
                Name: {Name}
                Address: {Address}
                Cvr: {Cvr}
                """;
        }
    }
}
