using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyseeTest
{
    [TestClass]
    public class TestCase2
    {
        [TestMethod]
        //Test Case 5.1 given mood Analyse class name should return mood analyser object with parameterised constructor

        public void Given_ParameterisedConstructor_MoodAnalyseClassName_Should_return_MoodAnalyseObject()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyzerFactory.CreateMoodAnalyserParameterisedConstructor("MoodAnalyser01_Core.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }


        [TestMethod]
        //Test Case 5.2 Given mood Analyse wrong class name should return exception stating no such class name exist 

        public void Given_ParameterisedConstructor_WrongClassName_Should_return_MoodAnalyseObjectException_Message()
        {
            try
            {
                object expected = new MoodAnalyser("HAPPY");
                object obj = MoodAnalyzerFactory.CreateMoodAnalyserParameterisedConstructor("MoodAnalyser01_Core.MoodAnalyserWrong", "MoodAnalyser");
                expected.Equals(obj);
            }

            catch (CustomMoodAnException e)
            {
                Assert.AreEqual("Class not found", e.Message);
            }
        }


        //Test Case 5.3 Given mood Analyse wrong constructor name should return exception stating no such consrtructor exist 
        [TestMethod]
        public void Given_ParameterisedConstructor_WrongConstrcutorName_Should_return_MoodAnalyseObjectException_Message()
        {
            try
            {
                object expected = new MoodAnalyser("HAPPY");
                object obj = MoodAnalyzerFactory.CreateMoodAnalyserParameterisedConstructor("MoodAnalyser01_Core.MoodAnalyser", "MoodAnalyserWrong");
                expected.Equals(obj);
            }

            catch (CustomMoodAnException e)
            {
                Assert.AreEqual("Constructor not found", e.Message);
            }
        }
    }
}