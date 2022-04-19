using System;

namespace Q2_Lesson_001
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

        public ulong   GetFibNoRecurtion(int number) // No/withiuot recurtion
        {

            ulong position1 = 0;
            ulong position2 = 1;
            ulong rslt =0;

            string msg1 = "\t\tN-ый член должен быть больше чем 1";

            if (number < 1)
            {
                Console.WriteLine(msg1);
                return rslt;
            }

            {
                UTest ut1 = new UTest();
                string resultUTest;
                for (int i = 0; i <= number; i++)
                {

                    rslt = position1;
                    if (i < 2) Console.WriteLine("\t{0}\t|\t{1}", i, i );
                    if (i > 1)
                    {
                        if (ut1.IsFib(i, (ulong)rslt) == true)
                        { resultUTest = "UTest:OK"; }
                        else { resultUTest = "UTest:Failed"; }
                        Console.WriteLine("\t{0}\t|\t{1}\t | {2}", i, rslt , resultUTest);
                    }
                    position1 = position2;
                    position2 = position2 + rslt;


                }
                return rslt;
            }

        }

        public ulong GetFibRecurtion(int number) // With recurtion

        {
            ulong rslt = number > 1 ? (ulong)(GetFibRecurtion(number - 1) + GetFibRecurtion(number - 2)) : (ulong)number;
            return (ulong)rslt;

            // return number > 1 ? GetFibRecurtion(number - 1) + GetFibRecurtion(number - 2) : number;
        }



    }



}
