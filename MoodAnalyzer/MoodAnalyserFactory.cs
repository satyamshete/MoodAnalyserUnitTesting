using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            // pattern to check if given classname and constructor are same or not
            string pattern = @"." + constructorName + "$";
            Match match = Regex.Match(className, pattern);

            if (match.Success)
            {
                try
                {   //this returns the assembly 
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    //Type to get the type of class in runtime
                    Type moodAnalyserType = assembly.GetType(className);
                    //createInstance- to create an object of above type(i.e class)
                    return Activator.CreateInstance(moodAnalyserType);

                }
                catch (ArgumentNullException e)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_CLASS_FOUND, "No Class Name is Present");
                }
            }
            else
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_CONSTRUCTOR, "No Constructor is Present");
        }
        public static object CreateMoodAnalyserUsingParametrisedConstructor(string className, string constructorName)
        {
            Type type = typeof(Moodanalyzer);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                try
                {
                    if (type.Name.Equals(constructorName))
                    {
                        ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                        object instance = constructorInfo.Invoke(new object[] { "Happy" });
                        return instance;
                    }
                    else
                    {
                        throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_CONSTRUCTOR, "No Constructor is Present");
                    }
                }
                catch (ArgumentNullException e)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_CONSTRUCTOR, "No Constructor is Present");
                }
            }
            else
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_CLASS_FOUND, "No Class Name is Present");
            }

        }
    }
}
