using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.cs
{
    class FruitLoops3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loops 3\n");

            string[] fruitArray = { "apple", "kiwi", "bananna", "orange", "grapes" };

            int periodCounter = 0;

            for (int i = 0; i < fruitArray.Length; i++)
            {


                Console.WriteLine($"{fruitArray[i]}");

                if (i == 0)
                {

                    Console.WriteLine('.');
                }
                else if(i == 1)
                {
                    Console.WriteLine("..");
                }
                else if (i == 2)
                {
                    Console.WriteLine("...");
                }
                else if (i == 3)
                {
                    Console.WriteLine("....");
                }
                else if (i == 4)
                {
                    Console.WriteLine(".....");
                }


               
            }

        }
    }
}
