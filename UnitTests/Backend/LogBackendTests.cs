using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Backend;
using System.Collections.Generic;
using HW1c.Models;
using System.Linq;
using System.Web;

namespace UnitTests.Backend
{
    [TestClass]
    public class LogBackendTests
    {
        /*
        [TestMethod]
        public void LogBackend_Default_Instantiate_Should_Pass()
        {
            // Arange

            // Act
            var result = new LogBackend();

            // Assert
            Assert.IsNotNull(result);
        }
         */
        [TestMethod]
        public void LogBackend_Index_Default_Should_Pass()
        {
            // Arange

            // Act
            var result = LogBackend.Instance.Index();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LogBackend_Create_Valid_Item_Should_Pass()
        {
            // Arange
            var myModel = new LogModel();

            // Act
            var result = LogBackend.Instance.Create(myModel);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LogBackend_Create_InValid_Null_Should_Fail()
        {
            // Arange

            // Act
            var result = LogBackend.Instance.Create(null);

            // Assert
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void LogBackend_Read_Valid_Item_Should_Pass()
        {
            // Arange
            var myModel = new LogModel
            {
                ID = "bogus"
            };
            var myData = LogBackend.Instance.Create(myModel);

            // Act
            var result = LogBackend.Instance.Read("bogus");

            // Assert
            Assert.AreEqual(myModel, result);
        }

        [TestMethod]
        public void LogBackend_Update_Valid_Item_Should_Pass()
        {
            // Arange
            var myModel = new LogModel
            {
                ID = "bogus"
            };
            var myData = LogBackend.Instance.Create(myModel);
            myModel.ID = "updated";
            
            // Act
            var result = LogBackend.Instance.Read("updated");

            // Assert
            Assert.AreEqual(myModel, result);
        }

        [TestMethod]
        public void LogBackend_Delete_Valid_Item_Should_Pass()
        {
            // Arange
            var myModel = new LogModel
            {
                ID = "bogus"
            };

            // Act
            var myData = LogBackend.Instance.Delete("bogus");
            var result = LogBackend.Instance.Read("bogus");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void LogBackend_Delete_InValid_Item_Should_Pass()
        {
            // Arange
            var myModel = new LogModel
            {
                ID = "bogus"
            };

            // Act
            var myData = LogBackend.Instance.Delete("invalid");

            // Assert
            Assert.AreEqual(false, myData);
        }
    }
}
