using System;

namespace wizard_ninja_samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Human, Wizard, Ninja & Samurai (TEST)
            Human nick = new Human("Nick");
            Wizard wizard = new Wizard("Gandalf", 40, 25);
            Ninja ninja = new Ninja("Naruto", 25, 10, 20);
            Samurai samurai = new Samurai("Jack", 20, 15, 25);


            //Print objects to console
            Console.WriteLine(nick);
            Console.WriteLine(wizard);
            Console.WriteLine(ninja);
            Console.WriteLine(samurai);


            /*//Wizard Overrride Attack Method Test
            int nickHP = wizard.Attack(nick);
            Console.WriteLine(nick);
            Console.WriteLine(wizard);*/


        }
    }
}
