using System;



namespace wizard_ninja_samurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            //Name = name;
            //Strength = strength;
            //Intelligence = intelligence;
            Dexterity = 175;
            //Health = health;
        }


        public override int Attack(Human target)
        {
            //Generate Random instance where 20% of time  attack adds extra 10 damage
            Random rand = new Random();
            
            int damage = Dexterity * 5;
            
            if(rand.Next(100) <=20)
            {
                damage += 10;
            }
            
            return base.Attack(target, damage);
        }



        public int Steal(Human target)
        {
            int stolenHP = 10;
            target.Health -= stolenHP;
            this.Health += stolenHP;
            Console.WriteLine($"Ninja {this.Name} stole {stolenHP} HP from {target.Name} with NINJA STEALTH SWIPE!");

            return target.Health;
        }
    }
}