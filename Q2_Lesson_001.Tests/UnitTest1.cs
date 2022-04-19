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
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibNoRecurtion(x);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GetFibNoRecurtion_F1_1returned()
        {
            // arange
            int x = 1;
            int expected = 1;

            // act
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibNoRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibNoRecurtion_F2_1returned()
        {
            // arange           
            int x = 2;
            int expected = 1;

            // act
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibNoRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibNoRecurtion_F3_2returned()
        {
            // arange             
            int x = 3;
            int expected = 2;
            // act
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibNoRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibNoRecurtion_F4_3returned()
        {
            // arange
            int x = 4;
            int expected = 3;

            // act
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibNoRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibNoRecurtion_F5_5returned()
        {
            // arrange
            int x = 5;
            int expected = 5;
            // act
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibNoRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibNoRecurtion_F6_8returned()
        {
            // arrange
            int x = 6;
            int expected = 8;
            // act
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibNoRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibNoRecurtion_F7_13returned()
        {
            // arrange
            int x = 7;
            int expected = 13;
            // act
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibNoRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void GetFibRecurtion_F0_0returned()
        {
            // arange
            int x = 0;
            int expected = 0;

            // act
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibRecurtion(x);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GetFibRecurtion_F1_1returned()
        {
            // arange
            int x = 1;
            int expected = 1;

            // act
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibRecurtion_F2_1returned()
        {
            // arange           
            int x = 2;
            int expected = 1;

            // act
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibRecurtion_F3_2returned()
        {
            // arange             
            int x = 3;
            int expected = 2;
            // act
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibRecurtion_F4_3returned()
        {
            // arange
            int x = 4;
            int expected = 3;

            // act
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibRecurtion_F5_5returned()
        {
            // arrange
            int x = 5;
            int expected = 5;
            // act
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibRecurtion_F6_8returned()
        {
            // arrange
            int x = 6;
            int expected = 8;
            // act
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibRecurtion_F7_13returned()
        {
            // arrange
            int x = 7;
            int expected = 13;
            // act
            MathLib fib = new MathLib();
            ulong actual = fib.GetFibRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
