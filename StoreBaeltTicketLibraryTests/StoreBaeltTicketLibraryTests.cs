using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOBridgeDLL;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StoreBaeltTicketLibraryTests
    {
        [TestMethod()]
        public void StorebæltBilLørdagMedBrobizz()
        {
            // Arrange
            var StorebæltBilLørdagMedBrobizz = new StorebeltCar("1A2B3C4", new DateTime(2025, 9, 20), true);

            // Act
            double price = StorebæltBilLørdagMedBrobizz.WeekendBrobizz();

            // Assert
            Assert.AreEqual(175.95, price, 0.001);
        }
        [TestMethod()]
        public void StorebæltBilSøndagMedBrobizz()
        {
            // Arrange
            var StorebæltBilSøndagMedBrobizz = new StorebeltCar("1A2B3C4", new DateTime(2025, 9, 21), true);

            // Act
            double price = StorebæltBilSøndagMedBrobizz.WeekendBrobizz();

            // Assert
            Assert.AreEqual(175.95, price, 0.001);
        }

        [TestMethod()]
        public void StorebæltBilLørdagUdenBrobizz()
        {
            // Arrange
            var StorebæltBilLørdagUdenBrobizz = new StorebeltCar("1A2B3C4", new DateTime(2025, 9, 20), false);

            // Act
            double price = StorebæltBilLørdagUdenBrobizz.WeekendDiscount();

            // Assert
            Assert.AreEqual(195.5, price, 0.001);
        }

        [TestMethod()]
        public void StorebæltBilSøndagUdenBrobizz()
        {
            // Arrange
            var StorebæltBilSøndagUdenBrobizz = new StorebeltCar("1A2B3C4", new DateTime(2025, 9, 21), false);

            // Act
            double price = StorebæltBilSøndagUdenBrobizz.WeekendDiscount();

            // Assert
            Assert.AreEqual(195.5, price, 0.001);
        }

        [TestMethod()]
        public void StorebæltBilHverdagMedBrobizz()
        {
            // Arrange
            var StorebæltBilHverdagMedBrobizz = new StorebeltCar("1A2B3C4", new DateTime(2025, 9, 24), true);

            // Act
            double price = StorebæltBilHverdagMedBrobizz.Brobizz();

            // Assert
            Assert.AreEqual(207, price, 0.001);
        }

        [TestMethod()]
        public void StorebæltBilHverdagUdenBrobizz()
        {
            // Arrange
            var StorebæltBilHverdagUdenBrobizz = new StorebeltCar("1A2B3C4", new DateTime(2025, 9, 24), false);

            // Act
            double price = StorebæltBilHverdagUdenBrobizz.Brobizz();

            // Assert
            Assert.AreEqual(230, price, 0.001);
        }
    }
}