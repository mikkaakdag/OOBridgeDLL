using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOBridgeDLL;
using Oresundbroen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundbroen.Tests
{
    [TestClass()]
    public class OresundCarTests
    {
        [TestMethod()]
        public void OresundCarPrisUdenBrobizzRigtig()
        {
            // Arrange
            var OresundCarPrisRigtig = new OresundCar("1A2B3C4", DateTime.Now, false);

            // Act
            double price = OresundCarPrisRigtig.Price();

            // Assert
            Assert.AreEqual(460, price);
        }

        [TestMethod()]
        public void OresundCarPrisUdenBrobizzForkert()
        {
            // Arrange
            var OresundCarPrisRigtig = new OresundCar("1A2B3C4", DateTime.Now, false);

            // Act
            double price = OresundCarPrisRigtig.Price();

            // Assert
            Assert.AreNotEqual(1, price);
        }

        [TestMethod()]
        public void OresundCarPrisMedBrobizzRigtig()
        {
            // Arrange
            var OresundCarPrisRigtig = new OresundCar("1A2B3C4", DateTime.Now, true);

            // Act
            double price = OresundCarPrisRigtig.Brobizz();

            // Assert
            Assert.AreEqual(178, price);
        }

        [TestMethod()]
        public void OresundCarPrisMedBrobizzForkert()
        {
            // Arrange
            var OresundCarPrisRigtig = new OresundCar("1A2B3C4", DateTime.Now, true);

            // Act
            double price = OresundCarPrisRigtig.Brobizz();

            // Assert
            Assert.AreNotEqual(1, price);
        }

        [TestMethod()]
        public void OresundMCPrisUdenBrobizzRigtig()
        {
            // Arrange
            var OresundMCPrisUdenBrobizzRigtig = new OresundMC("1A2B3C4", DateTime.Now, false);

            // Act
            double price = OresundMCPrisUdenBrobizzRigtig.Price();

            // Assert
            Assert.AreEqual(235, price);
        }

        [TestMethod()]
        public void OresundMCPrisUdenBrobizzForkert()
        {
            // Arrange
            var OresundMCPrisUdenBrobizzForkert = new OresundMC("1A2B3C4", DateTime.Now, false);

            // Act
            double price = OresundMCPrisUdenBrobizzForkert.Price();

            // Assert
            Assert.AreNotEqual(1, price);
        }

        [TestMethod()]
        public void OresundMCPrisMedBrobizzRigtig()
        {
            // Arrange
            var OresundMCPrisMedBrobizzRigtig = new OresundMC("1A2B3C4", DateTime.Now, true);

            // Act
            double price = OresundMCPrisMedBrobizzRigtig.Brobizz();

            // Assert
            Assert.AreEqual(92, price);
        }

        [TestMethod()]
        public void OresundMCPrisMedBrobizzForkert()
        {
            // Arrange
            var OresundMCPrisMedBrobizzForkert = new OresundMC("1A2B3C4", DateTime.Now, true);

            // Act
            double price = OresundMCPrisMedBrobizzForkert.Brobizz();

            // Assert
            Assert.AreNotEqual(1, price);
        }

        [TestMethod()]
        public void OresundCarTypeRigtig()
        {
            // Arrange
            var OresundCarTypeRigtig = new OresundCar("1A2B3C4", DateTime.Now, true);

            // Act
            string type = OresundCarTypeRigtig.VehicleType();

            // Assert
            Assert.AreEqual("Oresund Car", type);
        }

        [TestMethod()]
        public void OresundCarTypeForkert()
        {
            // Arrange
            var OresundCarTypeForkert = new OresundCar("1A2B3C4", DateTime.Now, true);

            // Act
            string type = OresundCarTypeForkert.VehicleType();

            // Assert
            Assert.AreNotEqual("Oresund MC", type);
        }

        [TestMethod()]
        public void OresundMCTypeRigtig()
        {
            // Arrange
            var OresundMCTypeRigtig = new OresundMC("1A2B3C4", DateTime.Now, true);

            // Act
            string type = OresundMCTypeRigtig.VehicleType();

            // Assert
            Assert.AreEqual("Oresund MC", type);
        }

        [TestMethod()]
        public void OresundMCTypeForkert()
        {
            // Arrange
            var OresundMCTypeForkert = new OresundMC("1A2B3C4", DateTime.Now, true);

            // Act
            string type = OresundMCTypeForkert.VehicleType();

            // Assert
            Assert.AreNotEqual("Oresund Car", type);
        }
    }
}