using MoodAnalyzer;

namespace MoodAnalyzerTestCases
{
    public class Tests
    {
        Moodanalyzer moodanalyzer;
        [SetUp]

        public void Setup()
        {
            moodanalyzer = new Moodanalyzer();
        }

        [Test]
        public void Given_Sad_Return_Sad_Default_constructor()
        {
            moodanalyzer = new Moodanalyzer();
            string messege = "I am in Sad mood";
            string result = moodanalyzer.AnalysisUsinMoodWithDefaultConstructor(messege);
            Assert.AreEqual("SAD", result);
        }
        [Test]
        public void Given_Happy_Return_Happy_Default_constructor()
        {
            moodanalyzer = new Moodanalyzer();
            string messege = "I am in HAPPY mood";
            string result = moodanalyzer.AnalysisUsinMoodWithDefaultConstructor(messege);
            Assert.AreEqual("HAPPY", result);
        }
        [Test]
        public void Given_Sad_Return_Sad_Parameterised_constructor()
        {

            string messege = "I am in Sad mood";
            moodanalyzer = new Moodanalyzer(messege);
            string result = moodanalyzer.AnalysisUsinMoodWithParameterisedConstructor();
            Assert.AreEqual("SAD", result);
        }

        [Test]
        public void Given_Happy_Return_Happy_Parameterised_constructor()
        {
            string messege = "I am in Happy mood";
            moodanalyzer = new Moodanalyzer(messege);
            string result = moodanalyzer.AnalysisUsinMoodWithParameterisedConstructor();
            Assert.AreEqual("HAPPY", result);
        }

        [Test]
        //UC2
        public void Given_Null_Return_happy()
        {
            moodanalyzer = new Moodanalyzer();
            try
            {
                string Message = moodanalyzer.AnalyseMoodException();
            }
            catch (MoodAnalyserNull mood)
            {
                Assert.AreEqual("HAPPY", mood.Is_Happy);
            }
        }

        [Test]
        ////UC3
        public void Using_Custom_exception_GivenNull_Return_Null()
        {
            moodanalyzer = new Moodanalyzer();
            try
            {
                string messege = moodanalyzer.AnalyseMoodByExceptionHandling();
            }
            catch (MoodAnalyzerException exception)
            {
                Assert.AreEqual(MoodAnalyzerException.ExceptionType.NULL_MOOD, exception.exceptionType);
            }
        }
        [Test]
        ////UC3
        public void Using_Custom_exception_GivenEmpty_Return_Empty()
        {
            moodanalyzer = new Moodanalyzer("");
            try
            {
                string messege = moodanalyzer.AnalyseMoodByExceptionHandling();
            }
            catch (MoodAnalyzerException exception)
            {
                Assert.AreEqual(MoodAnalyzerException.ExceptionType.EMPTY_MOOd, exception.exceptionType);
            }
        }
    }
}