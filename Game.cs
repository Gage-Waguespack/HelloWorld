using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            Console.WriteLine("Greetings, who are you?!");
            //This lets you set a custom name
            string name = Console.ReadLine();
            Console.WriteLine("Well hello " + name + ", what is your profession?");
            string role = Console.ReadLine();
            Console.WriteLine("So " + name + " You're a " + role + ", very interesting"); 
            //This stores health
            float health = 80.0f;
            //This value is used to heal the player
            float healthregen = 20;
            //This tells the player if they have reached the max level
            bool maxlevelreached = false;
            int maxlevel = 100;
            int level = 1;
            bool ready = true;
            Console.WriteLine("Come here " + name + ", you seem to be hurt. What is your health?");
            //Tells the viewer the health variable
            Console.WriteLine(health);
            //This will heal the player to 100
            Console.WriteLine("I see. Very well then, take this health potion and heal!");
            health = health + healthregen;
            Console.Write(name + " just healed " + healthregen);
            Console.WriteLine("  ");
            //This will tell the player their stats
            Console.WriteLine("So from what I have gathered, this is you.");
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Player Role: " + role);
        }
    }
}
