using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fussball fb = new Fussball("Real Madrid", "Barcelona", "20:45", true);

            Console.WriteLine(fb.ChangeUhrzeit);
            Console.WriteLine(fb.ChangeUhrzeit = "21:45");
            Console.WriteLine(fb.ChangeUhrzeit);

        }
    }
}
