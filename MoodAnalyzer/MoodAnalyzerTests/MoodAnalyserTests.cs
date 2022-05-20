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
    public class MoodAnalyserTests
    {
        [TestMethod()]
        public void analyseMoodTest()
        {
            MoodAnalyser analyse = new();
            Assert.AreEqual("Happy", analyse.analyseMood("I am in Happy Mood"));
        }
    }
}