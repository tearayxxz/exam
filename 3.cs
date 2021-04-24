using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            float flimbackwidth;
            Console.Write("Input a : ");
            flimbackwidth= float.Parse(Console.ReadLine());
            float mode =0;
            double flenght = 0, fov = 0;
            if (flimbackwidth > 0)
            {
                if (mode == flenght)
                {
                    Console.Write("Input a : ");
                    flenght = float.Parse(Console.ReadLine());
                    if (flenght > 0)
                    {
                        fov = 2*Math.Atan(flimbackwidth/(2*flenght));
                    }
                    else
                    {
                        Console.WriteLine("Invlid flenght. Please input again");
                    }
                }
                else if (mode == fov)
                {
                    Console.Write("Input a : ");
                    fov = float.Parse(Console.ReadLine());
                    if (fov > 0.1 && fov < 6.28)
                    {
                        flenght = flimbackwidth / (2 * Math.Tan(fov / 2));
                    }
                    else
                    {
                        Console.WriteLine("Invlid fov. Please input again");
                    }
                }
                Console.WriteLine("fleght = {0}",flenght,"fov = ",fov);
            }
            else if (flimbackwidth <= 0)
            {
                Console.WriteLine("Invlid flimbackwidth. Please input again");
            }
        }
    }
}
