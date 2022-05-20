using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerusingConstructor
    {
        public MoodAnalyzerusingConstructor()
        {

        }

        public string msg1 = "I am in Sad Mood";
        public MoodAnalyzerusingConstructor(string message)
        {
            this.msg1 = message;
        }
        public string analyseMood1()
        {
            string message1 = "Sad";
            if (msg1.ToLower().Contains(message1.ToLower()))
            {
                return message1;
            }
            else
            {
                return "Happy";
            }

        }
        

    }
}
