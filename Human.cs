using System;

namespace wizard_ninja_samurai
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Health;


    //---------------Create public property to get health-------------  
        public int health 
        { 
            get {return Health;}
        }


    //-------------Default Constructor lets you construct empty Human------------
    //Automatically runs unless you add another constructor with params
        public Human() {}


    //---------------Create constructor method based on name to int Human---------------
        public Human(string name) 
        {
            //Property = parameter value
            Name = name;

            //this is implicit: doesn't
            //to be excplicitly written:
            //this.Name = name;
            Strength = 25;
            Intelligence = 25;
            Dexterity = 45;
            Health = 200;
        }


    //----------------------Create Constructor method that accepts 5 variables----------------
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }

    
    //---------------------------Create Attack Method-------------------------------------
        public virtual int Attack(Human target)
        {
            int damage = Strength * 5;
            target.Health -= damage;
            Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
            return target.Health;

        }



        //Public Override to String
        public override string ToString()
        { 
            return @$"
    Name:           {Name}
    Strength:       {Strength}
    Intelligence:   {Intelligence}
    Dexterity:      {Dexterity}
    health:         {health}
            ";
        }
    }
}