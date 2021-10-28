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

    }

    class WindowUtils
    {



    }// // end of     class WindowUtils




}
