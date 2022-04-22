using System;




namespace Q2_Lesson_001
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

            ConsWindow windowConsole = new ConsWindow();
            InOut io1 = new InOut();

            Task001 tsk1 = new Task001();
            Task002 tsk2 = new Task002();
            Task003 tsk3 = new Task003();

            windowConsole.TaskInfo();

            int i = 1;
            do
            {

                Console.WriteLine(question1, i);
                //Console.SetCursorPosition(52, 14);

                i = io1.GetValueFromConsole("", 52, 14);

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

                    default:
                        Console.WriteLine("One or both meaning are not valid.");
                        break;
                }
                if (mustExit == true) { break; }
            } while (i == 0);
        } // enf_of_Run

        public void EndTask()
        {

            int count = 5;
            int warningCount = 2;
            ConsWindow windowConsole = new ConsWindow();
            windowConsole.ClearScr(count, warningCount);
            Console.Clear();
            this.Run("");
        } // public_void_EndTask ()
    }// end_of_class_Dispatcher


}
