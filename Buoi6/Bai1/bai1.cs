using System;
namespace inhinhivau
{
    class inhinh
    {
        static void Main(String[] args)
        {
            int h;
            Console.WriteLine("Moi ban nhap vao do cao h: ");
            h = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i <= h; i++)
            {
                Console.SetCursorPosition(i,1);
                Console.Write("*");
            }
            for (int i = 2; i <= h - 1; i++)
            {
                Console.SetCursorPosition((h-1)/2, i);
                Console.Write("*");
            }
            for (int i = 0; i <= h; i++)
            {
                Console.SetCursorPosition(i,h);
                Console.Write("*");
            }
            Console.SetCursorPosition(0,h+2);
        }
    }
}
