using Microsoft.SmallBasic.Library;

namespace TurtleTrainingNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 5;
            TurtleShift(200, 200);
            LetterT(60);
            TurtleShift(230,200);
            LetterO(40);
            TurtleShift(280, 200);
            LetterP(40);
            TurtleShift(330, 200);
            LetterT(40);
            TurtleShift(200, 300);
            LetterL(60);
            TurtleShift(240, 300);
            LetterI(40);
            TurtleShift(275, 300);
            LetterZ(40);
            TurtleShift(310, 300);
            LetterA(40);



            /*
            SnakeLikeMoving(3, 25);
            HexagonMoving(40);
            */
        }
        static void TurtleShift(int x, int y)
        {
            Turtle.X = x;
            Turtle.Y = y;
        }

        static void LetterT(int scale)
        {
            Turtle.Angle = 0;
            Turtle.Move(scale);
            TurtleShift(Turtle.X - scale / 4, Turtle.Y);
            Turtle.Angle = 90;
            Turtle.Move(scale / 2);
        }
        static void LetterO(int scale)
        {
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(i==0||i==2?scale:2*scale/3);
                Turtle.TurnRight();
            }
        }
        static void LetterP(int scale)
        {
            Turtle.Angle = 0;
            Turtle.Move(scale / 2);
            LetterO(scale / 2);
        }
        static void LetterL(int scale)
        {
            Turtle.MoveTo(Turtle.X + scale / 2, Turtle.Y-scale);
            Turtle.Angle = 180;
            Turtle.Move(scale);
        }
        static void LetterI(int scale)
        {
            TurtleShift(Turtle.X, Turtle.Y - scale);
            Turtle.Angle = 180;
            Turtle.Move(scale);
            LetterL(scale);
        }
        static void LetterZ(int scale)
        {
            Turtle.Angle = 90;
            Turtle.Move(scale / 3);
            Turtle.Angle = 45;
            Turtle.Move(scale / 7);
            Turtle.Angle = 0;
            Turtle.Move(scale / 3);
            Turtle.Angle = -45;
            Turtle.Move(scale / 7);
            int[] position = new int[] { Turtle.X, Turtle.Y };
            Turtle.Angle = -90;
            Turtle.Move(scale / 4);
            TurtleShift(position[0], position[1]);
            Turtle.Angle = 45;
            Turtle.Move(scale / 7);
            Turtle.Angle = 0;
            Turtle.Move(scale / 3);
            Turtle.Angle = -45;
            Turtle.Move(scale / 7);
            Turtle.Angle = -90;
            Turtle.Move(scale / 3);
        }
        static void LetterA(int scale)
        {
            int[] position = new int[2];
            Turtle.MoveTo(Turtle.X, Turtle.Y - 3 * scale / 4);
            position[0] = Turtle.X;
            Turtle.MoveTo(Turtle.X + scale / 6, Turtle.Y - scale / 4);
            Turtle.MoveTo(Turtle.X + scale / 3, Turtle.Y);
            Turtle.MoveTo(Turtle.X + scale / 6, Turtle.Y + scale / 4);
            position[1] = Turtle.X;
            Turtle.MoveTo(Turtle.X, Turtle.Y + 3 * scale / 4);
            TurtleShift(position[0], Turtle.Y - scale / 3);
            Turtle.MoveTo(position[1], Turtle.Y);
        }
        static void SnakeLikeMoving(int length, int scale)
        {
            int angle;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    angle = j > 1 ? - 90 : 90;
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
