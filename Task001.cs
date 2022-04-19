using System;
//using _001_lesson;

namespace Q2_Lesson_001
{
    class Task001
    {
        public  void Task001Sol()
        {
            // Task № 001
            // block declare init vars

            string question1 = "\t Please, enter a number (ex. 99991) or press [Enter] key for random generate \n\t :=";
            string question2 = "";
            Random rnd1 = new Random();
            Console.WriteLine("");
            ConsWindow cw1 = new ConsWindow();
            InOut io1 = new InOut();
            MathLib ml1 = new MathLib();

            Dispatcher d1 = new Dispatcher();
    
            int number;
            string lineDefis = ConsWindow.lineDefis;
            // block executive


            Console.Clear();
            Console.WriteLine("\t{0,5}   Task001   {0}", lineDefis); 
            Console.ForegroundColor = ConsoleColor.Gray;
            number = Convert.ToInt32(io1.GetStrFromCons(question1, Convert.ToString(rnd1.Next(10000)) , 11,2)); 
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\t Ok . Let's check whether the number is prime ...");

            if (ml1.IsPrimeNumber(number) == true)
            { Console.WriteLine("\t The number {0} is PRIME", number); }
            else Console.WriteLine("\t The number {0} is NOT prime", number);

            // testing results 

            Console.WriteLine("\n\t Press [Enter] key for run UTesting...");

            // end of  Task № 001
            Console.WriteLine("\t{0} End of Task001 {0}", lineDefis);
            //Console.ReadKey();
            d1.EndTask();

        }

    }
}
