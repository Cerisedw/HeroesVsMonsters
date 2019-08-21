using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    public class Dragonnet : Monstres, IOr, ICuir
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

        public override int End
        {
            get { return base.End + 1; }
        }


        public Dragonnet() : base()
        {
            this.Or = this.D6.Lance();
            this.Cuir = this.D4.Lance();
        }


    }
}
