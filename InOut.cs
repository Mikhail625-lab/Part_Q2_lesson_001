using System;

namespace _001_lesson
{
    // InOut

    class InOut
    {
        public int GetValueFromConsole(string textQuestion)
        {
            int result = 0;
            string textQuetionByDef = "\t\tEnter value and press [Enter]:";
            var valueByDef = "1";
            string textQstn = string.IsNullOrEmpty(textQuestion) == true ? textQuetionByDef : textQuestion;
            // Запрос на ввод значения . 
            Console.WriteLine("\t\t\t\t{0}" , textQuestion);
            var inputValue = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            // проверка введённого значения на пустоту и далее валидность 
            if (string.IsNullOrEmpty(inputValue) == true)
            {
                result = Convert.ToInt32(valueByDef);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("       " + "Not value, set by default: {0}", valueByDef);
                //Console.WriteLine("\t\tNot value, set by default: {0}", valueByDef);
                //Console.ForegroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");
            }
            else
            {
                if (int.TryParse(inputValue, out result) == true)
                {

                }
                else
                {
                    Console.WriteLine("\t\tError input value or data." +
                                    "\n\t\tSet value by default or re-enter ?");
                }
            }
            return result;
        }//end_of_GetValueFromConsole

        public string GetStrFromCons(string questionForEnterValue, string resultByDef)
        {
            string result;
            if (string.IsNullOrEmpty(questionForEnterValue) == true)
            { questionForEnterValue = "\t Enter value:"; }
            Console.ForegroundColor = ConsoleColor.DarkGray; 
            Console.WriteLine("   " + questionForEnterValue);
            Console.ForegroundColor = ConsoleColor.DarkGreen; 
            Console.SetCursorPosition(12, 19);
            result = Console.ReadLine(); Console.ForegroundColor = ConsoleColor.DarkGray;

            // check/verife isNull Empty
            if (string.IsNullOrEmpty(result) == true)
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


    }





}
