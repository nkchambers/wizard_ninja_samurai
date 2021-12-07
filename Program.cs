using System;

namespace wizard_ninja_samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Human, Wizard, Ninja & Samurai (TEST)
            Human nick = new Human("Nick");
            Wizard wizard = new Wizard("Gandalf");
            Ninja ninja = new Ninja("Naruto");
            Samurai samurai = new Samurai("Jack");


            //Print objects to console
            Console.WriteLine(nick);
            Console.WriteLine(wizard);
            Console.WriteLine(ninja);
            Console.WriteLine(samurai);


            //Wizard Override Attack Method Test
            int nickHP = wizard.Attack(nick);
            Console.WriteLine(nick);
            Console.WriteLine(wizard);


            //Wizard Heal Method Test
            wizard.Heal(nick);
            Console.WriteLine(nick);


            //Ninja Override Attack Method Test
            int samuraiHP = ninja.Attack(samurai);
            Console.WriteLine(samurai);


            //Ninja Seal Method Test
            int ninjaHP = ninja.Steal(samurai);
            Console.WriteLine(ninja);
            Console.WriteLine(samurai);


            //Samurai Meditate Method Test
            samurai.Meditate();
            Console.WriteLine(samurai);


            //Samurai Override Attack Method
            ninjaHP = samurai.Attack(ninja);
            Console.WriteLine(ninja);
            

        }
    }
}
