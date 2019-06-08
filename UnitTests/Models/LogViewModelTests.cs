using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;
using System.Collections.Generic;

namespace UnitTests.Models
{
    [TestClass]
    public class LogViewModelTests
    {
        [TestMethod]
        public void LogViewModel_Instantiate_Default_Should_Pass()
        {
            // Arrange
            // just evoking the constructor will cover 60% of the code, so no arrange is needed 

            // Act
            var result = new LogViewModel();

            // Assert
            // We don’t know what the new log model is, but we can check that it is not null.  
            // Testing for a NOT is less desired than testing for an IS, 
            // but we have little choice for this test so add test to validate it is not null
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LogViewModel_Get_Default_Should_Pass()
        {
            // Arrange
            var myTest = new LogViewModel();

            // Act
            var result = myTest.LogList;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LogViewModel_Set_Default_Should_Pass()
        {
            // Arrange
            var myTest = new LogViewModel();
            var myList = new List<LogModel>();
            myList.Add(new LogModel { PhoneID = "Phone" });

            // Act
            myTest.LogList = myList;
            var result = myTest.LogList;

            // Assert
            Assert.AreEqual("Phone", result[0].PhoneID);
        }
    }
}
