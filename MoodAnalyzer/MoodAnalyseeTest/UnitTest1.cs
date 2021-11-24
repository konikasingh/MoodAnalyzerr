using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyseeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Test case1

            //Arrange
            string message = "I am in sad mood";
            string expected = "SAD";

            //Act
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.AnalyseMood(message);

            //Act
            Assert.AreEqual(expected, actual);
        }
    }
}