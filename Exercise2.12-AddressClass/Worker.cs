using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._12_AddressClass
{
    internal class Worker : IHasAddress
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public Cpr CprNr { get; set; }
        public string WorkerNumber { get; set; }
        public int HoursPrWeek { get; } = 37;

        public Worker(string name, Address address, Cpr cprNr, string workerNumber)
        {
            Name = name;
            Address = address;
            CprNr = cprNr;
            WorkerNumber = workerNumber;
        }

        public override string ToString()
        {
            return $"""
                Name: {Name}
                Address: {Address.Road} {Address.Number}
                Address2: {Address.AdditionalInfo}
                City: {Address.City}
                Cpr number: {CprNr.BirthDate}-{CprNr.SequenceNumber}
                Worker number: {WorkerNumber}
                """;
        }
    }
}
