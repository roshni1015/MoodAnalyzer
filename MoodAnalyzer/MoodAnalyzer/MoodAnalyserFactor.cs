using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyserFactor
    {
        public static object CreateMoodanalyser(string classname, string constructorname)
        {
            string pattern = @"." + constructorname + "$";
            Match result = Regex.Match(classname, pattern);
            if(result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(classname);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomException(CustomException.ExceptionType.NoSuchClass,"Class not found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchConstructor,"Constructor is not found");
            }

        }
    }
}
