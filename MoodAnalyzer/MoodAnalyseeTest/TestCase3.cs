using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyseeTest
{
    [TestClass]
    public class TestCase3
    {
        ///Following is the test case 7.1
        ///in this scenario of testing we check that the field returns the message that we enter or specify during runtime - dynamically

        public void GivenHappy_ShouldReturnHappy_WithReflectorDynamically()
        {
            string result = MoodAnalyserReflector.Setfield("Happy", "message");
            Assert.AreEqual("Happy", result);
        }

        [TestMethod]
        //Following is for TC 7.2
        //for this test case we provide wrong field name to get an exception
        public void GivenWrongField_ShouldReturn_Exception()
        {
            try
            {
                string result = MoodAnalyserReflector.Setfield("Happy", "messageWrong");
                Assert.AreEqual("Happy", result);
            }
            catch (CustomMoodAnException e)
            {
                Assert.AreEqual("Field not found", e.Message);
            }
        }
        [TestMethod]
        //Following is for TC 7.3
        //here to pass this test case we pass empty message in the reflector and see what exception it throws
        public void GivenEmptyMessage_ShouldReturn_Exception()
        {
            try
            {
                string result = MoodAnalyserReflector.Setfield(null, "messageWrong");
                Assert.AreEqual("Happy", result);
            }
            catch (CustomMoodAnException e)
            {
                Assert.AreEqual("Message should not be null", e.Message);
            }
        }

    }
}