﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public string analyseMood(string message)
        {
            string message1 = "Sad";
            if (message.ToLower().Contains(message1.ToLower()))
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
