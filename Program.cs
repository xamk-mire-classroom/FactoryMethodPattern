using ConsoleApp1;
using System;



// Sample Usage
public class Program
{
    public static void Main(string[] args)
    {
        // Create characters using the factory
        Character warrior = CharacterFactory.CreateCharacter("Warrior", "Thorin");
        Character mage = CharacterFactory.CreateCharacter("Mage", "Merlin");
        Character archer = CharacterFactory.CreateCharacter("Archer", "Legolas");

        // Display character details and use abilities
        Console.WriteLine($"{warrior.Name} - Health: {warrior.Health}, Mana: {warrior.Mana}, Strength: {warrior.Strength}, Agility: {warrior.Agility}");
        warrior.UseAbility();

        Console.WriteLine($"{mage.Name} - Health: {mage.Health}, Mana: {mage.Mana}, Strength: {mage.Strength}, Agility: {mage.Agility}");
        mage.UseAbility();

        Console.WriteLine($"{archer.Name} - Health: {archer.Health}, Mana: {archer.Mana}, Strength: {archer.Strength}, Agility: {archer.Agility}");
        archer.UseAbility();
    }
}
