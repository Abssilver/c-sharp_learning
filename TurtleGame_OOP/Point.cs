using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGame_OOP
{
    class Point
    {
        int m_x;
        int m_y;
        public Point()
        {
            m_x = 0;
            m_y = 0;
        }
        public Point(int x, int y)
        {
            this.m_x = x;
            this.m_y = y;
        }
        internal void Draw()
        {
            Console.SetCursorPosition(m_x, m_y);
            Console.Write('*');
        }
    }
}
