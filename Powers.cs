using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.cs
{
    class Powers
    {
        static void Main(string[] args)
        {
            //Practice this!!!
            long powerCounter = 1;
            for (int i = 1; i < 50; i++)
            {
                powerCounter *= 2;
                Console.WriteLine(powerCounter);

            }
        }
    }
}
