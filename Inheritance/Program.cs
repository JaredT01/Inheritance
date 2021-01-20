using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Inheritance");

            Player player = new Player();
            Enemy enemy = new Enemy();

            

            player.x = 10;
            player.y = 20;
            player.health = 95;
            player.name = "Roger Wilco";
            player.score = 100;

            enemy.name = "Big Boss";
            enemy.x = 90;
            enemy.y = 80;
            enemy.health = 1200;

            player.ShowStats();
            enemy.ShowStats();

            Console.ReadKey(true);


        }
    }
}
