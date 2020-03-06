using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.cs
{
    class Grades
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When ready hit enter and submit 5 scores: ");
            Console.ReadLine();
            int[] gradeArray = new int[] { };

            int[] aScoreArray = { };
            int[] bScoreArray = { };
            int[] cScoreArray = { };
            int[] dScoreArray = { };
            int[] fScoreArray = { };

            int[][] allScoreArray = { aScoreArray, bScoreArray, cScoreArray, dScoreArray, fScoreArray };

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Enter a score here 0-100: ");
                int score = int.Parse(Console.ReadLine());

                
                if(score <= 100)
                {
                    score = aScoreArray[i];
                }
                else if (gradeArray[i] <= 90)
                {
                    bScoreArray[0] += gradeArray[i];
                }
                else if (gradeArray[i] <= 80)
                {
                    cScoreArray[0] += gradeArray[i];
                }
                else if (gradeArray[i] <= 70)
                {
                    dScoreArray[0] += gradeArray[i];
                }
                else if (gradeArray[i] <= 60)
                {
                    fScoreArray[0] += gradeArray[i];
                }
                else if (gradeArray[i] < 0)
                {
                    break;
                }
                else
                {
                    gradeArray[i] = int.Parse(Console.ReadLine());
                }
                
            }

            Console.WriteLine($"Total number of grades is {gradeArray.Length}.");

            char[] letterArray = { 'A', 'B', 'C', 'D', 'F' };

           

            for (int i = 0; i < letterArray.Length; i++)
            {
                Console.WriteLine($"Number of {letterArray[i]} is: {allScoreArray[i].Length}" );

            }
            

            





        }
    }
}
