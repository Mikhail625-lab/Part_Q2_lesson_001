
/*
ver: 3.1b date: 2021.07.29
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

        const int WINDOW_MAX_WEIGHT = 150; // X
        const int WINDOW_MAX_HEIGHT = 40; // Y

        const string infoLesson = " Урок 1. Блок-схемы, асимптотическая сложность, рекурсия";
        const string lineAstrx = "**********************";
        const string lineDefis = "--------------------------";

        static void Main(string[] args)
        {
            ConfigureConsole(infoLesson);
            //Console.ReadKey();

            Task001();
            Task002();
            Task003();


        } // end of Main()


        static void Task001()
        { // Task № 001
          // block declare init vars

            string question1 = "\t Please, enter a number or press [Enter] key for random generate \n\t :=";
            string question2 = "";
            Random rnd1 = new Random();

            int number;

            // block executive
            Console.WriteLine("\t{0,5}   Task001   {0}", lineDefis);
            Console.ForegroundColor = ConsoleColor.Gray;
            number = Convert.ToInt32(GetStrFromCons(question1, Convert.ToString(rnd1.Next(10000))));
            Console.ForegroundColor = ConsoleColor.Gray;


            Console.WriteLine("\n\t Ok . Let's check whether the number is prime ...");
            if (IsPrimeNumber(number) == true)
            { Console.WriteLine("\t The number {0} is PRIME", number); }
            else Console.WriteLine("\t The number {0} is NOT prime", number);

            // end of  Task № 001
            Console.WriteLine("\t{0} End of Task001 {0}", lineDefis);
            //Console.ReadKey();
            ClearScr(5, 3);

        }


        static void Task002()
        { // Task № 002
          // block declare init vars
          // block executive
          // end of  Task № 002
        }

        static void Task003()
        { // Task № 003
          // block declare init vars

            string question1 = "\t Please, enter a number or press [Enter] key for random generate \n\t :=";
            string question2 = "";

            DateTime start = new DateTime();
            DateTime finish = new DateTime();

            Random rnd1 = new Random();

            ulong number;

            // block executive
            Console.WriteLine("\t{0,5}   Task003   {0}", lineDefis);
            Console.ForegroundColor = ConsoleColor.Gray;
            number = Convert.ToUInt64(GetStrFromCons(question1, Convert.ToString(rnd1.Next(30))));
            Console.ForegroundColor = ConsoleColor.Gray;


            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.Write("\n\tNow try calculate");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" WITHOUT ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" recursion   Start:[{0}]\n", DateTime.Now.ToString("HH:mm:ss"));
            start = DateTime.Now;
            fib1(number);
            finish = DateTime.Now;
            Console.WriteLine("\t...done                End:[{0}]", DateTime.Now.ToString("HH: mm:ss"));//Subtract 
            Console.WriteLine("\t                  Duration:[{0}]", (finish - start));

            Console.ForegroundColor = ConsoleColor.DarkGray;
            //Console.Write("\n\tNow try calculate with recursion");
            Console.Write("\n\tNow try calculate");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" WITH ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" recursion   Start:[{0}]\n", DateTime.Now.ToString("HH:mm:ss"));

            start = DateTime.Now;
            ulong i = 0;
            do
            {
                Console.Write("\t{0}\t|", i);
                Console.WriteLine("\t{0}", fib2(i));
                i++;
            }
            while (i <= number);

            finish = DateTime.Now;
            Console.WriteLine("\t  ...done              End:[{0}]", DateTime.Now.ToString("HH: mm:ss"));//Subtract 
            Console.WriteLine("\t                  Duration:[{0}]", (finish - start));
            Console.ReadKey();


            // end of  Task № 003
            Console.WriteLine("\t{0} End of Task003 {0}", lineDefis);
            Console.ReadKey();
            ClearScr(4, 2);
        }
        // for Task 001
        static bool IsPrimeNumber(int number)
        {
            int d = 0;
            int i;

            for (i = 2; i < number; i++)
            {
                // Console.WriteLine(" int  {0}%{1}={2,3}  \t\t double {3}%{4}={5}" , number , i , number%i   ,  Convert.ToDouble(number) , Convert.ToDouble(i) ,  Convert.ToDouble(number)% Convert.ToDouble(i));
                if (number % i == 0) d++;
            }

            if (d == 0) return true; //   Console.WriteLine("{,3}prime");
            else return false;

        }

        // for Task 003 

        static void fib1(ulong number) // No recurtion
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

        static ulong fib2(ulong number)

        {
            return number > 1 ? fib2(number - 1) + fib2(number - 2) : number;
        }


        // under

        static void ConfigureConsole(string headerConsWindow)
        {
            // Configure console.
            Console.Title = headerConsWindow;
            //Если значение TreatControlCAsInput свойства равно false и нажата клавиша CTRL +C, нажатые клавиши не сохраняются во входном буфере, а операционная система завершает выполняющийся процесс. Это значение по умолчанию.

            /*
             * Console.TreatControlCAsInput = true;
            Console.SetWindowSize(20, 30);
            Console.BufferWidth = WINDOW_MAX_WEIGHT;
            Console.BufferHeight = WINDOW_MAX_HEIGHT; ;

            Console.SetWindowSize(WINDOW_MAX_WEIGHT + 1, WINDOW_MAX_HEIGHT);
            //Console.WriteLine("now output 150 *");
            //Console.ReadKey();
            */
            /*
            for (int i = 0; i < 150; i++)
                Console.Write("*");
            Console.WriteLine("|");
            Console.ReadKey();

            */

            Console.ForegroundColor = ConsoleColor.Gray;

        }

        static string GetStrFromCons(string questionForEnterValue, string resultByDef)
        {
            string result;
            if (TestForNullOrEmpty(questionForEnterValue) == true)
            { questionForEnterValue = "\t Enter value:"; }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("   " + questionForEnterValue);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(12, 2);
            result = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            // check/verife isNull Empty
            if (TestForNullOrEmpty(result) == true)
            {
                result = resultByDef;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("\t Not value, set by default := ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" {0}", result);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");

            }


            return result;
        }

        static bool TestForNullOrEmpty(string s)
        {
            bool result;
            result = (s == null || s == string.Empty);
            return result;
        }
        static bool SwitchBool(bool bSw)
        {
            if (bSw == true) bSw = false;
            else bSw = true;
            return bSw;
        }



        static void ClearScr(int countDown, int warningTimer)
        {
            bool bWarning = false;

            for (int i = (countDown + 1); i > 0; i--)
            {
                System.Threading.Thread.Sleep(1000);
                if (i == warningTimer) { bWarning = true; }
                if (bWarning == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\r         ");
                Console.Write("\r     [{0}]", i);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();



        }






    } // end of class Programm
} // end ofname of space
