using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    public class Orque : Monstres, IOr
    {

        private int _or;
        public int Or
        {
            get { return _or; }
            private set { _or = value; }
        }

        public override int For
        {
            get { return base.For + 1; }
        }


        public Orque() : base()
        {
            this.Or = this.D6.Lance();
        }


    }
}
