using System;

namespace Възраст
{
    class Program
    {
        static void Main(string[] args)
        {
            






         string ageString = Console.ReadLine();
            int ageNum = int.Parse(ageString);

            DateTime ageNum10 = new DateTime(ageNum, 1, 1);
            ageNum10 = ageNum10.AddYears(10);
            Console.WriteLine(ageNum10.Year);

        }
    }
}