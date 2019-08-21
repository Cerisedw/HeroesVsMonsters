using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    public class Loup : Monstres, ICuir
    {

        private int _cuir;
        public int Cuir
        {
            get { return _cuir; }
            private set { _cuir = value; }
        }

        public Loup() : base()
        {
            this.Cuir = this.D4.Lance();
        }

    }
}
