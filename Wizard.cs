using System;


namespace wizard_ninja_samurai
{
    public class Wizard : Human
    {
        public Wizard(string name, int strength, int dexterity) : base(name)
        {
            Name = name;
            Strength = strength;
            Intelligence = 25;
            Dexterity = dexterity;
            Health = 50;
        }



        public override int Attack(Human target)
        {
            int damage =  Intelligence * 5;
            target.Health -= damage;
            this.Health += damage;
            Console.WriteLine($"{this.Name} attacked {target.Name} for {damage} damage! Wizard increased his own health {damage}!");
            
            return target.Health;
        }
    }
}