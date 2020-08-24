using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            bool training = false;
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
                void PrintStats(string name, float playerheatlh, int damage, int level, string role)
                {
                    Console.WriteLine("\nPlayer Name: " + name);
                    Console.WriteLine("Player Health: " + health);
                    Console.WriteLine("Player Damage: " + damage);
                    Console.WriteLine("Player Level: " + level);
                    Console.WriteLine("Player Role: " + role);
                    Console.WriteLine("Weapon: " + weapon);
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                Console.WriteLine("\nOld Man: Greetings, who are you?!");
                //This lets you set a custom name
                string name = Console.ReadLine();
                Console.WriteLine("Old Man: Well hello " + name + ", please select your profession?");
                Console.WriteLine("Press 1 for Beefcake role");
                Console.WriteLine("Press 2 for Glass Cannon role");
                char input = ' ';
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
                Console.WriteLine("\nOld Man: So " + name + " You're a " + role + ", very interesting");
                Console.WriteLine("Old Man: Come here " + name + ", you seem to be hurt. What is your health?");
                //Tells the viewer the health variable
                Console.WriteLine(health);
                //This will heal the player to 100
                Console.WriteLine("Old Man: I see. Very well then, take this health potion and heal!");
                health = health + healthregen;
                Console.Write(name + " just healed " + healthregen);
                Console.WriteLine("  ");
                //This will tell the player their stats
                Console.WriteLine("These are your stats as of now!");
                PrintStats(name, health, damage, level, role);

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
                PrintStats(name, health, damage, level, role);

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
                //Added a giant encounter that is only possible if you are a beefcake or have the rubber chicken..
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
                        PrintStats(name, health, damage, level, role);
                    }
                }
                else if (input == '2')
                {
                    Console.WriteLine("You just don't think it's worth it, they'll be fine..");
                }
                Console.WriteLine("\nDo you wish to continue?");

                Console.ReadKey();

                Console.Clear();

                //for(int i = 0; i< 5; i++
                //console.writeline("You have " + (5 - i) + " tries remaining");
                //This limits choices, could be useful in the future! ^
                // guess = console.readline();
                //if(guess == "yes")
                //This would be how to make the answer, the answer being yes in this example!^

                Console.WriteLine("You continue your adventure with a smile!");
                Console.WriteLine("You begin walking down a path until you reach a sign.");
                Console.WriteLine("The sign is right infront of a split in the road");
                Console.WriteLine("The road leading to the left is labeled to be a dead end.");
                Console.WriteLine("The road leading right says to lead to the town.");
                Console.WriteLine("You decide to take a right after some thinking and arrive in the town of Claymore");
                Console.WriteLine("Press anything to continue");
                Console.ReadKey();
                Console.WriteLine("Once you arrive people seem to stare at you and you feel out of place.");
                Console.WriteLine("After walking around alittle, you get approached by a very intimidating man");
                Console.WriteLine("Man: Well what do we have here? You're new to town huh??");
                Console.WriteLine("Man: You know what? Don't say a word, I can tell you're new because you don't know who I am...");
                Console.WriteLine("Trainer: I AM the owner of the training grounds :D");
                if (health <= 200 && damage <= 150 && level <= 10)
                {
                    Console.WriteLine("Trainer: Come, you need to train before you are respected around here!");
                    Console.WriteLine("You train until you can barely stand");
                    level += 9;
                    health += 200;
                    damage += 150;
                    Console.WriteLine("Trainer: You seemed to have trained until you gained the exact stats! Very Well!!");
                    Console.WriteLine("You raised your health by 200, your damage by 150, and you are now level 10!!");
                    Console.WriteLine("These are your new stats!");
                    PrintStats(name, health, damage, level, role);
                }
                else if (health >= 200 && damage >= 150 && level >= 10)
                {
                    Console.WriteLine("Trainer: You seem strong! However, you have much potential, would you like to train?");
                    Console.WriteLine("Press 1 for yes");
                    Console.WriteLine("Press 2 for no");
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        training = true;
                        while (training == true)
                        {
                            level += 1;
                            damage += 20;
                            health += 50;
                            Console.WriteLine("You train to your hearts content!");
                            Console.WriteLine("Your stats have changed!");
                            Console.WriteLine("These are your new stats!");
                            Console.WriteLine("\nPlayer Name: " + name);
                            Console.WriteLine("Player Health: " + health);
                            Console.WriteLine("Player Damage: " + damage);
                            Console.WriteLine("Player Level: " + level);
                            Console.WriteLine("Player Role: " + role);
                            Console.WriteLine("Weapon: " + weapon);
                            Console.WriteLine("Press any key to continue!");
                            Console.ReadKey();

                            Console.Clear();

                            Console.WriteLine("Would you like train more?");
                            Console.WriteLine("Press 1 to Train more!");
                            Console.WriteLine("Press 2 to continue!");
                            input = Console.ReadKey().KeyChar;
                            if (input == '1')
                            {
                                Console.WriteLine("\nYou Train again!");
                            }
                            else if (input == '2')
                            {
                                training = false;
                                Console.WriteLine("\nWow, you've trained a lot! I think you've outdone yourself. Maybe now people will seek you out!");
                                break;
                            }
                        }
                    }
                    else if (input == '2')
                    {
                        Console.WriteLine("Trainer: Very well then.. I'm gonna be moving up a few towns so you won't be able to train until you find me again!");
                    }
                }
                Console.WriteLine("Now that you're done there you go to explore more of the town");
                Console.WriteLine("After some walking you see two guys cornering a girl and they seem to be trying to steal from her!!");
                Console.WriteLine("Press 1 to help her");
                Console.WriteLine("Press 2 to ignore it and walk away..");
                input = Console.ReadKey().KeyChar;
                if(input == '1')
                {
                    Console.WriteLine("YOU JUMP IN AND HELP THE GIRL STARTING A FIGHT WITH TWO THUGS!!"); 
                }
            }
        }
    }
}
