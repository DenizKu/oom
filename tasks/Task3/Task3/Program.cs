using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            IZoohandlungService K1 = new KundeIn(01,"Max","Mustermann","Musteradresse");
            IZoohandlungService M1 = new MitarbeiterIn(05, 'V', 1500.00, "Klaus", "Klaas", "Klausgasse");
            IZoohandlungService P1 = new KundeIn(02, "Martin", "Martaus", "Martangasse");
            IZoohandlungService[] allObjectZoo = { K1, M1, P1};
            foreach (IZoohandlungService I in allObjectZoo)
            {
                I.IchBinEin();              
            }

        }
    }
}
