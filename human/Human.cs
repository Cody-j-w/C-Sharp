using System;

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

        
        public Wizard(string name, int str, int inte, int dex, int hp) : base(name, str, inte, dex, hp)
        {
            this.intelligence = (inte*3);
        }

        public void WizardInfo()
        {
            Console.WriteLine($"The Wizard's intelligence is {intelligence}");
            Console.WriteLine($"The Wizard's health is {health}");
            Console.WriteLine($"The Wizard's name is {name}");
        }

        public new void Attack(Human opponent)
        {
            opponent.health = opponent.health - (2*this.intelligence);
            Console.WriteLine($"{this.name} burns {opponent.name} for "+2*this.intelligence+" damage!");
            for(int i = 0; i<this.intelligence/3; i++)
            {
                opponent.health = opponent.health - this.intelligence;
                Console.WriteLine($"{opponent.name} is burning!");
                Console.WriteLine($"{opponent.name} has {opponent.health} hp!");
                
            }
            if(opponent.health <=0)
            {
                Console.WriteLine($"{opponent.name} burns to ash!");
            }
        }
    }

    public class Samurai : Human
    {
        public Samurai(string name, int str, int inte, int dex, int hp) : base(name, str, inte, dex, hp)
        {
            this.strength = (str*3);
            this.health = (hp*2);
        }

        public new void Attack(Human opponent)
        {
            opponent.health = opponent.health - (3*this.strength);
            Console.WriteLine($"{this.name} slices {opponent.name} for "+3*this.strength+" damage!");
            
        }
    }

    public class Ninja : Human
    {
        public Ninja(string name, int str, int inte, int dex, int hp) : base(name, str, inte, dex, hp)
        {
            this.dexterity = (dex*5);
        }

        public new void Attack(Human opponent)
        {
            opponent.health = opponent.health - (this.dexterity/5);
            Console.WriteLine($"{this.name} slices {opponent.name} for "+this.dexterity/3+" damage!");

            for(int i = 0; i<this.dexterity; i++)
            {
                opponent.health = opponent.health - dexterity/3;
                Console.WriteLine($"{opponent.name}'s wounds continue to bleed! They take {this.dexterity/3} damage!");
            }
            if(opponent.health <=0){
                Console.WriteLine($"{opponent.name} bleeds out!");
            }
        }
    }
}