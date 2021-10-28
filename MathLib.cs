using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_lesson
{
    public class MathLib
    {
        public bool IsPrimeNumber(int number)
        {
            int d = 0; int i = 0;

            for (i = 2; i < number; i++)
            {
                // Console.WriteLine(" int  {0}%{1}={2,3}  \t\t double {3}%{4}={5}" , number , i , number%i   ,  Convert.ToDouble(number) , Convert.ToDouble(i) ,  Convert.ToDouble(number)% Convert.ToDouble(i));
                if (number % i == 0) d++;
            }

            if (d == 0) return true; //   Console.WriteLine("{,3}prime");
            else return false;

        }

        // for Task 003 

        public void fib1(ulong number) // No recurtion
        {

            ulong position1 = 0;
            ulong position2 = 1;
            ulong rslt;
            for (ulong i = 0; i <= number; i++)
            {
                if (number <= 1)
                {
                    Console.WriteLine("\t{0}\t|\t{1}", i, position1);
                    continue;
                }
                else
                {
                    rslt = position1;
                    Console.WriteLine("\t{0}\t|\t{1}", i, rslt);
                    position1 = position2;
                    position2 = position2 + rslt;
                }
            }
        }

        public ulong fib2(ulong number)

        {
            return number > 1 ? fib2(number - 1) + fib2(number - 2) : number;
        }



    }



}
