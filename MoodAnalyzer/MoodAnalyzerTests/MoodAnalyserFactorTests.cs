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
    public class MoodAnalyserFactorTests
    {
        [TestMethod()]
        public void MoodanalyserTest()
        {
            string excepted = "Class not found";

            try
            {
                object analyser5 = MoodAnalyserFactor.CreateMoodanalyser("123MoodAnalyzer.UsingcustomExceptions", "UsingcustomExceptions");

            }
            catch (CustomException ex)
            {
                Assert.AreEqual(excepted, ex.Message);
            }

        }

        [TestMethod()]
        public void Moodanalysertest1()
        {
            object excepted = new UsingcustomExceptions();
            object result = MoodAnalyserFactor.CreateMoodanalyser("MoodAnalyzer.UsingcustomExceptions", "UsingcustomExceptions");
            excepted.Equals(result);


        }
        [TestMethod()]
        public void MoodanalyserTest2()
        {
            string excepted = "Constructor is not found";

            try
            {
                object analyser5 = MoodAnalyserFactor.CreateMoodanalyser("MoodAnalyzer.UsingcustomExceptions", "UsingcustomExceptions123");

            }
            catch (CustomException ex)
            {
                Assert.AreEqual(excepted, ex.Message);
            }



        }

        [TestMethod()]
        public void InvokeanalysemoodTest()
        {
            string expected = "Happy";
            string analyser7 = MoodAnalyserFactor.Invokeanalysemood("Happy", "analyseMood");
            expected.Equals(analyser7);
            

        }
        [TestMethod()]
        public void InvokeanalysemoodTest1()
        {
            string excepted = "Method is Not Found";

            try
            {
                string analyser7 = MoodAnalyserFactor.Invokeanalysemood("Happy", "12analyseMood");

            }
            catch (CustomException ex)
            {
                Assert.AreEqual(excepted, ex.Message);
            }



        }
    }
}