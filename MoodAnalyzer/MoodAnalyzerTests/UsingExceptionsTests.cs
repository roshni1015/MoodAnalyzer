using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer.Tests
{
    [TestClass()]
    public class UsingExceptionsTests
    {
        [TestMethod()]
        public void analyseMoodTest()
        {
            try
            {
                UsingExceptions analyse3 = new();
                string result3 = analyse3.analyseMood(null);
                Console.WriteLine(result3);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}