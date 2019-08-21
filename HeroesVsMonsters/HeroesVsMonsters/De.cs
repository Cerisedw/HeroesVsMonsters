using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    public class De
    {

        private static Random _rnd = new Random();

        public int Min
        {
            get { return 1; }
        }

        private int _max;
        public int Max
        {
            get { return _max; }
            private set { _max = value; }
        }

        public De(int i)
        {
            Max = i;
        }

        public int Lance()
        {
            return _rnd.Next(Min, Max + 1);
        }


        public static int CalculStat()
        {
            De d = new De(6);
            int stat = 0;
            int ef = 0;
            for (int i = 0; i<4; i++)
            {
                int randNmb = d.Lance();
                if (i == 0)
                {
                    ef += randNmb;
                }
                else
                {
                    if (ef >= randNmb)
                    {
                        stat += ef;
                        ef = randNmb;
                    }
                    else
                    {
                        stat += randNmb;
                    }
                }
            }
            return stat;
        }

    }
}
