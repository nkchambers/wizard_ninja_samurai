using System;


namespace wizard_ninja_samurai
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            //Name = name;
            //Strength = strength;
            //Intelligence = intelligence;
            //Dexterity = dexterity;
            Health = 200;
        }


        public override int Attack(Human target)
        {
            int currentHealth = base.Attack(target);

            if(currentHealth < 50)
            {
                target.Health = 0;
                Console.WriteLine($"Samurai {this.Name} KO'd {target.Name} with SILENT DEATH SWORD!");
            }

            return currentHealth;
        }


        public void Meditate()
        {
            Health = 200;
            Console.WriteLine($"Samurai {this.Name}'s meditation session reset his HP to 200!");
        }
    }
}