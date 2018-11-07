using System;

namespace Chap3

{
    class Program
    {
        static void Main(string[] args)
        {

            //1.-------------------------

            int a = 2;
            bool b = a % 2 == 0 ? true : false;
            Console.WriteLine("is {0} even? {1}", a, b);

            //2.-------------------------

            int c = 35;
            bool d = c % 5 == 0 ? true : false;
            bool e = c % 7 == 0 ? true : false;
            Console.WriteLine("Can c be divided by d{0}" + "Can c be divided by e{1}", d, e);

            //3.------------------------

       
            int number = 100000;
            bool isSeven = (number / 100) % 10 == 7 ? true : false;
            Console.WriteLine("{0} is 7 {1}", number, isSeven);

            //4.------------------------

            byte f = 44;
            byte g = 8;
            Console.WriteLine(f & g);

            //5.-----------------------

            double h = 10;
            double i = 5;
            double j = 7;

            double trapPer = ((h + i) / 2 * j);
            Console.WriteLine(trapPer);

            //6.------------------------

            int k = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            double perimeter = ((k * 2) + (l * 2));
            double S = ((k + l) * m);

            Console.WriteLine("P={0}, S = {1}", perimeter, S);

            //7.------------------------


            int weightEarth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the weight of a man on Earth: ");
            Console.WriteLine("On the Moon he will weight: {0}", weightEarth * 0.17);

            //8.-------------------------


            Console.Write("X = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y = ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool inside = (x * x + y * y <= 25) ? true : false;

            Console.WriteLine("Is the point O({0},{1}), inside of K((0,0),5)? : {2}", x, y, inside);


            //9.--------------------------

                     bool insideCircle = (x * x + y * y <= 25) ? true : false;
            bool outsideRectangle = (x < -1 && x > 5 && y < 1 && y > 5) ? true : false;
            Console.WriteLine("Is the point O({0},{1}), inside of K((0,0),5)? : {2}", x, y, inside);
            Console.WriteLine("The point 0({0},{1}), is outside of rectangle((-1,1),(5,5)) : {2}", x,y,outsideRectangle);


            //10.----------------------------


            Console.WriteLine("Number: ");
            int int1 = Convert.ToInt32(Console.ReadLine());
            int int2 = int1 / 1000;
            int int3 = (int1 / 100) % 10;
            int int4 = (int1 / 10) % 10;
            int int5 = (int1 % 10);

            Console.WriteLine("/a Sum of digits : {0}", int2 + int3 + int4 + int5);
            Console.WriteLine("/b Digits backwards : {3},{2},{1},{0}", int1, int2, int3, int4, int5 );
            Console.WriteLine("/c Last digit first : {3},{2},{1},{2}", int1, int2, int3, int4, int5);
            Console.WriteLine("/d Place swap : {0},{2},{1},{3}", int1, int2, int3, int4, int5);


            //11.------------------------------



            int n = 35, p = 6, u = 1, mask = u << p;
            Console.WriteLine((n & mask) != 0 ? "Third byte is: 1" : "Third bite is: 0");


            //12.-----------------------------


            int v = 50;
            int z = 10;
            int mask1 = 1 << z;

            bool isItOne = (v & mask1) != 0 ? true : false;
            Console.WriteLine("The byte at {0} position of the number {1} is 1? {2}", v, z, isItOne);

            //13.-------------------------------

            int n1 = 10;
            int v1 = 0;
            int p1 = 15;
            n1 = (v1 == 0) ? n1 = n1 & (~(1 << p1)) : n1 = n1 | (1 << p1);
            Console.WriteLine(n1);


            //14.-------------------------------


            int number1 = 100;
            bool Prime = true;

            if (number1 > 2)
                for (int i1 = 2; i1 <= Math.Ceiling(Math.Sqrt(number1)); ++i1)
                {
                    if (number1 % i == 0) Prime = false;


                                    }
            Console.WriteLine("Number {0} is prime? {1}", number1, Prime);

            //15.---------------------------------


            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int change = 1 << 3;
            int bit3 = (num & change) != 0 ? 1 : 0;
            change = 1 << 4;
            int bit4 = (num & change) != 0 ? 1 : 0;
            change = 1 << 5;
            int bit5 = (num & change) != 0 ? 1 : 0;
            change = 1 << 24;
            int bit24 = (num & change) != 0 ? 1 : 0;
            change = 1 << 25;
            int bit25 = (num & change) != 0 ? 1 : 0;
            change = 1 << 26;
            int bit26 = (num & change) != 0 ? 1 : 0;

            num = (bit3 == 0) ? num = num & (~(1 << 24)) : num = num | (1 << 24);
            num = (bit4 == 0) ? num = num & (~(1 << 25)) : num = num | (1 << 25);
            num = (bit5 == 0) ? num = num & (~(1 << 26)) : num = num | (1 << 26);
            num = (bit24 == 0) ? num = num & (~(1 << 3)) : num = num | (1 << 3);
            num = (bit25 == 0) ? num = num & (~(1 << 4)) : num = num | (1 << 4);
            num = (bit26 == 0) ? num = num & (~(1 << 5)) : num = num | (1 << 5);

            Console.WriteLine(num);




            //16.------------------------------------















            //Console.WriteLine(one / dZero);

            //--------------------------------------------------------------------------------------------------
            //                                                                                               //
            //          x          y             !x         x && y           x || y          x ^ y          // 
            //           true      true          false         true             true           false       //
            //           true      false         false         false            true           true       // 
            //           false     true          true          false            true           true      //
            //           false     false         true          false            false          false    //
            //                                                                                         //
            //----------------------------------------------------------------------------------------//

            //-sbyte→short, int, long, float, double, decimal;
            //-byte→short, ushort, int, uint, long, ulong, float, double,decimal;
            // -short→int, long, float,double, decimal;
            //   -ushort→int, uint, long, ulong, float,double, decimal;
            //    -char→ushort,  int,  uint,  long,  ulong,  float,double,  decimal

        }
    }
}