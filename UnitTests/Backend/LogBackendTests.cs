﻿using System;
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

            // Act

            // Assert
        }

        [TestMethod]
        public void LogBackend_Create_InValid_Null_Should_Fail()
        {
            // Arange

            // Act

            // Assert
        }

        [TestMethod]
        public void LogBackend_Read_Valid_Item_Should_Pass()
        {
            // Arange

            // Act

            // Assert
        }

        [TestMethod]
        public void LogBackend_Read_InValid_Item_Should_Pass()
        {
            // Arange

            // Act

            // Assert
        }

        [TestMethod]
        public void LogBackend_Update_First_Item_Should_Pass()
        {
            // Arange

            // Act

            // Assert
        }

        [TestMethod]
        public void LogBackend_Update_InValid_Bogus_Item_Should_Pass()
        {
            // Arange

            // Act

            // Assert
        }

        [TestMethod]
        public void LogBackend_Delete_First_Item_Should_Pass()
        {
            // Arange

            // Act

            // Assert
        }

        [TestMethod]
        public void LogBackend_Delete_InValid_Bogus_Item_Should_Pass()
        {
            // Arange

            // Act

            // Assert
        }
    }
}