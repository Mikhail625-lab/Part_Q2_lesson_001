using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_lesson
{
    class Task002
    {
        public void Task002Sol()
        {
            ConsWindow cw1 = new ConsWindow();
            Dispatcher d1 = new Dispatcher();

            string codeSource =                 "";
            string answ = "\t\tАсимптотическая сложность StrangeSum(int[] inputArray)\n\t\tO(n^3) ";

            Console.WriteLine(answ);
            //Console.WriteLine("\t\tAnd press any key for continue ...");
            //Console.ReadKey();

            cw1.ClearScr(11, 3);
            Console.Clear();
            d1.Run("T1");

        }

    }
}
