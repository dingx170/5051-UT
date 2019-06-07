using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

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
    }
}
