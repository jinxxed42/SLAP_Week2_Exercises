using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._9_CprClass
{
    internal class Worker
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Cpr Cpr { get; set; }
        public string WorkerNumber { get; set; }
        public int HoursPerWeek { get; } = 37;

        public Worker(string name, string address, Cpr cpr, string workerNumber)
        {
            Name = name;
            Address = address;
            Cpr = cpr;
            WorkerNumber = workerNumber;
        }

        public override string ToString()
        {
            return $"""
                Name: {Name}
                Address: {Address}
                Cpr: {Cpr.BirthDate}-{Cpr.SequenceNumber}
                Worker #: {WorkerNumber}
                """;
        }
    }
}
