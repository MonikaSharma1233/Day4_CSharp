
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgelabz_Practice
{
    public static class Day3
    {
        public static void uname()
        {

            Console.WriteLine("Enter the Username: ");
            String uname = Console.ReadLine();
            int len = uname.Length;
            if (len < 3)
            {
                Console.WriteLine("Username is not valid!!!");
            }
            else if (len == 3)
            {
                Console.WriteLine("Username is having 3 characters.");
            }
            else
            {
                Console.WriteLine("Hello " + uname + " How are you?");
            }

        }
        public static void flipcoin()
        {
            Console.WriteLine("Enter the number of times you want to flip the coin: ");
            int flip = Convert.ToInt32(Console.ReadLine());
            int headcount = 0;
            int tailcount = 0;
            for (int i = 1; i <= flip; i++)
            {
                Random ran = new Random();
                int num = ran.Next(2);

                //Console.WriteLine(num);
                if (num == 0)
                {
                    tailcount++;
                }
                else
                {
                    headcount++;
                }
            }
            Console.WriteLine(tailcount + " number of time generated Tail");
            Console.WriteLine(headcount + " number of time generated Head");
            int headper = (headcount*100)/flip;
            int tailper = (tailcount*100)/flip;
            Console.WriteLine(tailper+"%  generated Tail");
            Console.WriteLine(headper+"%  generated Head");

        }
        public static void leapyear()
        {
            int check = 0;
            int check1 = 0;
            Console.WriteLine("Enter the year to know, Is it leap year or not: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year>1000 && year<9999)
            {
                check = year % 400;
                check1 = year % 4;
                if(check==0 && check1==0)
                {
                    Console.WriteLine("Entered year is a leep year.");
                }
                else
                {
                    Console.WriteLine("Entered year is not a leap year.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        public static void tableofpoweroftwo()
        {
            Console.WriteLine("Enter the value for n to show the table nth term: ");
            int n=Convert.ToInt32(Console.ReadLine());
            
            
            if (n>=0 && n<31)
            { 
                for(int j=0;j<n+1;j++)
                {
                    double expr = Math.Pow(2, j);

                    Console.WriteLine("2^" + j + "= " +expr);
                }
             }
            else
            {
                Console.WriteLine("Invalid Input!!!");
            }
        }
        public static void Harmonicno()
        {
            Console.WriteLine("Enter valu for n to print Harmonic no till nth term: ");
            int num=Convert.ToInt32(Console.ReadLine());
            string s = " + ";
            for(int i=1;i<num+1;i++) 
            {
                if (i == num)
                {
                    s = " ";
                }
                Console.Write("1/" + i + s);
                
            }
        }
        public static void primefactor()
        {
            Console.WriteLine("Enter the number to check prime factors of number:");
            int num= Convert.ToInt32(Console.ReadLine());
            int checkcount = 0;
            for (int i=1;i<=num+1;i++) 
            { 
                int expr = num % i;
                if(expr == 0)
                {
                    checkcount++;
                    Console.Write(i+" ");
                }
            }
            if(checkcount==2)
            {
                Console.WriteLine("Number is Prime");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }
        }
    }
}
