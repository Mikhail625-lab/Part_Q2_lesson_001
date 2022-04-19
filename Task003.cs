using System;

namespace Q2_Lesson_001
{
    class Task003
    {
        public void Task003Sol()
        { // Task № 003
          // block declare init vars

            string question1 = "\t Please, enter a number or press [Enter] key for random generate \n\t :=";
            string question2 = "";
            string resultUTest = "";

            MathLib ml1 = new MathLib();
            ConsWindow cw1 = new ConsWindow();
            Dispatcher d1 = new Dispatcher();
            InOut io1 = new InOut();
            UTest ut1 = new UTest();

            DateTime start = new DateTime(); DateTime finish = new DateTime();
            Random rnd1 = new Random();
            int number;

            // block executive
            Console.WriteLine("\t{0,5}   Task003   {0}", ConsWindow.lineDefis);
            Console.ForegroundColor = ConsoleColor.Gray;
            number = Convert.ToInt32(io1.GetStrFromCons(question1, Convert.ToString(rnd1.Next(30))));
            Console.ForegroundColor = ConsoleColor.Gray;


            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.Write("\n\tNow try calculate");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" WITHOUT ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" recursion   Start:[{0}]\n", DateTime.Now.ToString("HH:mm:ss"));

            start = DateTime.Now;
            ml1.GetFibNoRecurtion(number);
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
            int i = 0;
            ulong calcFib;
            do
            {
                calcFib = ml1.GetFibRecurtion(i);
                if (ut1.IsFib(i, calcFib) == true)
                { resultUTest = "UTest:OK"; }
                else { resultUTest = "UTest:Failed"; }

                if (i < 2)
                {
                    Console.Write("\t{0}\t|", i);
                    Console.WriteLine("\t{0}\t\t | ", calcFib);
                }

                if (i > 1)
                {
                    Console.Write("\t{0}\t|", i);
                    Console.WriteLine("\t{0}\t\t | \t\t{1}", calcFib, resultUTest);
                }
                i++;
            }
            while (i <= number);

            finish = DateTime.Now;
            Console.WriteLine("\t\t  ...done              End:[{0}]", DateTime.Now.ToString("HH: mm:ss"));//Subtract 
            Console.WriteLine("\t\t                  Duration:[{0}]", (finish - start));
            Console.ReadKey();


            // end of  Task № 003
            Console.WriteLine("\t{0} End of Task003 {0}", ConsWindow.lineDefis);
            Console.ReadKey();
            d1.EndTask();
        }
        // for Task 001
    }
}
