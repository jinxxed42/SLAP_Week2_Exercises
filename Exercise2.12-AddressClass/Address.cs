using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._12_AddressClass
{
    internal class Address
    {
        public string Road { get; set; }
        public string Number { get; set; }
        public string AdditionalInfo { get; set; }
        public string City { get; set; }

        public Address(string road, string number, string city)
        {
            Road = road;
            Number = number;
            AdditionalInfo = string.Empty;
            City = city;
        }

        public Address(string road, string number, string additionalInfo, string city) : this(road, number, city)
        {
            AdditionalInfo = additionalInfo;
        }

    }
}
