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
            MoodAnalyser analyse = new("I am in Happy Mood");
            Assert.AreEqual("Happy", analyse.analyseMood());
        }
        [TestMethod()]
        public void analyseMoodTest2()
        {
            MoodAnalyser analyse = new("I am in Any Mood");
            Assert.AreEqual("Happy", analyse.analyseMood());
        }
    }
}