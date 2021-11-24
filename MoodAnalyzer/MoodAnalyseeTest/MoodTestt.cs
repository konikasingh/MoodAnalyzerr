using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyseeTest
{
    [TestClass]
    public class MoodTestt
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    //TEST CASE-1

        //    //Arrange
        //    string message = null;
        //    string expected = "Happy";

        //    //Act
        //    MoodAnalyser analyser = new MoodAnalyser(message);
        //    string actual = analyser.AnalyseMood();

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void getCustomNullException()
        {
            //Arrange
            string expected = "Message Should Not Be Empty";
            MoodAnalyser modeAnalyzer = new MoodAnalyser(string.Empty);

            try
            {
                //Act
                string actual = modeAnalyzer.AnalyseMood();

            }
            catch (MoodAnalyzerCustomException ex)
            {

                //Assert
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
}