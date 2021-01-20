using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class GameCharacter
    {

        public int x;
        public int y;
        public int health;
        public string name;

        public void ShowStats()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
            Console.WriteLine("Health: " + health);
        }
    }
}
