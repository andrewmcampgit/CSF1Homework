using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.cs
{
    class Grades2
    {
        static void Main(string[] args)
        {
           
            int score = 1;

            int[] gradeArray = new int[100];

            int gradeCounter = 0;

            int aGrades = 0;
            int bGrades = 0;
            int cGrades = 0;
            int dGrades = 0;
            int fGrades = 0;

            do
            {
                Console.WriteLine("Enter a score: ");

                score = int.Parse(Console.ReadLine());

                if (score > 90)
                {
                    aGrades++;
                }
                if (score > 80)
                {
                    bGrades++;
                }
                if (score > 70)
                {
                    cGrades++;
                }
                if (score > 60)
                {
                    dGrades++;
                }
                if (score < 60)
                {
                    fGrades++;
                }


                gradeCounter++;

            } while (score > 0 && score < 100);

                Console.WriteLine($"The total number of grades is {gradeCounter}");

            Console.WriteLine($"Number of A's: {aGrades}");
            Console.WriteLine($"Number of B's: {bGrades}");
            Console.WriteLine($"Number of C's: {cGrades}");
            Console.WriteLine($"Number of D's: {dGrades}");
            Console.WriteLine($"Number of F's: {fGrades}");
        }
    }
}
