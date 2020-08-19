using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            //This stores health
            float health = 80.0f;
            //This value is used to heal the player
            float healthregen = 20;
            //This tells the player if they have reached the max level
            bool maxlevelreached = false;
            int damage = 20;
            int level = 1;
            bool ready = true;
            string role = "scrub";
            Console.WriteLine("Greetings, who are you?!");
            //This lets you set a custom name
            string name = Console.ReadLine();
            Console.WriteLine("Well hello " + name + ", please select your profession?");
            Console.WriteLine("Press 1 for Beefcake role");
            Console.WriteLine("Press 2 for Glass Cannon role");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if(input == '1')
            {
                health = 180;
                role = "Beefcake";
            }
            else if (input == '2')
            {
                health = 30;
                damage = 60;
                role = "Glass Cannon";
            }
            else
            {
                Console.WriteLine("No class selected. You're a scrub, goodluck!");
            }
            Console.WriteLine("So " + name + " You're a " + role + ", very interesting"); 
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
            Console.WriteLine("\nPlayer Name: " + name);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Player Damage: " + damage);
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Player Role: " + role);
            Console.WriteLine("Press any key to continue");
            input = Console.ReadKey().KeyChar;

            Console.Clear();

            //More Dialogue
            Console.WriteLine("wait, I have one more thing!");
            Console.WriteLine("Here, pick a weapon!");
            Console.WriteLine("Press any key for the options");
            Console.ReadKey();
            Console.WriteLine("Now which do you choose?");
                    Console.WriteLine("Press 1 for a Sheathed Sword");
                    Console.WriteLine("Press 2 for a Nurf Gun");
                    Console.WriteLine("Press 3 for Hulk Fists");
                    Console.WriteLine("Press 4 for a Rubber Chicken");
              input = Console.ReadKey().KeyChar;
            //Added Weapons that will drastically change how the game will be played
            if(input == '1')
            {
                health -= health * .5f;
                Console.WriteLine("\nSo this seems to be the legendary sword Excalibar!?");
                Console.WriteLine("So it appears that you can't hold the sword so it will be sold for a great price and you walk away with nothing..");
            }
            else if (input == '2')
            {
                damage = 250;
                Console.WriteLine("\nWell you know what they say...");
                Console.WriteLine("IT'S NURF OR NOTHIN'");
                Console.WriteLine("Sadly this isn't a Nurf Gun, it was just painted to look like one...");
                Console.WriteLine("However it is a real one and it seems to be powered by some alien artifact!!");

            }
            else if (input == '3')
            {
                damage -= 15;
                Console.WriteLine("\nWell it seems that you chose to have fists like the legendary HULK!");
                Console.WriteLine("However this isn't the Marvel Universe and you just picked up a lightweight foam toy..");
            }
            else if (input == '4')
            {
                damage += 500;
                health += 200;
                Console.WriteLine("\nWell I thought you were just an idiot who was taking this as a joke, but it seems that you have incredible eyes for weaponry");
                Console.WriteLine("It seems that you chose not just any rubber chicken, but a rubber chicken enchanted by the gods themselves!");
                Console.WriteLine("You, my friend, have just made an incredible discovery and these powers shall be transfered to you!");
            }
            else
            {
                Console.WriteLine("\nSo, you prefer fisticuffs eh? Well so be it..");
            }
            Console.WriteLine("Do you wish to continue?");

            Console.ReadKey();

            Console.Clear(); 

        }
    }
}
