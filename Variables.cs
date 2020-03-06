using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.cs
{
    class Variables
    {
        static void Main(string[] args)
        {
            int nbr = 1;
            char character = 'c';
            string stringy = "yo yo";
            double dubski = 4.5d;
            float floater = 4.23f;
            byte biter = 3;

            int[] nbrArray = { 4, 5, 6, 2, 3 };
            for (int i = 0; i < nbrArray.Length; i++)
            {
                Console.WriteLine(nbrArray[i]);
            }

            Console.WriteLine();

            char[] charArray = { 'w', 'e', 'r', 't', 'y' };
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }
            string[] strArray = { "yo", "mom", "dad", "computer", "phone" };

            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }

            Console.WriteLine();

            double[] doubleArray = { 4.5d, 3.2d, 6.78d, 3.12d };

            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.WriteLine(doubleArray[i]);
            }

            Console.WriteLine();

            float[] floatArray = { 5.34f, 23.9f, 23f, 8f };

            for (int i = 0; i < floatArray.Length; i++)
            {
                Console.WriteLine(floatArray[i]);
            }

            Console.WriteLine();

            byte[] byteArray = { 3, 5, 1, 7, 3, 2 };

            for (int i = 0; i < byteArray.Length; i++)
            {
                Console.WriteLine(byteArray[i]);
            }


            int m = 0;
            while (m <= 100)
            {
                
                    if (m % 2 == 0)
                    {
                        Console.WriteLine(m);
                    }
                m += 2;
                
            }

            int n = 0;
            do
            {
               if(n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
                n += 2;

            } while (n <= 100);

            for (int i = 0; i <= 100; i++)
            {
                if(i % 2 ==0)
                {
                    Console.WriteLine(i);
                }
                m += 2;
            }


        }
    }
}
