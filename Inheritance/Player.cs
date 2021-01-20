using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Player : GameCharacter
    {
        
        public int score;
        protected int Protect = 5;

        public new void ShowStats()
        {
            base.ShowStats();
            Console.WriteLine("Score: " + score);

        }
    }
}
