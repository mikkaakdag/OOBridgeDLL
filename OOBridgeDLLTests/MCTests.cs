using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOBridgeDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBridgeDLL.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PrisTestRigtig()
        {
            // Arrange
            var prisTestRigtig = new MC("1A2B3C4", DateTime.Now, false);

            // Act
            double pris = prisTestRigtig.Price();

            // Assert
            Assert.AreEqual(120, pris);
        }

        [TestMethod()]
        public void PrisTestForkert()
        {
            // Arrange
            var prisTestForkert = new MC("1A2B3C4", DateTime.Now, false);

            // Act
            double pris = prisTestForkert.Price();

            // Assert
            Assert.AreNotEqual(50, pris);
        }

        [TestMethod()]
        public void KøretøjTestRigtig()
        {
            // Arrange
            var køretøjTestRigtigt = new MC("1A2B3C4", DateTime.Now, false);

            // Act
            string køretøj = køretøjTestRigtigt.VehicleType();

            // Assert
            Assert.AreEqual("MC", køretøjTestRigtigt.VehicleType());
        }

        [TestMethod()]
        public void KøretøjTestForkert()
        {
            // Arrange
            var køretøjTestForkert = new MC("1A2B3C4", DateTime.Now, false);

            // Act
            string køretøj = køretøjTestForkert.VehicleType();

            // Assert
            Assert.AreNotEqual("Lastbil", køretøjTestForkert.VehicleType());
        }

        [TestMethod()]
        public void LangNummerpladeRigtig()
        {
            // Arrange
            var langNummerpladeRigtig = new MC("1A2B3C4", DateTime.Now, false);

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
            Assert.ThrowsException<ArgumentException>(() => new MC(langNummerpladeForkert, date, false));
        }

        [TestMethod]
        public void MCPrisUdenBrobizz()
        {
            // Arrange
            var MCPrisUdenBrobizz = new MC("1A2B3C4", DateTime.Now, false);

            // Act
            double price = MCPrisUdenBrobizz.Price();

            // Assert
            Assert.AreEqual(120, price, 0.001);
        }

        [TestMethod]
        public void MCPrisMedBrobizz()
        {
            // Arrange
            var MCPrisMedBrobizz = new MC("1A2B3C4", DateTime.Now, true);

            // Act
            double price = MCPrisMedBrobizz.Brobizz();

            // Assert
            Assert.AreEqual(108, price, 0.001); // 125 * 0.9
        }
    }
}