using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(), new Rectangle(), new Curve() };
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int randNum = random.Next(0, 3);
                shapes[randNum].Draw();
            }
            
        }
    }
}
