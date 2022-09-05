using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class Moodanalyzer
    {
        public string Sentense;
        public Moodanalyzer()
        {

        }
        public Moodanalyzer(string sentense)
        {
            this.Sentense = sentense;
        }
        public string AnalysisUsinMoodWithDefaultConstructor(string sentence)
        {
            if (sentence.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {

                return "HAPPY";
            }
        }
        public string AnalysisUsinMoodWithParameterisedConstructor()
        {
            if (Sentense.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {

                return "HAPPY";
            }
        }
        public string AnalyseMoodException()
        {
            try
            {
                if (Sentense.ToLower().Contains("sad"))

                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserNull("HAPPY");
            }
        }
        public string AnalyseMoodByExceptionHandling()
        {
            try
            {
                if (Sentense.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else if (Sentense.Equals(string.Empty))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MOOd, "Mood should not be empty");
                }
                else return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MOOD, "Mood should not be null");
            }
        }
    }
}
