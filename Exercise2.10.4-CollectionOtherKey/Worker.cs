using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._10._4_CollectionOtherKey
{
    internal class Worker
    {
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public Cpr CprNr { get; set; }
        public string MedarbejderNummer { get; set; }
        public int TimerPrUge { get; } = 37;

        public Worker(string navn, string adresse, Cpr cprNr, string medarbejderNummer)
        {
            Navn = navn;
            Adresse = adresse;
            CprNr = cprNr;
            MedarbejderNummer = medarbejderNummer;
        }

        public override string ToString()
        {
            return $"""
                Navn: {Navn}
                Adresse: {Adresse}
                CprNr: {CprNr.BirthDate}-{CprNr.SequenceNumber}
                Medarbejdernummer: {MedarbejderNummer}
                """;
        }
    }
}
