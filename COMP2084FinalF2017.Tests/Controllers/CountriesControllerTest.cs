using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using COMP2084FinalF2017.Models;
using Moq;
using COMP2084FinalF2017.Controllers;
using System.Linq;

namespace COMP2084FinalF2017.Tests.Controllers
{
    [TestClass]
    public class CountriesControllerTest
    {
        CountriesController cont;
        Mock<InterfaceCountries> moc;
        List<Country> countries;

        [TestInitialize]
        public void TestIntialize()
        {
            //Arrange
            moc = new Mock<InterfaceCountries>();
            //mock data
            countries= new List<Country>
            {
                new Country {CountryID = 1, Country1 = "ABC", Gold= 1, Silver = 2, Bronze= 3, TotalMedals=20 , Flag = "abc" },
                new Country {CountryID = 2, Country1 = "DEF", Gold= 4, Silver = 1, Bronze= 6, TotalMedals=45 , Flag = "def" },
                new Country {CountryID = 3, Country1 = "XYZ", Gold= 3, Silver = 0, Bronze= 8, TotalMedals=12 , Flag = "xyz" },
            };
            //add data to mock object
            moc.Setup(m => m.Countries).Returns(countries.AsQueryable());

            cont = new CountriesController(moc.Object);
        }
        [TestMethod]
        public void IndexValidLoadsCountries()
        {
            //Act
            ViewResult results = cont.Index() as ViewResult;
            //Assert
            Assert.IsNotNull(results);
        }
        [TestMethod]
        public void DetailsValidId()
        {
            //Act
            var Act = (Country)cont.Details(3).Model;

            //Assert
            Assert.AreEqual(countries.ToList()[2], Act);
        }
        [TestMethod]
        public void DetailsInvalidId()
        {
            //Act
            ViewResult act = cont.Details(2);

            //Assert
            Assert.AreEqual("Error", act.ViewName);
        }
        [TestMethod]
        public void DetailsNoId()
        {
            //Act
            ViewResult act = cont.Details(null);

            //Assert
            Assert.AreEqual("Error", act.ViewName);
        }
    }
}
