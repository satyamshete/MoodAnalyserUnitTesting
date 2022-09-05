using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyserNull : Exception
    {
        public string Is_Happy;
        public MoodAnalyserNull(string MoodIs)
        {
            Is_Happy = MoodIs;
        }
    }
}
