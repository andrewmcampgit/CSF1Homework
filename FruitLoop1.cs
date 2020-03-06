using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.cs
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            string[] fruitArray = { "apple", "kiwi", "bananna", "orange", "grapes" };

            int i = 0;
            while (i <= fruitArray.Length)
            {
                Console.WriteLine(fruitArray[i]);
                i++;
            }

        }

    }
}
