using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    class Program
    {
        static void Main(string[] args)
        {
            //int p = 3;
            //int calcEnd = (p >= 15) ? 2 : ((p >= 10) ? 1 : ((p >= 5) ? 0 : -1));

            //Console.WriteLine(calcEnd);


            Console.WriteLine("Quel race voulez-vous incarner ? 1 : Nain / 2 : Humain");
            string race = Console.ReadLine();

            if (race.ToLower() == "nain" || race.ToLower() == "n" || race == "1")
            {
                Foret f = new Foret("nain");
                Console.WriteLine("Votre héro sera un nain.");
                f.Play();
            }
            else if (race.ToLower() == "humain" || race.ToLower() == "h" || race == "2")
            {
                Foret f = new Foret("humain");
                Console.WriteLine("Votre héro sera un humain.");
                f.Play();
            }
            else
            {
                Console.WriteLine("error");
            }



            Console.ReadLine();

        }
    }
}
