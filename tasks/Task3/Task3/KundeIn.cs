using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class KundeIn:Person,IZoohandlungService
    {
        private readonly int kundennummer;

        public KundeIn(int knummer, String vorname,String nachname, String adresse)
        {
            kundennummer = knummer;
            PersonAnlegen(vorname, nachname, adresse);
        }

        public void IchBinEin()
        {
            Console.WriteLine("Ich bin ein Kunde mit der KundeID:" +kundennummer);
        }
    }
}
