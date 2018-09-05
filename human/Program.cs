using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            human.Human NewHuman =  new Human("Chuck");

            human.Human Challenger = new Human("Buddy");

            Challenger.Attack(NewHuman);
            Console.WriteLine($"{NewHuman.name} is down to {NewHuman.health} hp!");

            human.Wizard newWizard = new Wizard("Gandalf");

            newWizard.Attack(Challenger);

            human.Samurai newSamurai = new Samurai("Musashi");

            newSamurai.Attack(Challenger);

            newSamurai.HowMany();

            human.Ninja newNinja = new Ninja("Ryu");

            newNinja.Attack(Challenger);
        }
    }
}
