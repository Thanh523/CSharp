using System;
namespace tinhxmuy
{
    class nhapxy
    {
        static void Main(String[] args)
        {
            int x,y;
        
            Console.Write("Nhập x: ");
            if (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Lỗi: x phải là số nguyên hợp lệ!");
                return;
            }

            Console.Write("Nhập y: ");
            if (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Lỗi: y phải là số nguyên hợp lệ!");
                return;
            }
            int result = x;
            for (int i = 1; i < y; i++)
            {
                result *= x;
            }
            Console.WriteLine($"Ket qua {x} mu {y} la: {result}");
            
        }
    }
}