﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segment1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("SupportTraining");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Support");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Training");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
