using Microsoft.VisualStudio.TestTools.UnitTesting;
/*старт
 * Hot key :
 * Ctrl + R , T         запуск\старт
 * Ctrl+R,Ctrl+T Debug Отладка
 */

namespace Q2_Lesson_001
{
    [TestClass]
    public class MathLibTests
    {
        [TestMethod]

        public void GetFibNoRecurtion_F0_0returned()
        {
            // arange // (подготовка)
            int x = 0; ulong expected = 0;
            MathLib sut = new MathLib(); // sut (System Under Test) video from YouTube  "Unit-тестирование (основы часть 2 )" by Sergei Calabonga 

            // act // (действие) 

            ulong actual = sut.GetFibNoRecurtion(x);

            // assert // (проверка)
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GetFibNoRecurtion_F1_1returned()
        {
            // arange
            int x = 1; ulong expected = 1;

            // act
            MathLib sut = new MathLib();
            ulong actual = sut.GetFibNoRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibNoRecurtion_F2_1returned()
        {
            // arange           
            int x = 2; ulong expected = 1;

            // act
            MathLib sut = new MathLib();
            ulong actual = sut.GetFibNoRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibNoRecurtion_F3_2returned()
        {
            // arange             
            int x = 3; ulong expected = 2;
            // act
            MathLib sut = new MathLib();
            ulong actual = sut.GetFibNoRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibNoRecurtion_F4_3returned()
        {
            // arange
            int x = 4; ulong expected = 3;

            // act
            MathLib sut = new MathLib();
            ulong actual = sut.GetFibNoRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibNoRecurtion_F5_5returned()
        {
            // arrange
            int x = 5; ulong expected = 5;
            // act
            MathLib sut = new MathLib();
            ulong actual = sut.GetFibNoRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibNoRecurtion_F6_8returned()
        {
            // arrange
            int x = 6; ulong expected = 8;
            // act
            MathLib sut = new MathLib();
            ulong actual = sut.GetFibNoRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibNoRecurtion_F7_13returned()
        {
            // arrange
            int x = 7; ulong expected = 13;
            // act
            MathLib sut = new MathLib();
            ulong actual = sut.GetFibNoRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void GetFibRecurtion_F0_0returned()
        {
            // arange
            int x = 0;
            ulong expected = 0;

            // act
            MathLib sut = new MathLib();
            ulong actual = sut.GetFibRecurtion(x);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GetFibRecurtion_F1_1returned()
        {
            // arange
            int x = 1;
            ulong expected = 1;

            // act
            MathLib sut = new MathLib();
            ulong actual = sut.GetFibRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibRecurtion_F2_1returned()
        {
            // arange           
            int x = 2;
            ulong expected = 1;

            // act
            MathLib sut = new MathLib();
            ulong actual = sut.GetFibRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibRecurtion_F3_2returned()
        {
            // arange             
            int x = 3;
            ulong expected = 2;
            // act
            MathLib sut = new MathLib();
            ulong actual = sut.GetFibRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibRecurtion_F4_3returned()
        {
            // arange
            int x = 4;
            ulong expected = 3;

            // act
            MathLib sut = new MathLib();
            ulong actual = sut.GetFibRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibRecurtion_F5_5returned()
        {
            // arrange
            int x = 5;
            ulong expected = 5;
            // act
            MathLib sut = new MathLib();
            ulong actual = sut.GetFibRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibRecurtion_F6_8returned()
        {
            // arrange
            int x = 6;
            ulong expected = 8;
            // act
            MathLib sut = new MathLib();
            ulong actual = sut.GetFibRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetFibRecurtion_F7_13returned()
        {
            // arrange
            int x = 7;
            ulong expected = 13;
            // act
            MathLib sut = new MathLib();
            ulong actual = sut.GetFibRecurtion(x);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
