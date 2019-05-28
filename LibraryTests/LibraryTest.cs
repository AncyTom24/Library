using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;


namespace LibraryTests
{
    [TestClass]
    public class LibraryTest
    {
        [TestMethod]
        public void test_writeData()       
        {
            //Arrange
            bool expected = true;
            About abt = new About();
            string details = "Test";
            validation validationObj = new validation();
            //Act
            bool actual = validationObj.writeData(details, abt.path);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_AddMembName()
        {
            //Arrange
            bool expected = false;
            About abt = new About();
            abt.name = "";

            //Act
            bool actual =  false;
            if (String.IsNullOrEmpty(abt.name))
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_AddMembStudID()
        {
            //Arrange
            bool expected = false;
            About abt = new About();
            abt.studentID = "";

            //Act
            bool actual = false;
            if (String.IsNullOrEmpty(abt.studentID))
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_AddMembEmail()
        {
            //Arrange
            bool expected = false;
            About abt = new About();
            
            //Act
            bool actual = false;
            if (String.IsNullOrEmpty(abt.email))
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_AddMembPhone()
        {
            //Arrange
            bool expected = false;
            About abt = new About();            

            //Act
            bool actual = false;
            if (String.IsNullOrEmpty(abt.phone))
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_AddMembAddress()
        {
            //Arrange
            bool expected = false;
            About abt = new About();

            //Act
            bool actual = false;
            if (String.IsNullOrEmpty(abt.address))
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_writeDataCheckOut()
        {
            //Arrange
            bool expected = true;
            Checkout checkoutObj = new Checkout();
            string details = "Test";
            validation validationObj = new validation();
            //Act
            bool actual = validationObj.writeData(details, checkoutObj.path);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_CheckOutName()
        {
            //Arrange
            bool expected = false;
            Checkout checkoutObj = new Checkout();

            //Act
            bool actual = false;
            if (String.IsNullOrEmpty(checkoutObj.name))
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_CheckOutStudID()
        {
            //Arrange
            bool expected = false;
            Checkout checkoutObj = new Checkout();

            //Act
            bool actual = false;
            if (String.IsNullOrEmpty(checkoutObj.studentID))
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_CheckoutBookName()
        {
            //Arrange
            bool expected = false;
            Checkout checkoutObj = new Checkout();
            
            //Act
            bool actual = false;
            if (String.IsNullOrEmpty(checkoutObj.bookName))
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_checkoutBookID()
        {
            //Arrange
            bool expected = false;
            Checkout checkoutObj = new Checkout();

            //Act
            bool actual = false;
            if (String.IsNullOrEmpty(checkoutObj.BookID))
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_checkOutReturnDate()
        {
            //Arrange
            bool expected = false;
            Checkout checkoutObj = new Checkout();

            //Act
            bool actual = false;
            if (String.IsNullOrEmpty(checkoutObj.returnDate))
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Checkin
        [TestMethod]
        public void test_writeDataCheckin()
        {
            //Arrange
            bool expected = true;
            Checkin checkinObj = new Checkin();
            string details = "Test";
            validation validationObj = new validation();
            //Act
            bool actual = validationObj.writeData(details, checkinObj.path);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_CheckinName()
        {
            //Arrange
            bool expected = false;
            Checkin checkinObj = new Checkin();

            //Act
            bool actual = false;
            if (String.IsNullOrEmpty(checkinObj.name))
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_CheckinStudID()
        {
            //Arrange
            bool expected = false;
            Checkin checkinObj = new Checkin();

            //Act
            bool actual = false;
            if (String.IsNullOrEmpty(checkinObj.studentID))
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_CheckinBookName()
        {
            //Arrange
            bool expected = false;
            Checkin checkinObj = new Checkin();

            //Act
            bool actual = false;
            if (String.IsNullOrEmpty(checkinObj.bookName))
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_checkinBookID()
        {
            //Arrange
            bool expected = false;
            Checkin checkinObj = new Checkin();

            //Act
            bool actual = false;
            if (String.IsNullOrEmpty(checkinObj.BookID))
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_checkinTakenDate()
        {
            //Arrange
            bool expected = false;
            Checkin checkinObj = new Checkin();

            //Act
            bool actual = false;
            if (String.IsNullOrEmpty(checkinObj.takenDate))
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
