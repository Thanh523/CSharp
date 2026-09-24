using System;
namespace tinhxmuy
{
    class nhapxy
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen y: ");
            int y = int.Parse(Console.ReadLine());
            int result = x;
            for (int i = 1; i < y; i++)
            {
                result *= x;
            }
            Console.WriteLine($"Ket qua {x} mu {y} la: {result}");
            
        }
    }
}