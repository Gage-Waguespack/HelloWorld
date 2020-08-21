using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            bool gameover = false;
            while (gameover == false) 
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
                string weapon = "Fisticuffs";
                int giantdmg = 150;
                int gianthlth = 200;
                int currentenemyhlth = 0;
                int currentenemydmg = 0;
                Console.WriteLine("Old Man: Greetings, who are you?!");
                //This lets you set a custom name
                string name = Console.ReadLine();
                Console.WriteLine("Old Man: Well hello " + name + ", please select your profession?");
                Console.WriteLine("Press 1 for Beefcake role");
                Console.WriteLine("Press 2 for Glass Cannon role");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                while (input != '1' && input != '2')
                {
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
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
                        Console.WriteLine("\nNo class selected. Are you dumb or something?!");
                    }
                }
                Console.WriteLine("Old Man: So " + name + " You're a " + role + ", very interesting");
                Console.WriteLine("Old Man: Come here " + name + ", you seem to be hurt. What is your health?");
                //Tells the viewer the health variable
                Console.WriteLine(health);
                //This will heal the player to 100
                Console.WriteLine("Old Man: I see. Very well then, take this health potion and heal!");
                health = health + healthregen;
                Console.Write(name + " just healed " + healthregen);
                Console.WriteLine("  ");
                //This will tell the player their stats
                Console.WriteLine("Old Man: So from what I have gathered, this is you.");
                Console.WriteLine("\nPlayer Name: " + name);
                Console.WriteLine("Player Health: " + health);
                Console.WriteLine("Player Damage: " + damage);
                Console.WriteLine("Player Level: " + level);
                Console.WriteLine("Player Role: " + role);
                Console.WriteLine("Press any key to continue");
                input = Console.ReadKey().KeyChar;

                Console.Clear();

                //More Dialogue
                Console.WriteLine("Old Man: wait, I have one more thing!");
                Console.WriteLine("Old Man: Here, pick a weapon!");
                Console.WriteLine("Press any key for the options");
                Console.ReadKey();
                Console.WriteLine("Old Man: Now which do you choose?");
                Console.WriteLine("Press 1 for a Sheathed Sword");
                Console.WriteLine("Press 2 for a Nurf Gun");
                Console.WriteLine("Press 3 for Hulk Fists");
                Console.WriteLine("Press 4 for a Rubber Chicken");
                Console.WriteLine("If you prefer no weapon, press something else");
                input = Console.ReadKey().KeyChar;
                //Added Weapons that will drastically change how the game will be played
                if (input == '1')
                {
                    health -= health * .5f;
                    Console.WriteLine("\nOld Man: So this seems to be the legendary sword Excalibar!?");
                    Console.WriteLine("Old Man: So it appears that you can't hold the sword so it will be sold for a great price and you walk away with nothing..");
                    weapon = "Fisticuffs";
                }
                else if (input == '2')
                {
                    damage = 250;
                    Console.WriteLine("\nOld Man: Well you know what they say...");
                    Console.WriteLine("Old Man: IT'S NURF OR NOTHIN'");
                    Console.WriteLine("Old Man: Sadly this isn't a Nurf Gun, it was just painted to look like one...");
                    Console.WriteLine("Old Man: However it is a real one and it seems to be powered by some alien artifact!!");
                    weapon = "DOOMSDAY RIFLE";

                }
                else if (input == '3')
                {
                    damage -= 15;
                    Console.WriteLine("\nOld Man: Well it seems that you chose to have fists like the legendary HULK!");
                    Console.WriteLine("Old Man: However this isn't the Marvel Universe and you just picked up a lightweight foam toy..");
                    weapon = "Hulk hands?";
                }
                else if (input == '4')
                {
                    damage += 500;
                    health += 200;
                    Console.WriteLine("\nOld Man: Well I thought you were just an idiot who was taking this as a joke, but it seems that you have incredible eyes for weaponry");
                    Console.WriteLine("Old Man: It seems that you chose not just any rubber chicken, but a rubber chicken enchanted by the gods themselves!");
                    Console.WriteLine("Old Man: You, my friend, have just made an incredible discovery and these powers shall be transfered to you!");
                    weapon = "The Will of the Gods! and a rubber chicken?!";
                }
                else
                {
                    Console.WriteLine("\nOld Man: So, you prefer fisticuffs eh? Well so be it..");
                }
                Console.WriteLine("These are your new stats!");
                Console.WriteLine("\nPlayer Name: " + name);
                Console.WriteLine("Player Health: " + health);
                Console.WriteLine("Player Damage: " + damage);
                Console.WriteLine("Player Level: " + level);
                Console.WriteLine("Player Role: " + role);
                Console.WriteLine("Weapon: " + weapon);
                Console.WriteLine("\nDo you wish to continue?");

                Console.ReadKey();

                Console.Clear();

                Console.WriteLine("So you head off, until stopping by a cave where you hear some screaming, you feel a cold air brush against your neck while you pass..");
                Console.WriteLine("Do you wish to enter this cave?!");
                Console.WriteLine("Press 1 for yes");
                Console.WriteLine("Press 2 for no");
                input = Console.ReadKey().KeyChar;
                // while(gameOver = false) { if(playerHealth <=0) { gameOver = true; continue; 
                // This ends program if hero dies
                // while(gameOver = false) { if(playerHealth <=0) { console.writeline("you died, play again?") console.writeline("press 1 for yes") console.writeline("press 2 for no")
                // if(input == '1') { continue; } else if(input == '2') { break }
                // This asks if the player wants to quit or not!
                if (input == '1')
                {
                    currentenemydmg = giantdmg;
                    currentenemyhlth = gianthlth;
                    Console.WriteLine("You valiently run into the cave to save the one who is screaming for their life and encounter a giant!!");
                    Console.WriteLine("You and the giant lock eyes, and in that moment you can see eachothers capabilities..");
                    Console.WriteLine("The giant has a staggering 200 health and 150 damage!");
                    Console.WriteLine("Right behind the giant you see a girl on a mountain of dead bodies, and she makes one last cry for help before being slapped against the wall!");
                    Console.WriteLine("RIGHT AFTER THAT THE GIANT SLAMS ITS FISTS DEALING 150 DAMAGE TO YOU EXCLUSIVELY!");
                    health -= currentenemydmg;
                    Console.WriteLine("You took 150 point of damage!");

                    if (health <= 0)
                    {
                        Console.WriteLine("You died, would you like to play again?");
                        Console.WriteLine("press 1 to play again");
                        Console.WriteLine("press 2 to quit");
                        if (input == '1')
                        {
                            continue;
                        }
                        else if (input == '2')
                        {
                            break;
                        }
                    }
                    else if (health >= 0)
                    {
                        Console.WriteLine("\nYou seemed to have survived!");
                        Console.WriteLine("Now is your time to strike!!");
                        Console.WriteLine(currentenemyhlth + " - " + damage);
                        currentenemyhlth -= damage;
                        Console.WriteLine(currentenemyhlth);
                        Console.WriteLine("You landed a clean hit on the Giant!");
                    }
                    while (health >= 0 && currentenemyhlth >= 0) 
                    {
                        Console.WriteLine(currentenemyhlth + " - " + damage);
                        currentenemyhlth -= damage;
                        Console.WriteLine(currentenemyhlth);
                    }
                    if (currentenemyhlth <= 0)
                    {
                        Console.WriteLine("You did it! you slayed the Giant! Now you must check on the girl!!");
                        Console.WriteLine("Girl: So you did it, you seem to be very strong.. now there is something you must know.. ");
                        Console.WriteLine("Mysterious Angel: I am a fallen angel, and I will perish, however, take this blessing!");
                        Console.WriteLine("You feel like a new you! and you feel new blood coursing through your veins and grow stronger!");
                        role = "Gaurdian Angel";
                        level += 10;
                        health += 1150;
                        damage += damage *= 2;
                        Console.WriteLine("These are your new stats!");
                        Console.WriteLine("\nPlayer Name: " + name);
                        Console.WriteLine("Player Health: " + health);
                        Console.WriteLine("Player Damage: " + damage);
                        Console.WriteLine("Player Level: " + level);
                        Console.WriteLine("Player Role: " + role);
                        Console.WriteLine("Weapon: " + weapon);
                    }
                        Console.WriteLine("\nDo you wish to continue?");

                        Console.ReadKey();

                        Console.Clear();

                    Console.WriteLine("You continue your adventure with a smile!");
                    
                }
            }
        }
    }
}
