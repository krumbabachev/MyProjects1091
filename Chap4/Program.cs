using System;

namespace Chap4
{
    class Program
    {
        static void Main(string[] args)
        {

            //1-------------------------------------------------------------

            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());



            Console.WriteLine("a + b + c = {0}", a + b + c);


            //2--------------------------------------------------------------

            Console.WriteLine("Enter r: ");
            int r = Int32.Parse(Console.ReadLine());

            Console.WriteLine("P = {0}, S = {1}", 2 * Math.PI * r, Math.PI * r * r);


            //3--------------------------------------------------------------

            Console.Write("Enter Company Name: ");
            string compName = Console.ReadLine();
            Console.Write("Enter Company Addres: ");
            string compAddr = Console.ReadLine();
            Console.Write("Enter Company Phone Number: ");
            string compPhNum = Console.ReadLine();
            Console.Write("Enter Company Fax: ");
            string compFax = Console.ReadLine();
            Console.Write("Enter Company WebSite: ");
            string compWeb = Console.ReadLine();
            Console.Write("Enter Company Manager: ");
            string compMan = Console.ReadLine();
            Console.Write("Enter Company Manager First Name: ");
            string compManF = Console.ReadLine();
            Console.Write("Enter Company Manager Last Name: ");
            string compManL = Console.ReadLine();
            Console.Write("Enter Company Manager Phone Number: ");
            string compManPhNum = Console.ReadLine();

            Console.WriteLine("Company Details: Name - {0}, Addres - {1}, Phone Number - {2}, Fax - {3}, Webiste - {4}", compName, compAddr, compPhNum, compFax, compWeb);
            Console.WriteLine("Manager Details: Name - {0} {1}, Phone : - {2}", compManF, compManL, compManPhNum);

            //4-----------------------------------------------------------------------------------

            int num1 = 2000;
            Console.WriteLine("|0x{0,-8:X|", num1);
            double num2 = -1.2445;
            Console.WriteLine("|0,-10:f2}|", num2);

            double num3 = 14.32345;
            Console.WriteLine("|0,-10:f2}|", num3);


            //5----------------------------------------------------------------------------------

            int counter = 0;

            Console.WriteLine("Enter first number: ");
            int d = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int e = Int32.Parse(Console.ReadLine());

            for ( int i = d; i <= e; i++)
            {

                if (i % 5 == 0) counter++;

            }

            Console.WriteLine("{0} numbers were found", counter);


            //6---------------------------------------------------------------------------------

            int f = Int32.Parse(Console.ReadLine());
            int g = Int32.Parse(Console.ReadLine());


            Console.WriteLine("{0} >= {1}", Math.Max(f, g), Math.Min(f, g));

            //7-----------------------------------------------------------------------------------

            int h, i1, j, k, l;
            bool parseSucc = false;

            do
            {
                Console.WriteLine("Enter the first number: ");
                parseSucc = Int32.TryParse(Console.ReadLine(), out h);
                Console.WriteLine(parseSucc);
            } while (!parseSucc);

            do
            {


                Console.WriteLine("Enter the second number: ");
                parseSucc = Int32.TryParse(Console.ReadLine(), out i1);
                Console.WriteLine(parseSucc);


            } while (!parseSucc);

            do
            {
                Console.WriteLine("Enter the third number: ");
                parseSucc = Int32.TryParse(Console.ReadLine(), out j);
                Console.WriteLine(parseSucc);
            } while (!parseSucc);

            do
            {
                Console.WriteLine("Enter the fourth number: ");
                parseSucc = Int32.TryParse(Console.ReadLine(), out k);
                Console.WriteLine(parseSucc);
            } while (!parseSucc);
            do
            {
                Console.WriteLine("Enter the fifth number: ");
                parseSucc = Int32.TryParse(Console.ReadLine(), out l);
                Console.WriteLine(parseSucc);
            } while (!parseSucc);

            //8-------------------------------------------------------------


            Console.WriteLine("First number: ");
            int a1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            int b1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Third Number: ");
            int c1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Fourth number: ");
            int d1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Fifth Number: ");
            int e1 = Int32.Parse(Console.ReadLine());

            if (a1 > b1 && a1 > c1 && a1 > d1 && a1 > e1)
                Console.WriteLine("{0} is the biggest number", a1);
            else if ( b1 > a1 && b1 > c1 && b1 > d1 && b1 > e1)
                Console.WriteLine("{0} is the biggest number", b1);
            else if ( c1 > a1 && c1 > b1 && c1 > d1 && c1 > e1)
                Console.WriteLine("{0} is the biggest number", c1);
            else if (d1 > a1 && d1 > b1 && d1 > c1 && d1 > e1)
                Console.WriteLine("{0} is the biggest number", d1);
            else if (e1 > a1 && e1 > b1 && e1 > c1 && e1 > d1)
                Console.WriteLine("{0} is the biggest nubmer", c1);
            else
                Console.WriteLine("The numbers are equal");

            //9----------------------------------------------------------------------


            double d2, x1, x2;
            Console.Write("Enter A ( A != 0): ");
            double a2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            double b2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter C: ");
            double c2 = Int32.Parse(Console.ReadLine());

            d2 = b2 * b2 - 4 * a2 * c2;

            if ( d2 < 0 )
                Console.WriteLine("D={0}, There are no real roots", d2);
            else if (d == 0)
            {
                x1 = (-b2 / (2 * a2));
                                            }

            else
            {
                x1 = (-b2 + Math.Sqrt(d2)) / (2 * a2);
                x2 = (-b2 + Math.Sqrt(d2)) / (2 * a2);

                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            }

            //10-----------------------------------------------------------------------

            int sum = 0;

            Console.Write("Enter numbers: ");
            int lenght = Int32.Parse(Console.ReadLine());

            for ( int i = 0; i < lenght; i++)
            {
                Console.WriteLine("Enter { 0 } number: ",i +1);
                sum += Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of numbers is: {0}", sum);


            //11----------------------------------------------------------------------


            int sum1 = 0;
            Console.WriteLine("Enter Number: ");
            int lenght1 = Int32.Parse(Console.ReadLine());

            for ( int i = 0; i < lenght1; i++)
            {

                Console.WriteLine(i);

            }

            //12-------------------------------------------------------------------


            int num11 = 0;
            int num22 = 1;
            int sum12 = 1;
            int count1 = 0;

            Console.WriteLine(num11);

            while ( count1 < 100)
            {

                sum12 = num11 + num22;
                num11 = num22;
                num22 = sum12;
                Console.WriteLine(num22);
                count1++;
            }


            //13--------------------------------------------------------------------

            Console.Write("Your number: ");
            int lenght2 = Int32.Parse(Console.ReadLine());
            double sum22 = 1.0;
            

            for (int i = 2; i <= lenght2; i++)
            {

                sum22 += (1.0 / i);

                            }
            Console.WriteLine("{0:F#}", sum22);












        }
    }
}