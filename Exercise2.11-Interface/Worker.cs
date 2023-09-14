using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._11_Interface
{
    internal class Worker : IHasAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Cpr CprNr { get; set; }
        public string WorkerNumber { get; set; }
        public int HoursPrWeek { get; } = 37;

        public Worker(string name, string address, Cpr cprNr, string workerNumber)
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
                Address: {Address}
                Cpr number: {CprNr.BirthDate}-{CprNr.SequenceNumber}
                Worker number: {WorkerNumber}
                """;
        }
    }
}
