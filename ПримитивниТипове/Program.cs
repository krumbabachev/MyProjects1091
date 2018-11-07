using System;

namespace Chap2

{
    class Program
    {
        static void Main(string[] args)
        {
            //1------------------------------------------
            sbyte a = 96;
            byte b = 224;
            short c = 112;
            ushort d = 52130;
            uint e = 970700000;
            int f = -1000000;
            long g = 123456789123456789;
            ulong h = 4825932;


            //2------------------------------------------

            double i = 3456.091124875956542151256683467d;
            float j = 12.345f;
            double k = 34.567839023d;
            decimal l = 8923.1234857m;

            Console.WriteLine("{0}", i);
            Console.WriteLine("{0}", j);
            Console.WriteLine("{0}", k);
            Console.WriteLine("{0}", l);

            //3-------------------------------------------

            decimal m = 1.123456789012314m;
            decimal x = 1.231233423412314m;

            m += x;
            Console.WriteLine(m.ToString("#.#######"));

            //4------------------------------------------

            int o = 0x100;

            Console.WriteLine("{0}", o);


            //5---------------------------------------------

            char p = '\u0048';
            Console.WriteLine("{0}", p);

            //6--------------------------------------------

            Console.WriteLine("Are you a male: true/false");
            bool IsMale = bool.Parse(Console.ReadLine());

            if ((IsMale == true))
            {
                Console.WriteLine("You are a male");

            }
            else
            {
                Console.WriteLine("You are not a male");
            }


            //7--------------------------------------------



            string w = "hello";
            string q = "World!";
            object v = w + " " + q;

            Console.WriteLine("{0}", v);

            //8--------------------------------------------


            string str1 = "hello";
            string str2 = "World!";
            object obj = str1 + " " + str2;

            Console.WriteLine("{0}", obj);
            string str3 = obj.ToString();
            Console.WriteLine("{0}", str3);

            //9--------------------------------------------

            string str4 = "The \"use\" of quotations causes difficulties";
            string str5 = "The "+"\u0022" + "\u0022" + " ==";
            Console.WriteLine("{0}", str4);
            Console.WriteLine("{0}", str5);

            //10----------------------------------------

            Console.WriteLine("  0        0 ");
            Console.WriteLine("0   0    0   0");
            Console.WriteLine(" 0   0  0   0");
            Console.WriteLine("  0   00   0");
            Console.WriteLine("   0      0 ");
            Console.WriteLine("    0    0  ");
            Console.WriteLine("     0  0   ");
            Console.WriteLine("      00   ");


            //11---------------------------------------



            //U+00A9
            
            Console.WriteLine("     ©");
            Console.WriteLine("   © ©");
            Console.WriteLine("  ©   ©");
            Console.WriteLine(" ©     ©");
            Console.WriteLine("©©©©©©©©");


            //12----------------------------------------



            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();

            char gender = char.Parse(Console.ReadLine());
            byte age = byte.Parse(Console.ReadLine());
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1}", firstName, secondName);

            //13----------------------------------------------------

            int int1 = 2;
            int int2 = 3;
            int1 = int1 + int2;
            int2 = int1 - int2;
            int1 = int1 - int2;
            Console.WriteLine("int1:{0} int2:{1}", int1, int2);


        }

    }
}

