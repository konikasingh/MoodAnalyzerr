using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyseeTest
{
    [TestClass]
    public class MoodTestcase
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        ////TEST CASE-3.1

        ////Arrange
        //string message = null;
        //string expected = "Message Should Not Be Null";
        //string actual = null;

        //try
        //{
        //    //Act
        //    moodAnalysis analyser = new moodAnalysis(message);
        //    actual = analyser.AnalyseMood();
        //}
        //catch (MoodAnalyserCustomException ex)
        //{
        //    //Assert
        //    Assert.AreEqual(expected, ex.Message);
        //}


        //}

        //[TestMethod]
        //public void getCustomNullException()
        //{
        ////TEST CASE-3.2
        //    //Arrange
        //    string expected = "Message Should Not Be Empty";
        //    moodAnalysis modeAnalyzer = new moodAnalysis(string.Empty);

        //    try
        //    {
        //        //Act
        //        string actual = modeAnalyzer.AnalyseMood();

        //    }
        //    catch (MoodAnalyserCustomException ex)
        //    {

        //        //Assert
        //        Assert.AreEqual(expected, ex.Message);
        //    }

        //}

        //[TestMethod]
        ////Test Case 4.1 given mood Analyse class name should return mood analyser object.

        //public void GivenMoodAnalyseClassName_Should_return_MoodAnalyseObject()
        //{
        //    string message = null;
        //    object expected = new moodAnalysis(message);
        //    object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser01_Core.MoodAnalyser", "MoodAnalyser");
        //    expected.Equals(obj);
        //}

        [TestMethod]
        //Test Case 4.2 Given mood Analyse wrong class name should return exception stating no such class name exist 

        public void GivenMoodAnalyseWrongClassName_Should_return_MoodAnalyseObjectException_Message()
        {
            try
            {
                string message = null;
                object expected = new MoodAnalyser(message);
                object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyser01_Core.MoodAnalyserWrong", "MoodAnalyserWrong");
                expected.Equals(obj);
            }

            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Class not found", e.Message);
            }
        }

        [TestMethod]
        //Test Case 4.3 Given wrong constructor name should return simproper message in exception

        public void GivenMoodAnalyseWrongConstructor_Should_return_MoodAnalyseObjectException_Message()
        {
            try
            {
                string message = null;
                object expected = new MoodAnalyser(message);
                object obj = MoodAnalyzerCustomException.CreateMoodAnalyse("MoodAnalyser01_Core.MoodAnalyser", "MoodAnalyserWrong");
                expected.Equals(obj);
            }

            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Constructor not found", e.Message);
            }
        }
    }
}