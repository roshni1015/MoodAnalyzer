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
        public static string Invokeanalysemood(string message, string method)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzer.MoodAnalyser");
                object moodAnalyseObject = MoodanalayserParameterizedConstructor.UsingParameterizedConstructor("MoodAnalyzer.MoodAnalyser", "MoodAnalyser", message);
                MethodInfo analyseMoodInfo = type.GetMethod(method);
                object mood = analyseMoodInfo.Invoke(moodAnalyseObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchMethod, "Method is Not Found");
            }

        }
    }
    public class MoodanalayserParameterizedConstructor
    {
        public static object UsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo cnstr = type.GetConstructor(new[] { typeof(string) });
                    object instance = cnstr.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.NoSuchConstructor, "Constructor is not found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchClass, "Class not found");
            }
        }
    }
}
