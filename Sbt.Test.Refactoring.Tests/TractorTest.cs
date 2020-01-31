using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sbt.Test.Refactoring.Base;
using Sbt.Test.Refactoring.Exceptions;
using Sbt.Test.Refactoring.GameObjects;
using Sbt.Test.Refactoring.Tests.Helpers;
using System.Collections.Generic;

namespace Sbt.Test.Refactoring.Tests
{
    [TestClass]
    public class TractorTest
    {
        [TestMethod]
        public void TestShouldMoveForward()
        {
            Tractor tractor = Helper.GetTractor();
            
            tractor.Move("F");
            Assert.AreEqual(0, tractor.GetPositionX());
            Assert.AreEqual(1, tractor.GetPositionY());
        }

        [TestMethod]
        public void TestShouldTurn()
        {
            Tractor tractor = Helper.GetTractor();

            tractor.Move("T");
            Assert.AreEqual(Orientation.East, tractor.Orientation);

            tractor.Move("T");
            Assert.AreEqual(Orientation.South, tractor.Orientation);

            tractor.Move("T");
            Assert.AreEqual(Orientation.West, tractor.Orientation);

            tractor.Move("T");
            Assert.AreEqual(Orientation.North, tractor.Orientation);
        }

        [TestMethod]
        public void TestShouldTurnAndMoveInTheRightDirection()
        {
            Tractor tractor = Helper.GetTractor();

            tractor.Move("T");
            tractor.Move("F");
            Assert.AreEqual(1, tractor.GetPositionX());
            Assert.AreEqual(0, tractor.GetPositionY());

            tractor.Move("T");
            tractor.Move("F");
            Assert.AreEqual(1, tractor.GetPositionX());
            Assert.AreEqual(-1, tractor.GetPositionY());

            tractor.Move("T");
            tractor.Move("F");
            Assert.AreEqual(0, tractor.GetPositionX());
            Assert.AreEqual(-1, tractor.GetPositionY());

            tractor.Move("T");
            tractor.Move("F");
            Assert.AreEqual(0, tractor.GetPositionX());
            Assert.AreEqual(0, tractor.GetPositionY());
        }

        [TestMethod]
        public void TestShouldThrowExceptionIfFallsOffPlateau()
        {
            Tractor tractor = Helper.GetTractor();

            tractor.Move("F");
            tractor.Move("F");
            tractor.Move("F");
            tractor.Move("F");
            tractor.Move("F");

            try
            {
                tractor.Move("F");
                Assert.Fail("Tractor was expected to fall off the plateau");
            }
            catch (OutsideMoveException ex)
            {
            }
        }

        [TestMethod]
        public void TestShouldExecuteMoveInCollection()
        {
            Tractor tractor = Helper.GetTractor();
            Wind wind = new Wind(Orientation.North);
            Stone stone = new Stone(new Point(0, 0), new Size(5, 5));
            var gameObjectCollection = new List<GameObject> { tractor, wind, stone };
            foreach (var gameObject in gameObjectCollection)
            {
                gameObject.Move("T"); 
                gameObject.Move("F");
            }
            Assert.AreEqual(1, tractor.GetPositionX());
            Assert.AreEqual(0, tractor.GetPositionY());
            Assert.AreEqual(Orientation.East, tractor.Orientation);
            Assert.AreEqual(Orientation.East, wind.Orientation);
            Assert.AreEqual(0, stone.GetPositionX());
            Assert.AreEqual(0, stone.GetPositionY());

        }
    }
}
