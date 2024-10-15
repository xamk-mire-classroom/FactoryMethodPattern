using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    // Base Character Class
    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }

        public abstract void UseAbility();
    }

    // Warrior Class
    public class Warrior : Character
    {
        public Warrior(string name)
        {
            Name = name;
            Health = 150;
            Mana = 30;
            Strength = 100;
            Agility = 20;
        }

        public override void UseAbility()
        {
            Console.WriteLine($"{Name} uses a powerful melee attack!");
        }
    }

    // Mage Class
    public class Mage : Character
    {
        public Mage(string name)
        {
            Name = name;
            Health = 80;
            Mana = 120;
            Strength = 30;
            Agility = 40;
        }

        public override void UseAbility()
        {
            Console.WriteLine($"{Name} casts a powerful fireball!");
        }
    }

    // Archer Class
    public class Archer : Character
    {
        public Archer(string name)
        {
            Name = name;
            Health = 100;
            Mana = 50;
            Strength = 60;
            Agility = 90;
        }

        public override void UseAbility()
        {
            Console.WriteLine($"{Name} shoots an arrow from a distance!");
        }
    }

    // Character Factory Class
    public static class CharacterFactory
    {
        public static Character CreateCharacter(string characterType, string name)
        {
            switch (characterType.ToLower())
            {
                case "warrior":
                    return new Warrior(name);
                case "mage":
                    return new Mage(name);
                case "archer":
                    return new Archer(name);
                default:
                    throw new ArgumentException("Invalid character type.");
            }
        }
    }

}

