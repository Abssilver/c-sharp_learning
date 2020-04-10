using System;
using Microsoft.SmallBasic.Library;

namespace TurtleGame
{ 
    /*
     * Игра черепашка. Пользователь управляет черепашкой с помощью стрелочек. Черепашка "съедает" синие квадратики и увеличивает скорость
    */
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();
            GraphicsWindow.BrushColor = "Blue";
            Primitive food = Shapes.AddRectangle(10, 10);
            Random generator = new Random();
            int[] foodPosition = new int[2];
            if (GraphicsWindow.Height > 15 && GraphicsWindow.Width > 15)
            {
                foodPosition[0] = generator.Next(10, GraphicsWindow.Width - 10);
                foodPosition[1] = generator.Next(10, GraphicsWindow.Height - 10);
                Shapes.Move(food, foodPosition[0], foodPosition[1]);
            }
            int eat = 15;
            while (GraphicsWindow.Height > 15 && GraphicsWindow.Width > 15)
            {
                Turtle.Move(10);
                if (System.Math.Abs(foodPosition[0]-Turtle.X)<=eat&&System.Math.Abs(Turtle.Y - foodPosition[1]) <=eat)
                {
                    foodPosition[0]= generator.Next(10, GraphicsWindow.Width-10);
                    foodPosition[1] = generator.Next(10, GraphicsWindow.Height-10);
                    Shapes.Move(food, foodPosition[0], foodPosition[1]);
                    Turtle.Speed++;
                }
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
