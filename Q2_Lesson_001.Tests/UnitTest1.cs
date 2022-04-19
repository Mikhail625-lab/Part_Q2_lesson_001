using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Q2_Lesson_001
{
    [TestClass]
    public class MathLibTests
    {
        [TestMethod]
        public void GetFibNoRecurtion_F0_0returned()
        {
            // arange
            int x = 0;
            int expected = 0;

            // act
            MathLib fib = new  MathLib();

            
            int actual = fib.GetFibNoRecurtion(x);
            // assert           


        }

        public void GetFibNoRecurtion_F1_1returned()
        {
            // arange
            int x = 1;
            int expected = 1;

            // act
            // assert
        }

        public void GetFibNoRecurtion_F2_1returned()
        {
            // arange           
            int x = 2;
            int expected = 1;

            // act
            // assert
        }

        public void GetFibNoRecurtion_F3_2returned()
        {
            // arange             
            int x = 3;
            int expected = 2;
            // act
            // assert
        }

        public void GetFibNoRecurtion_F4_3returned()
        {
            // arange
            int x = 4;
            int expected = 3;

            // act
            // assert
        }

        public void GetFibNoRecurtion_F5_5returned()
        {
            // arrange
            int x = 5;
            int expected = 5
            // act
            // assert
        }

    }
}
