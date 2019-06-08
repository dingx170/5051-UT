using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ReportViewModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Get_Default_Should_Pass()
        {
            // Arrange

            // Act

            // Assert
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Set_Default_Should_Pass()
        {
            // Arrange

            // Act

            // Assert
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Get_Default_Should_Pass()
        {
            // Arrange

            // Act

            // Assert
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Set_Default_Should_Pass()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
