using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Fussball
    {
        private string team1, team2, uhrzeit;
        private bool findetstatt;

        public Fussball(string kteam1, string kteam2, string kuhrzeit, bool kstaat)
        {
            team1 = kteam1;
            team2 = kteam2;
            uhrzeit = kuhrzeit;
            findetstatt = kstaat;
        }

        public string ChangeUhrzeit
        {
            get
            {
                return uhrzeit;
            }
            set
            {
                uhrzeit = value;
            }
        }

        public void findetStatt(bool fstaat)
        {
            if (fstaat)
            {
                Console.WriteLine("Das Spiel findet statt");
            }
            else
            {
                Console.WriteLine("Das Spiel ist abgesagt");
            }
        }

    }
}
