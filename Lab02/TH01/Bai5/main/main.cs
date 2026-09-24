using System;
using ThuVienTinhToan;
namespace main
{
    class Menu
    {
        static void Main(String[] args)
        {
            int chon;
            double x = 0, y = 0;
            do
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x,y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");
                string? luaChon = Console.ReadLine();
                if (luaChon == null)
                {
                    return;
                }

                if (!int.TryParse(luaChon, out chon))
                {
                    Console.WriteLine("Vui long nhap so tu 1 den 4.");
                    continue;
                }

                switch (chon)
                {
                    case 1:
                        Console.Write("Moi ban nhap x: ");
                        if (!double.TryParse(Console.ReadLine(), out x))
                        {
                            Console.WriteLine("Gia tri x khong hop le.");
                            break;
                        }

                        Console.Write("Moi ban nhap y: ");
                        if (!double.TryParse(Console.ReadLine(), out y))
                        {
                            Console.WriteLine("Gia tri y khong hop le.");
                            break;
                        }
                        break;
                    case 2:
                        Console.WriteLine($"{x}^{y} = {tinhtoan.LuyThua(x, y)}");
                        break;
                    case 3:
                        Console.WriteLine($"Can bac hai cua {x} = {tinhtoan.Can(x)}");
                        Console.WriteLine($"Can bac hai cua {y} = {tinhtoan.Can(y)}");
                        break;
                    case 4:
                        Console.WriteLine("Da thoat chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Chuc nang khong hop le.");
                        break;
                }
            }
            while (chon != 4);
        }
    }
}