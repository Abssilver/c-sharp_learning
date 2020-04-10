using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGame_OOP
{
    class Food
    {
        int m_x, m_y, m_size;
        Primitive m_rect;
        public Food(int size, int x, int y, String color)
        {
            m_x = x;
            m_y = y;
            m_size = size;

            GraphicsWindow.BrushColor = color;

            m_rect = Shapes.AddRectangle(m_size, m_size);
            Shapes.Move(m_rect, m_x, m_y);
        }

        internal bool isStrike(int turtleX, int turtleY)
        {
            if (turtleX >= m_x && turtleX <= m_x + m_size&&
                turtleY >= m_y && turtleY <= m_y + m_size)
            {
                return true;
            }
            return false; 
        }

        internal void MoveToNewPosition()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            m_x = rand.Next(0, GraphicsWindow.Width);
            m_y = rand.Next(0, GraphicsWindow.Height);
            Shapes.Move(m_rect, m_x, m_y);
        }
    }
}
