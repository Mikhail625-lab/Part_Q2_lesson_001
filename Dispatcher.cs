﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _001_lesson
{
    //    internal class Dispatcher


    class Dispatcher
    {
        public void Run(string TaskName)
        {
            bool mustExit = false;
            string question1 = "\t\t\t\tPlease, enter number task (1...5) for run" +
                "\n\t\t\t\tor 0 (digit  zero) for exit" +
                "\n\t\t\t\tand press [Enter] :";
            string question2 = "\t\t\t\tOK. Your choice:[{0}]\n\t\t\t\tNow runing [Task00{0}]";

            ConsWindow cw1 = new ConsWindow();
            InOut io1 = new InOut();

            Task001 tsk1 = new Task001();
            Task002 tsk2 = new Task002();
            Task003 tsk3 = new Task003();

            cw1.TaskInfo();

            int i = 1;
            do
            {
                Console.WriteLine(question1, i);
                i = io1.GetValueFromConsole("");

                switch (i)
                {
                    case 0:
                        mustExit = true;
                        Console.WriteLine("\t\tHave nice day! Buy!");
                        break;
                    case 1:
                        tsk1.Task001Sol();
                        break;
                    case 2:
                        tsk2.Task002Sol();
                        break;
                    case 3:
                        tsk3.Task003Sol();
                        break;
                }
                if (mustExit == true) { break; }
            } while (i == 0);
        } // enf_of_Run

        public void EndTask ()
        { 
            ConsWindow cw1 = new ConsWindow();
            cw1.ClearScr(11, 3);
            Console.Clear();
            this.Run("");
        } // public_void_EndTask ()
    }// end_of_class_Dispatcher


}
