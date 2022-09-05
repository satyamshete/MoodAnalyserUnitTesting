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
    }
}