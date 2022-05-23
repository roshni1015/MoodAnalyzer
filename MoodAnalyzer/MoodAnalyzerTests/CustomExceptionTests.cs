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
    public class CustomExceptionTests
    {
        [TestMethod()]
        public void CustomExceptionTest()
        {
            try
            {
                string message = null;
                UsingcustomExceptions analyse4 = new();        

            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Mood Should not be Null", ex.Message);
            }

           
        }
        [TestMethod()]
        public void CustomExceptionTest1()
        {
            try
            {
                string message = "";
                UsingcustomExceptions analyse4 = new();

            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Mood Should not be Empty", ex.Message);
            }


        }
    }
}