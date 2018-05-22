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

            K1.IchBinEin();
            M1.IchBinEin();
        }
    }
}
