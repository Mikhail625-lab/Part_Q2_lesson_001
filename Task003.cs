﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_lesson
{
    class Task003
    {
        public void Task003Sol ()
        { // Task № 003
          // block declare init vars

            string question1 = "\t Please, enter a number or press [Enter] key for random generate \n\t :=";
            string question2 = "";

            MathLib ml1 = new MathLib();
            ConsWindow cw1 = new ConsWindow();
            InOut io1 = new InOut();

            DateTime start = new DateTime(); DateTime finish = new DateTime();
            Random rnd1 = new Random();
            ulong number;

            // block executive
            Console.WriteLine("\t{0,5}   Task003   {0}", ConsWindow.lineDefis);
            Console.ForegroundColor = ConsoleColor.Gray;
            number = Convert.ToUInt64(io1.GetStrFromCons(question1, Convert.ToString(rnd1.Next(30))));
            Console.ForegroundColor = ConsoleColor.Gray;


            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.Write("\n\tNow try calculate");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" WITHOUT ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" recursion   Start:[{0}]\n", DateTime.Now.ToString("HH:mm:ss"));
            start = DateTime.Now;
            ml1.fib1(number);
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
                Console.WriteLine("\t{0}", ml1.fib2(i));
                i++;
            }
            while (i <= number);

            finish = DateTime.Now;
            Console.WriteLine("\t  ...done              End:[{0}]", DateTime.Now.ToString("HH: mm:ss"));//Subtract 
            Console.WriteLine("\t                  Duration:[{0}]", (finish - start));
            Console.ReadKey();


            // end of  Task № 003
            Console.WriteLine("\t{0} End of Task003 {0}", ConsWindow.lineDefis);
            Console.ReadKey();
            cw1.ClearScr(4, 2);
        }
        // for Task 001
    }
}