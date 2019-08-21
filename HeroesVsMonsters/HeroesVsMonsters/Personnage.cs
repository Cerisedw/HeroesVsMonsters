using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    public abstract class Personnage
    {

        public event Action<Personnage> LaMort;

        private int _end;
        public virtual int End
        {
            get { return _end; }
            private set { _end = value; }
        }

        private int _for;
        public virtual int For
        {
            get { return _for; }
            private set { _for = value; }
        }

        private int _pv;
        private int Pv
        {
            get { return _pv; }
            set
            {
                if (value <= 0)
                {
                    if (LaMort != null)
                    {
                        LaMort(this);
                    }
                }
                _pv = value;
            }
        }

        private De _d4;
        public De D4
        {
            get { return _d4; }
            private set { _d4 = value; }
        }

        private De _d6;
        public De D6
        {
            get { return _d6; }
            private set { _d6 = value; }
        }


        public Personnage()
        {
            this.End = De.CalculStat();
            this.For = De.CalculStat();
            this.Pv = this.End + Modificateur(this.End);
            this.D4 = new De(4);
            this.D6 = new De(6);
        }

        private int Modificateur(int i)
        {
            return (i >= 15) ? 2 : ((i >= 10) ? 1 : ((i >= 5) ? 0 : -1));
        }

        public void Frappe(Personnage p2)
        {
            Console.WriteLine($"\n{this.GetType().Name} {this.Pv}pv | {p2.GetType().Name} {p2.Pv}pv");

            int atk = this.D4.Lance();
            atk += Modificateur(this.For);
            p2.Pv -= atk;

            Console.WriteLine($"{this.GetType().Name} attaque {p2.GetType().Name} pour {atk} de dégats. {p2.Pv} pv restants");
        }

        protected void ResetPv()
        {
            this.Pv = this.End + Modificateur(this.End);
        }

    }
}
