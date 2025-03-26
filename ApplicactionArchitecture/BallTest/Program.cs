using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.Models;

namespace DataTest
{
    [TestClass]
    public class BallTests
    {
        [TestMethod]
        public void Ball_ShouldInitializeWithDefaultDiameter()
        {
            // Arrange & Act
            var ball = new Ball();

            // Assert
            Assert.AreEqual(20, ball.Diameter);
        }
    }
}