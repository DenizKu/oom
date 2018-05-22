using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MitarbeiterIn:Person,IZoohandlungService
    {
        private readonly int mNummer;
        private char anstellungsArt;
        private double gehalt;

        public MitarbeiterIn(int mNummer,char anstellungsArt, double gehalt, String vorName, String nachName, String adresse)
        {
            this.mNummer = mNummer;
            this.anstellungsArt = anstellungsArt;
            this.gehalt = gehalt;
            PersonAnlegen(vorName, nachName, adresse);
        }

        public void IchBinEin()
        {
            Console.WriteLine("Ich bin ein Mitarbeiter mit der MitarbeiterID:" + mNummer);
        }

        public void lohnZettelDrucken()
        {
            Console.WriteLine("Das Gehalt betrug:" + gehalt + "in diesem Monat");
        }
    }
}
