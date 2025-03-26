using Data.Models;

namespace BusinessLogic.Services
{
    public class BallService
    {
        public Ball CreateBall(double x, double y)
        {
            return new Ball
            {
                X = x,
                Y = y,
                VelocityX = 0,
                VelocityY = 0
            };
        }

        public void UpdatePosition(Ball ball)
        {
            ball.X += ball.VelocityX;
            ball.Y += ball.VelocityY;
        }

        public void CheckWallCollision(Ball ball, double areaWidth, double areaHeight)
        {
            if (ball.X <= 0 || ball.X + ball.Diameter >= areaWidth) ball.VelocityX *= -1;
            if (ball.Y <= 0 || ball.Y + ball.Diameter >= areaHeight) ball.VelocityY *= -1;
        }
    }
}