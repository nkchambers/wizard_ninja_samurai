using System;


namespace wizard_ninja_samurai
{
    public class Samurai : Human
    {
        public Samurai(string name, int strength, int intelligence, int dexterity) : base(name)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = 200;
        }
    }
}