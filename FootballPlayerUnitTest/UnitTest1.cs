using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FootballPlayerTest;
using FootballPlayerUnitTest;

namespace FootballPlayerUnitTest
{
    [TestClass()]
    public class FootballPlayerTests
    {
        [TestMethod()]
        public void NameTest()
        {
            FootballPlayer footballPlayer = new FootballPlayer();
            footballPlayer.Name = "Freja";

            Assert.AreEqual("Freja", footballPlayer.Name);

            Assert.ThrowsException<ArgumentException>(
                () => footballPlayer.Name = "T");
        }

        [TestMethod()]
        public void PriceTest()
        {
            FootballPlayer footballPlayer = new FootballPlayer();
            footballPlayer.Price = 5236520;

            Assert.AreEqual(5236520, footballPlayer.Price);

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => footballPlayer.Price = -650);
        }

        [TestMethod()]
        public void ShirtNumberTest()
        {
            FootballPlayer footballPlayer = new FootballPlayer();
            footballPlayer.shirtNumber = 13;

            Assert.AreEqual(13, footballPlayer.shirtNumber);

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => footballPlayer.shirtNumber = 0);
        }
    }
}