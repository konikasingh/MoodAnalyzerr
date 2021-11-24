using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyseeTest
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //TEST CASE-1

            //Arrange
            string message = null;
            string expected = "Happy";

            //Act
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}