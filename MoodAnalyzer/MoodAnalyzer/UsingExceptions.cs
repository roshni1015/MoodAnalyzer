using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class UsingExceptions
    {
        public string analyseMood(string message)
        {
            try
            {
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
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default(string);
           

        }



    }
}
