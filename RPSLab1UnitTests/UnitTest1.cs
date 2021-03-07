using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSLab1;
namespace RPSLab1UnitTests
{
    [TestClass]
    public class UnitTest1 //Тестирование основного алгоритма программы 
    {
        [TestMethod]
        public void TestWithAll()
        {
            RPSLab1.ArrayWorking testingArray = new ArrayWorking();
            double[] testArray1 = new double[9] { -1, 0, -3, 0, -4, 2, 5, 6, -2 };
            testArray1 = testingArray.Sorting(testArray1);
            int[] sortedTestArray1 = new int[9] { 2, 5, 6, 0, 0, -1, -3, -4, -2 };
            for (int i = 0; i < testArray1.Length; i++)
                Assert.AreEqual(testArray1[i], sortedTestArray1[i]);
        }
        [TestMethod]
        public void TestWithoutZero()
        {
            RPSLab1.ArrayWorking testingArray = new ArrayWorking();
            double[] testArray2 = new double[3] { -4, -2, 3 };
            testArray2 = testingArray.Sorting(testArray2);
            int[] sortedTestArray2 = new int[3] { 3, -4, -2 };
            for (int i = 0; i < testArray2.Length; i++)
                Assert.AreEqual(testArray2[i], sortedTestArray2[i]);
        }
        [TestMethod]
        public void TestWithoutNegative()
        {
            RPSLab1.ArrayWorking testingArray = new ArrayWorking();
            double[] testArray3 = new double[4] { 0, 4, 2, 6 };
            testArray3 = testingArray.Sorting(testArray3);
            int[] sortedTestArray3 = new int[4] { 4, 2, 6, 0 };
            for (int i = 0; i < testArray3.Length; i++)
                Assert.AreEqual(testArray3[i], sortedTestArray3[i]);
        }
        [TestMethod]
        public void TestOnlyNegative()
        {
            RPSLab1.ArrayWorking testingArray = new ArrayWorking();
            double[] testArray4 = new double[3] { -1, -3, -4 };
            testArray4 = testingArray.Sorting(testArray4);
            int[] sortedTestArray4 = new int[3] { -1, -3, -4 };
            for (int i = 0; i < testArray4.Length; i++)
                Assert.AreEqual(testArray4[i], sortedTestArray4[i]);
        }
        [TestMethod]
        public void TestOnlyZero()
        {
            RPSLab1.ArrayWorking testingArray = new ArrayWorking();
            double[] testArray5 = new double[3] { 0, 0, 0 };
            testArray5 = testingArray.Sorting(testArray5);
            int[] sortedTestArray5 = new int[3] { 0, 0, 0 };
            for (int i = 0; i < testArray5.Length; i++)
                Assert.AreEqual(testArray5[i], sortedTestArray5[i]);
        }
        [TestMethod]
        public void TestOnlyPozitive()
        {
            RPSLab1.ArrayWorking testingArray = new ArrayWorking();
            double[] testArray6 = new double[3] { 3, 4, 5 };
            testArray6 = testingArray.Sorting(testArray6);
            int[] sortedTestArray6 = new int[3] { 3, 4, 5 };
            for (int i = 0; i < testArray6.Length; i++)
                Assert.AreEqual(testArray6[i], sortedTestArray6[i]);
        }
        [TestMethod]
        public void TestWithoutPozitive()
        {
            RPSLab1.ArrayWorking testingArray = new ArrayWorking();
            double[] testArray7 = new double[3] { -2, -3, 0 };
            testArray7 = testingArray.Sorting(testArray7);
            int[] sortedTestArray7 = new int[3] { 0, -2, -3 };
            for (int i = 0; i < testArray7.Length; i++)
                Assert.AreEqual(testArray7[i], sortedTestArray7[i]);
        }
    }
}
