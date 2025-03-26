using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.Models;
using BusinessLogic.Services;

namespace BusinessLogicTest
{
    [TestClass]
    public class BallServiceTests
    {
        [TestMethod]
        public void UpdatePosition_ShouldChangeCoordinates()
        {
            // Arrange
            var ball = new Ball { X = 0, Y = 0, VelocityX = 5, VelocityY = 3 };
            var service = new BallService();

            // Act
            service.UpdatePosition(ball);

            // Assert
            Assert.AreEqual(5, ball.X);
            Assert.AreEqual(3, ball.Y);
        }
    }
}