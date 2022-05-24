using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            Nullmessage, EmptyMessage, NoSuchClass, NoSuchConstructor

        }
        public readonly ExceptionType type;
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
    public class UsingcustomExceptions
    {
        public string analyseMood(string message)
        {
            try
            {
                if(message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EmptyMessage, "Mood should not be Empty");
                }
                string message1 = "Sad";
                if (message.ToUpper().Contains(message1.ToUpper()))
                {
                    return message1;
                }
                else
                {
                    return "Happy";
                }
                

            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.Nullmessage, "Mood should not be Null");
            }
            return default(string);


        }



    }
}
