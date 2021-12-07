using System;


namespace wizard_ninja_samurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            //Name = name;
            //Strength = strength;
            Intelligence = 25;
            //Dexterity = dexterity;
            Health = 50;
        }


        public override int Attack(Human target)
        {
            int damage =  Intelligence * 5;
            target.Health -= damage;
            this.Health += damage;
            Console.WriteLine($"Wizard {this.Name} attacked {target.Name} for {damage} damage! Wizard {this.Name} increased his own health {damage}!");
            
            return target.Health;
        }


        public void Heal(Human target)
        {
            int recoveredHP = Intelligence * 10;
            target.Health += recoveredHP;
            Console.WriteLine($"Wizard {this.Name} healed {target.Name} by {recoveredHP}!");
        }

    }
}