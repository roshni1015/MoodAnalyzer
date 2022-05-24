using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public MoodAnalyser() 
        {

        }
        public string msg = "Happy";
        public MoodAnalyser(string message)
        {
            this.msg = message;

        }
        public string analyseMood()
        {
            string message1 = "Sad";
            if (msg.ToLower().Contains(message1.ToLower()))
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
