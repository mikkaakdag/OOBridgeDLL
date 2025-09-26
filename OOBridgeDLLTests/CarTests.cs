using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOBridgeDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOBridgeDLL.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PrisTestRigtig()
        {
            // Arrange
            var prisTestRigtig = new Car("1A2B3C4", DateTime.Now, false);

            // Act
            double pris = prisTestRigtig.Price();

            // Assert
            Assert.AreEqual(230, pris);
        }

        [TestMethod()]
        public void PrisTestForkert()
        {
            // Arrange
            var prisTestForkert = new Car("1A2B3C4", DateTime.Now, false);

            // Act
            double pris = prisTestForkert.Price();

            // Assert
            Assert.AreNotEqual(100, pris);
        }

        [TestMethod()]
        public void KøretøjTestRigtig()
        {
            // Arrange
            var køretøjTestRigtigt = new Car("1A2B3C4", DateTime.Now, false);

            // Act
            string køretøj = køretøjTestRigtigt.VehicleType();

            // Assert
            Assert.AreEqual("Car", køretøjTestRigtigt.VehicleType());
        }

        [TestMethod()]
        public void KøretøjTestForkert()
        {
            // Arrange
            var køretøjTestForkert = new Car("1A2B3C4", DateTime.Now, false);

            // Act
            string køretøj = køretøjTestForkert.VehicleType();

            // Assert
            Assert.AreNotEqual("Motorcykel", køretøjTestForkert.VehicleType());
        }

        [TestMethod()]
        public void LangNummerpladeRigtig()
        {
            // Arrange
            var langNummerpladeRigtig = new Car("1A2B3C4", DateTime.Now, false);

            // Act
            string køretøj = langNummerpladeRigtig.LicensePlate;

            // Assert
            Assert.AreEqual("1A2B3C4", langNummerpladeRigtig.LicensePlate);
        }

        [TestMethod()]
        public void LangNummerpladeForkert()
        {
            // Arrange
            string langNummerpladeForkert = "1A2B3C4D";
            DateTime date = DateTime.Now;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Car(langNummerpladeForkert, date, false));
        }

        [TestMethod]
        public void BilPrisUdenBrobizz()
        {
            // Arrange
            var BilPrisUdenBrobizz = new Car("1A2B3C4", DateTime.Now, false);

            // Act
            double price = BilPrisUdenBrobizz.Price();

            // Assert
            Assert.AreEqual(230, price, 0.001);
        }

        [TestMethod]
        public void BilPrisMedBrobizz()
        {
            // Arrange
            var BilPrisMedBrobizz = new Car("1A2B3C4", DateTime.Now, true);

            // Act
            double price = BilPrisMedBrobizz.Brobizz();

            // Assert
            Assert.AreEqual(207, price);
        }
    }
}