using System;
namespace DiemTrungBinh
{
    class tinhdiemtrungbinh
    {
        static void Main (String[] args)
        {
            int ly;
            int toan;
            int hoa;
            Console.WriteLine("Moi ban nhap diem toan, ly, hoa: ");
            toan = int.Parse(Console.ReadLine());
            ly = int.Parse(Console.ReadLine());
            hoa = int.Parse(Console.ReadLine());
            int dtb;
            dtb = (toan * 2 + ly * 3 + hoa) /6;
            if (dtb >= 8 && dtb <= 10)
            {
                Console.WriteLine($"Ban co diem trung binh {dtb} duoc xep loai gioi");
            }
            if (dtb >= 6.5 && dtb < 8)
            {
                Console.WriteLine($"Ban co diem trung binh {dtb} duoc xep loai kha");
            }
            if (dtb >= 5 && dtb < 6.5)
            {
                Console.WriteLine($"Ban co diem trung binh {dtb} duoc xep loai Trung binh");
            }
            else
            {
                Console.WriteLine($"Ban co diem trung binh {dtb} duoc xep loai yeu");
            }
        }
    }
}