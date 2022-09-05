using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MOOd,
            NULL_MOOD
        }
        public ExceptionType exceptionType;

        public MoodAnalyzerException(ExceptionType exceptionType, string messege) : base(messege)
        {
            this.exceptionType = exceptionType;
        }
    }
}
