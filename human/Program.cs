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

            human.Wizard newWizard = new Wizard("Gandalf", 5, 5, 3, 80);

            newWizard.WizardInfo();

            newWizard.Attack(Challenger);

            human.Samurai newSamurai = new Samurai("Musashi", 5, 3, 5, 100);

            newSamurai.Attack(Challenger);

            human.Ninja newNinja = new Ninja("Ryu", 3, 6, 5, 75);

            newNinja.Attack(Challenger);
        }
    }
}
