using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Generate an rpg bag system
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of items
            List<Item> items = new List<Item>();
            //Add items to the list
            items.Add(new Item("Health Potion", 10, 10));
            items.Add(new Item("Mana Potion", 10, 10));
            items.Add(new Item("Attack Potion", 10, 10));
            items.Add(new Item("Defense Potion", 10, 10));
            items.Add(new Item("Speed Potion", 10, 10));
            items.Add(new Item("Luck Potion", 10, 10));
            items.Add(new Item("Strength Potion", 10, 10));
            items.Add(new Item("Intelligence Potion", 10, 10));
            items.Add(new Item("Dexterity Potion", 10, 10));
            items.Add(new Item("Vitality Potion", 10, 10));
            items.Add(new Item("Magic Potion", 10, 10));
            items.Add(new Item("Fire Potion", 10, 10));
            items.Add(new Item("Ice Potion", 10, 10));
            items.Add(new Item("Lightning Potion", 10, 10));
            items.Add(new Item("Earth Potion", 10, 10));
            items.Add(new Item("Wind Potion", 10, 10));
            items.Add(new Item("Water Potion", 10, 10));
            items.Add(new Item("Light Potion", 10, 10));
            items.Add(new Item("Dark Potion", 10, 10));
            items.Add(new Item("Poison Potion", 10, 10));
            items.Add(new Item("Holy Potion", 10, 10));
            items.Add(new Item("Unholy Potion", 10, 10));
            items.Add(new Item("Cursed Potion", 10, 10));
            items.Add(new Item("Blessed Potion", 10, 10));
            items.Add(new Item("Gold", 10, 10));
            items.Add(new Item("Silver", 10, 10));
            items.Add(new Item("Copper", 10, 10));

