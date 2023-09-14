using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._10._1_Collection
{
    internal class Cpr
    {
        public string BirthDate { get; set; }
        public string SequenceNumber { get; set; }

        public Cpr(string birthDate, string sequenceNumber)
        {
            BirthDate = birthDate;
            SequenceNumber = sequenceNumber;
        }
    }
}
