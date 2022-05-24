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
    public class MoodAnalyzerusingConstructorTests
    {
        [TestMethod()]
        public void MoodAnalyzerusingConstructorTest()
        {
            MoodAnalyzerusingConstructor analyse1 = new();
            string result1 = analyse1.analyseMood1();
            Assert.AreEqual("Sad",result1);
        }

        [TestMethod()]
        public void MoodAnalyzerusingConstructorTest1()
        {
            MoodAnalyzerusingConstructor analyse2 = new("I am in Happy Mood");
            string result2 = analyse2.analyseMood1();
            Assert.AreEqual("Happy", result2);
        }

      
    }
}