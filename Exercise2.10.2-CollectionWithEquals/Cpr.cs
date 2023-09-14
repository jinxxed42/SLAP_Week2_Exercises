using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._10._2_CollectionWithEquals
{
    internal class Cpr : IEquatable<Cpr?>
    {
        public string BirthDate { get; set; }
        public string SequenceNumber { get; set; }

        public Cpr(string birthDate, string sequenceNumber)
        {
            BirthDate = birthDate;
            SequenceNumber = sequenceNumber;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Cpr);
        }

        public bool Equals(Cpr? other)
        {
            return other is not null &&
                   BirthDate == other.BirthDate &&
                   SequenceNumber == other.SequenceNumber;
        }

        public static bool operator ==(Cpr? left, Cpr? right)
        {
            return EqualityComparer<Cpr>.Default.Equals(left, right);
        }

        public static bool operator !=(Cpr? left, Cpr? right)
        {
            return !(left == right);
        }
    }
}
