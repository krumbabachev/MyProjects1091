﻿using System;

namespace Chap1_task10

{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)

            {

                if (i % 2 == 0)

                {

                    Console.Write("{0,4} ", i + 2);

                }

                else

                {

                    Console.Write("{0,4} ", -(i + 2));

                }

            }

            Console.WriteLine();



            //------------------------------------------------------

            //task9
            Console.WriteLine(Math.Sqrt(12345));
        }
    }
}