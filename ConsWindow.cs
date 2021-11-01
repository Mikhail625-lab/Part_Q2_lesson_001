using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _001_lesson;

namespace _001_lesson
{
    class ConsWindow
    {
        public const int WINDOW_MAX_WEIGHT = 150; // X
        public const int WINDOW_MAX_HEIGHT = 40; // Y

        public const string infoLesson = " Урок 1. Блок-схемы, асимптотическая сложность, рекурсия";
        public const string lineAstrx = "**********************";
        public const string lineDefis = "--------------------------";

        static void ConfigureConsole(string headerConsWindow)
        {
            // Configure console.
            Console.Title = headerConsWindow;
            //Если значение TreatControlCAsInput свойства равно false и нажата клавиша CTRL +C,
            //нажатые клавиши не сохраняются во входном буфере, а операционная система завершает
            //выполняющийся процесс. Это значение по умолчанию.

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


        public void ClearScr(int countDown, int warningTimer)
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

        public void TaskInfo()
        {
        string taskInfo1 ;
        string taskInfo2 ;
        string taskInfo3 ;
        StringBuilder sb1 = new StringBuilder();
        sb1.Append ( "\t\t[ 1. ] Требуется реализовать на C# функцию согласно блок-схеме.");
        sb1.Append ( "\n\t\tБлок-схема описывает алгоритм проверки, простое число или нет.");
        sb1.Append ( "\n\t\tАлгоритм реализовать отдельно в функции согласно блок-схеме.");
        sb1.Append ( "\n\t\tНаписать проверочный код в main функции .\n\t\tКод выложить на GitHub.");
        sb1.Append ( "\n\t\t                     ");
        taskInfo1 = sb1.ToString();
        sb1.Clear();

        sb1.Append ( "\t\t[ 2. ]  Посчитайте сложность функции");
                    sb1.Append ( "\n\t\t                     ");
        taskInfo2=sb1.ToString();
        sb1.Clear();

        sb1.Append ( "\t\t[ 3. ]  Реализуйте функцию вычисления числа Фибоначчи");
        sb1.Append ( "\n\t\tТребуется реализовать рекурсивную версию и версию без рекурсии (через цикл).");
                    sb1.Append ( "\n\t\t.............................................................................");
        taskInfo3=sb1.ToString();
        sb1.Clear();
        
             Console.WriteLine("                ................................... begin ................................... ");
        Console.WriteLine(taskInfo1);
        Console.WriteLine(taskInfo2);
        Console.WriteLine(taskInfo3);
        }

    }

    class WindowUtils
    {



    }// // end of     class WindowUtils




}
