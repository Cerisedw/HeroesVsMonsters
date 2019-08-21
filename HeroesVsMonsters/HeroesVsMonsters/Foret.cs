using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{

    public class Foret
    {


        private Heros _hero;
        public Heros Hero
        {
            get { return _hero; }
            private set { _hero = value; }
        }

        private Monstres _monstre;
        public Monstres Monstre
        {
            get { return _monstre; }
            private set { _monstre = value; }
        }

        private bool _gameOver;
        public bool GameOver
        {
            get { return _gameOver; }
            private set { _gameOver = value; }
        }

        public Foret(string h)
        {
            this.Hero = (h.ToLower() == "nain") ? (Heros)new Nain() : new Humain();
            this.Monstre = GenererMonstre();
            this.GameOver = false;
            Hero.LaMort += LaMortAction;
        }

        private void LaMortAction(Personnage p)
        {
            if (p is Heros)
            {
                GameOver = true;
            }
            else
            {
                Hero.Depouiller((Monstres)p);
                Hero.Repos();
                this.Monstre = GenererMonstre();
            }
        }

        public void Play()
        {
            while (GameOver == false)
            {
                int x = this.Monstre.GetHashCode();

                Hero.Frappe(Monstre);

                if (x == this.Monstre.GetHashCode())
                {
                    Monstre.Frappe(Hero);
                }

            }
            Console.WriteLine($"\n{this.Hero.GetType().Name} est mort et a obtenu {this.Hero.Or} d'or et {this.Hero.Cuir} de cuir.");
        }

        protected Monstres GenererMonstre()
        {
            De d3 = new De(3);
            int x = d3.Lance();
            Monstres m = (x == 1) ? new Loup() : ((x == 2) ? (Monstres)new Orque() : new Dragonnet());
            m.LaMort += LaMortAction;
            return m;
        }

    }
}
