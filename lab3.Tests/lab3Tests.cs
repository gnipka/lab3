using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab3.Tests
{
    [TestClass]
    public class lab3Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            /// <summary>
            /// arrange
            /// </summary>
            
            double coefA = 1;
            double coefC = 1;
            double x = -1.41;
            double expected = 0.06;

            /// <summary>
            /// act
            /// </summary>

            CalcFuncOvalCassini calc = new CalcFuncOvalCassini();
            double actual = calc.CalcY(coefA, coefC, x);

            /// <summary>
            /// assert
            /// </summary>

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            /// <summary>
            /// arrange
            /// </summary>

            double coefA = 1;
            double coefC = 1;
            double x = 0;
            double expected = 0;

            /// <summary>
            /// act
            /// </summary>

            CalcFuncOvalCassini calc = new CalcFuncOvalCassini();
            double actual = calc.CalcY(coefA, coefC, x);

            /// <summary>
            /// assert
            /// </summary>

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            /// <summary>
            /// arrange
            /// </summary>

            double coefA = 0;
            double coefC = 1;
            double x = -1;
            double expected = 0;

            /// <summary>
            /// act
            /// </summary>

            CalcFuncOvalCassini calc = new CalcFuncOvalCassini();
            double actual = calc.CalcY(coefA, coefC, x);

            /// <summary>
            /// assert
            /// </summary>

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            /// <summary>
            /// arrange
            /// </summary>

            double coefA = 6;
            double coefC = 1;
            double x = -5.05;
            double expected = 3.3;

            /// <summary>
            /// act
            /// </summary>

            CalcFuncOvalCassini calc = new CalcFuncOvalCassini();
            double actual = calc.CalcY(coefA, coefC, x);

            /// <summary>
            /// assert
            /// </summary>

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            /// <summary>
            /// arrange
            /// </summary>

            double coefA = 6;
            double coefC = 1;
            double x = 6.08;
            double expected = 0.18;

            /// <summary>
            /// act
            /// </summary>

            CalcFuncOvalCassini calc = new CalcFuncOvalCassini();
            double actual = calc.CalcY(coefA, coefC, x);

            /// <summary>
            /// assert
            /// </summary>

            Assert.AreEqual(expected, actual);
        }
    }
}
