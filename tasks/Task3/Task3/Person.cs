using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    abstract class Person
    {
        private String vorname, nachname;
        private String adresse;

        public void PersonAnlegen(string vorname, string nachname, string adresse)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.adresse = adresse;
        }
    }
}
