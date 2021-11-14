using IntrepidProducts.ElevatorSystem.Elevators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntrepidProducts.ElevatorSystem.Tests
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void ShouldKeepElevatorCount()
        {
            var bank = new Bank();
            Assert.AreEqual(0, bank.NumberOfElevators);

            bank.Add(new Elevator(), new Elevator());
            Assert.AreEqual(2, bank.NumberOfElevators);
        }

        [TestMethod]
        public void ShouldOnlyAcceptUniqueElevators()
        {
            var e1 = new Elevator();
            var dup = e1;

            var e2 = new Elevator();
            var e3 = new Elevator();

            var elevatorBank = new Bank();

            Assert.IsTrue(elevatorBank.Add(e1));
            Assert.IsFalse(elevatorBank.Add(dup));

            Assert.IsTrue(elevatorBank.Add(e2));
            Assert.IsTrue(elevatorBank.Add(e3));

            Assert.AreEqual(3, elevatorBank.NumberOfElevators);
        }

        [TestMethod]
        public void ShouldOnlyAcceptCollectionOfElevatorsWhenValid()
        {
            var e1 = new Elevator();
            var dup1 = e1;

            var e2 = new Elevator();
            var e3 = new Elevator();

            var elevatorBank = new Bank();

            Assert.IsFalse(elevatorBank.Add(e1, dup1, e2, e3));
            Assert.AreEqual(0, elevatorBank.NumberOfElevators);    //Entire collection rejected

            Assert.IsTrue(elevatorBank.Add(e1, e2, e3));
            Assert.AreEqual(3, elevatorBank.NumberOfElevators);
        }
    }
}