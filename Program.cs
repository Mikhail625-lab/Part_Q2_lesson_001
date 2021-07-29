
/*
ver: 0.1a date: 2021.07.29
autor: Mikhail625@protonmail.com

                Tip: for formatting Ctrl + K, а затем Ctrl + D.
*/

/* Задания. Условия.
1. Требуется реализовать на C# функцию согласно блок-схеме. Блок-схема описывает алгоритм проверки, простое число или нет.
    Написать консольное приложение.
    Алгоритм реализовать отдельно в функции согласно блок-схеме.
    Написать проверочный код в main функции .
    Код выложить на GitHub.

2.  Посчитайте сложность функции

3.  Реализуйте функцию вычисления числа Фибоначчи
Требуется реализовать рекурсивную версию и версию без рекурсии (через цикл).



 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_lesson
{
    class Program
    {
        static void Main(string[] args)
        {



            Task001();
            Task002();
            Task003();






        } // end of Main()


        static void Task001()
        { // Task № 001
          // block declare init vars
          // block executive

            Console.WriteLine("\n\t\t\t End of Task01");
            // end of  Task № 001
        }


        static void Task002()
        { // Task № 002
          // block declare init vars
          // block executive
          // end of  Task № 002
        }

        static void Task003()
        { // Task № 002
          // block declare init vars
          // block executive
          // end of  Task № 002
        }

        static bool IsPrimeNumber(int number)
        {

            //Console.WriteLine("Please enter number :");
            //int number = Convert.ToInt32(Console.ReadLine());
            int d = 0;
            int i;

            for (i = 2; i < number; i++)
            {
                // Console.WriteLine(" int  {0}%{1}={2,3}  \t\t double {3}%{4}={5}" , number , i , number%i   ,  Convert.ToDouble(number) , Convert.ToDouble(i) ,  Convert.ToDouble(number)% Convert.ToDouble(i));
                if (number % i == 0) d++;
            }

            if (d == 0) return true; //   Console.WriteLine("{,3}simple");
            else return true; //Console.WriteLine("not simple");

        }


    } // end of class Programm
} // end ofname of space
