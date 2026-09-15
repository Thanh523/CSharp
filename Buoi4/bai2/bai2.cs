using System;
namespace tiennuoc
{
    class tinhtiennuoc
    {
        static void Main(string[] args)
        {
            int thangtruoc;
            int thangnay;
            Console.WriteLine("Moi ban nhap chi so tieu thu nuoc thang truoc (m^3): ");
            thangtruoc = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap chi so tieu thu nuoc thang nay (m^3): ");
            thangnay= int.Parse(Console.ReadLine());
            int sonuoc;
            sonuoc = thangnay - thangtruoc;
            int sotien = 0;
            for (int i = 1; i <= sonuoc; i++)
            {
                if (i <= 4)
                {
                    sotien = sotien + 4400;
                }
                if (i > 4 && i <= 6)
                {
                    sotien = sotien + 8300;
                }
                if (i > 6)
                {
                    sotien = sotien + 10500;
                }
            }
            Console.WriteLine($"So tien phai tra cho {sonuoc} m^3 tieu thu trong thang la {sotien} Đ");

        }
    }
}