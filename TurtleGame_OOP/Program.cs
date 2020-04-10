using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGame_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Food food = new Food(20, 320, 220, "Red");
            Turtle.PenUp();
            while (true)
            {
                Turtle.Move(20);
                if (food.isStrike(Turtle.X, Turtle.Y))
                    food.MoveToNewPosition();
                if (Turtle.X > GraphicsWindow.Width)
                    Turtle.X = 0;
                else if (Turtle.X < 0)
                    Turtle.X = GraphicsWindow.Width;
                else if (Turtle.Y > GraphicsWindow.Height)
                    Turtle.Y = 0;
                else if (Turtle.Y < 0)
                    Turtle.Y = GraphicsWindow.Height;
            }
        }

        private static void GraphicsWindow_KeyDown()
        {
            string direction = GraphicsWindow.LastKey;
            switch (direction)
            {
                case "Up":
                    Turtle.Angle = 0;
                    break;
                case "Right":
                    Turtle.Angle = 90;
                    break;
                case "Left":
                    Turtle.Angle = -90;
                    break;
                case "Down":
                    Turtle.Angle = 180;
                    break;
                default:
                    break;
            }
        }
    }
}
