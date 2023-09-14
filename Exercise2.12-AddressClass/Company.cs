using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._12_AddressClass
{
    internal class Company : IHasAddress
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Cvr { get; set; }

        public Company(string name, Address address, string cvr)
        {
            Name = name;
            Address = address;
            Cvr = cvr;
        }

        public override string ToString()
        {
            return $"""
                Name: {Name}
                Address: {Address.Road} {Address.Number}
                Address2: {Address.AdditionalInfo}
                City: {Address.City}
                Cvr: {Cvr}
                """;
        }
    }
}
