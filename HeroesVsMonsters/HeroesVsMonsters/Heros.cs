using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    public abstract class Heros : Personnage, IOr, ICuir
    {

        private int _or;
        public int Or
        {
            get { return _or; }
            private set { _or = value; }
        }

        private int _cuir;
        public int Cuir
        {
            get { return _cuir; }
            private set { _cuir = value; }
        }



        public void Repos()
        {
            this.ResetPv();
        }

        public void Depouiller(Monstres m)
        {
            this.Cuir += (m is ICuir) ? ((ICuir)m).Cuir : 0;
            this.Or += (m is IOr) ? ((IOr)m).Or : 0;
        }

    }
}
