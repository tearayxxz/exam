using System;

namespace exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            float x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            float x,y,dy, dx,step;
            dx = x2 - x1;
            dy = y2 - y1;
            step = 0;
            if(Math.Abs(dx)>= Math.Abs(dy))
            {
                step = Math.Abs(dx);
                dx = dx /= step;
            }
            else if (Math.Abs(dx) <= Math.Abs(dy))
            {
                step = Math.Abs(dy);
                dy = dy /= step;
            }
            x = x1;
            y = y2;
            for (i = 1; i <= step; i++)
            {
                Console.WriteLine(",",x += dx,y += dy);
            }
        }
    }
}
