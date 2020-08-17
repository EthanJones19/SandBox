using System;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            float health = 100.0f;
            float healthRegen = 20;
            string name = Console.ReadLine();
            bool maxleverlReached = false;
            int maxlevel = 100;
            int level = 1;
            bool ready = true;
            Console.WriteLine(health);
            health = health + healthRegen;
            Console.Write(name + " gained " + healthRegen + "Hp");
            

        }
    }
}
