using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            float health = 100.0f;
            float healthregen = 20;
            string name = Console.ReadLine();
            bool maxlevelreached = false;
            int maxlevel = 100;
            int level = 1;
            bool ready = true;
            Console.WriteLine(health);
            health = health + healthregen;
            Console.Write(name + " just healed " + healthregen);
        }
    }
}
