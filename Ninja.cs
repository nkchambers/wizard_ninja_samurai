using System;



namespace wizard_ninja_samurai
{
    public class Ninja : Human
    {
        public Ninja(string name, int strength, int intelligence, int health) : base(name)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = 175;
            Health = health;
        }


        public override int Attack(Human target)
        {
            int damage =  Dexterity * 5;
            target.Health -= damage;
            this.Health += damage;
            Console.WriteLine($"{this.Name} attacked {target.Name} for {damage} damage! Wizard increased his own health {damage}!");
            
            return target.Health;
        }
    }

}