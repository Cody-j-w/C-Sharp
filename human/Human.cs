using System;
using System.Threading;

namespace human
{
    public class Human
    {
        public int strength;
        public int intelligence;
        public int dexterity;
        public int health;
        public string name;

        public void Attack(Human opponent)
        {
            opponent.health = opponent.health - (5*this.strength);
            Console.WriteLine($"{this.name} attacks {opponent.name} for "+5*this.strength+" damage!");
        }

        public Human(string name)
        {
            this.name = name;
            strength = 3;
            dexterity = 3;
            intelligence = 3;
            health = 100;
        }

        public Human(string name, int str, int inte, int dex, int hp)
        {
            this.name = name;
            this.strength = str;
            this.dexterity = dex;
            this.intelligence = inte;
            this.health = hp;
        }
    }

    public class Wizard : Human{

        
        public Wizard(string name) : base(name)
        {
            this.intelligence = 25;
            this.health = 50;
        }

        public void Heal()
        {
            this.health = this.health + (10*this.intelligence);
            Console.WriteLine($"{this.name} heals for {10*this.intelligence}!");
        }

        public void Fireball(Human opponent)
        {
            Random rand = new Random();

            int burn = rand.Next(20,51);
            opponent.health = opponent.health - (burn);
            Console.WriteLine($"{this.name} burns {opponent.name} for {burn} damage!");
            if(opponent.health <=0)
            {
                Console.WriteLine($"{opponent.name} burns to ash!");
            }
        }
    }

    public class Samurai : Human
    {

        static int legion = 0;
        public Samurai(string name) : base(name)
        {
            Interlocked.Increment(ref legion);
            this.health = 200;
        }

        public new void Attack(Human opponent)
        {
            base.Attack(opponent);
            
        }

        public void DeathBlow(Human opponent)
        {
            if(opponent.health < 50)
            {
                opponent.health = 0;
                Console.WriteLine($"{this.name} demolishes {opponent.name}!");
            }
        }

        public void Meditate()
        {
            this.health = 200;

            Console.WriteLine($"{this.name} meditates, regaining their energy!");
        }

        public void HowMany()
        {
            Console.WriteLine($"There are {legion} Samurai active!");
        }
    }

    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            this.dexterity = 175;
        }

        public void Steal(Human opponent)
        {
            base.Attack(opponent);

            this.health = this.health + 10;

            Console.WriteLine($"{this.name} steals a knick-knack from {opponent.name}!");
        }

        public void GetAway()
        {
            this.health = this.health - 15;
            Console.WriteLine($"{this.name} tumbles away from the fight!");
        }
    }
}