using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.cs
{
    class FruitLoops2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Fruit Loops 2\n");

            string[] fruitArray = { "apple", "kiwi", "bananna", "orange", "grapes" };

            for (int i = 0; i < fruitArray.Length; i++)
            {
                Console.WriteLine(fruitArray[i]);
            }
        }
    }
}
