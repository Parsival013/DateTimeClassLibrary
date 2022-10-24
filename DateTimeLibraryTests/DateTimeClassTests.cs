using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DateTimeLibrary;

namespace DateTimeLibraryTests
{
    [TestClass]
    public class DateTimeClassTests
    {
        /// <summary>
        /// метод, определяющий предыдущий день
        /// </summary>
        [TestMethod]
        public void PrevDate_DetermineThePreviousDay_ReturnedPreviousDay()
        {
            //Arrange
            DateTime DateTimes = new DateTime(2022, 10, 8);
            DateTime excepted = new DateTime(2022,10,7);
            //Act

            DateTime actual = DateTimeClass.PrevDate(DateTimes);
            //Assert
            Assert.AreEqual(actual, excepted);
        }
        /// <summary>
        /// метод, определяющий следующий день
        /// </summary>
        [TestMethod]
        public void NextDate_DetermineTheNextDay_ReturnedNextDay()
        {
            //Arrange
            DateTime DateTimes = new DateTime(2022, 10, 8);
            DateTime excepted = new DateTime(2022, 10, 9);
            //Act
            DateTime actual = DateTimeClass.NextDate(DateTimes);
            //Assert
            Assert.AreEqual(actual, excepted);
        }
        /// <summary>
        /// метод, устанавливающий, является ли введенный день последний в месяце или нет
        /// </summary>
        [TestMethod]
        public void NextDayOfMonth_DataNotLastDayMonth_ReturnedTrue()
        {
            //Arrange
            DateTime DateTimes = new DateTime(2022, 10, 8);

            //Act
            DateTimeClass c = new DateTimeClass();
            bool actual = c.NextDayOfMonth(DateTimes);
            //Assert
            Assert.IsTrue(actual);

        }
        /// <summary>
        /// метод, устанавливающий, является ли введенный день последний в месяце или нет
        /// </summary>
        [TestMethod]
        public void NextDayOfMonth_DataLastDayMonth_ReturnedFalse()
        {
            //Arrange
            DateTime DateTimes = new DateTime(2022, 10, 31);

            //Act
            DateTimeClass c = new DateTimeClass();
            bool actual = c.NextDayOfMonth(DateTimes);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// метод, устанавливающий, является ли введенный день первым днем в году или нет
        /// </summary>
        [TestMethod]
        public void FirstDayOdYear_DataItFistDayYear_ReturnedTrue()
        {
            //Arrange
            DateTime DateTimes = new DateTime(2022, 1, 1);

            //Act
            DateTimeClass c = new DateTimeClass();
            bool actual = c.FirstDayOdYear(DateTimes);
            //Assert
            Assert.IsTrue(actual);

        }
        /// <summary>
        /// метод, устанавливающий, является ли введенный день первым днем в году или нет
        /// </summary>
        [TestMethod]
        public void FirstDayOdYear_DataItNotFistDayYear_ReturnedFalse()
        {
            //Arrange
            DateTime DateTimes = new DateTime(2022, 1, 2);

            //Act
            DateTimeClass c = new DateTimeClass();
            bool actual = c.FirstDayOdYear(DateTimes);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// метод, который позволяет определить сколько дней осталось до конца месяца
        /// </summary>
        [TestMethod]
        public void DaysUntilEndMonth_DeterminingTheDaysUntilTheEndOfTheMonth_ReturnedNumberOfDays()
        {
            //Arrange
            DateTime DateTimes = new DateTime(2022, 1, 1);

            int excepted = 30;
            //Act
            int actual = DateTimeClass.DaysUntilEndMonth(DateTimes);
            //Assert
            Assert.AreEqual(actual, excepted);

        }
        /// <summary>
        /// метод, который позволяет определить что год не високосный
        /// </summary>
        [TestMethod]
        public void LeapYearCheck_ItsNotLeapYear_ReturnedFalse()
        {
            //Arrange
            DateTime DateTimes = new DateTime(2019);

            //Act
            DateTimeClass c = new DateTimeClass();
            bool actual = c.LeapYearCheck(DateTimes);
            //Assert
            Assert.IsFalse(actual);

        }
        

    }
}
