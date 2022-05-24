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
    public class MoodanalayserParameterizedConstructorTests
    {
        [TestMethod()]
        public void UsingParameterizedConstructorTest()
        {
            object expected = "MoodAnalyzer.MoodAnalyser";
            object analyser6 = MoodanalayserParameterizedConstructor.UsingParameterizedConstructor("MoodAnalyzer.MoodAnalyser", "MoodAnalyser", "Happy");
            expected.Equals(analyser6);
        }
        [TestMethod()]
        public void UsingParameterizedConstructorTest1()
        {
            string expected = "Class not found";
            try
            {
                object analyser6 = MoodanalayserParameterizedConstructor.UsingParameterizedConstructor("123MoodAnalyzer.MoodAnalyser", "MoodAnalyser", "Happy");

            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
            
        }
        [TestMethod()]
        public void UsingParameterizedConstructorTest2()
        {
            string expected = "Constructor is not found";
            try
            {
                object analyser6 = MoodanalayserParameterizedConstructor.UsingParameterizedConstructor("MoodAnalyzer.MoodAnalyser", "MoodAnalyser123", "Happy");

            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
}