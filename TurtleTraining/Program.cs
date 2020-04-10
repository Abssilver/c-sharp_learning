using Microsoft.SmallBasic.Library;

namespace TurtleTrainingNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 5;
            SnakeLikeMoving(3, 25);
            HexagonMoving(40);
        }
        static void SnakeLikeMoving(int length, int scale)
        {
            int angle;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    angle = j > 1 ? -90 : 90;
                    Turtle.Move(scale);
                    Turtle.Turn(angle);
                }
            }
        }
        static void HexagonMoving(int scale)
        {
            for (int i = 0; i < 6; i++)
            {
                Turtle.Move(scale);
                Turtle.Turn(60);
            }
        }
    }
}
