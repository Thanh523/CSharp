using System;
using giatrilonnhat;
namespace tragiatri
{
    public class tragiatri1
    {
        static void Main(string[] args)
        {
            int x,y,z;
            Console.WriteLine("Nhap vao 3 so nguyen: ");
            if (!int.TryParse(Console.ReadLine(), out x) ||
                !int.TryParse(Console.ReadLine(), out y) ||
                !int.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine("Vui long nhap dung 3 so nguyen.");
                return;
            }

            Console.WriteLine($"So nguyen lon nhat la {lonnhat.lonI(ref x,ref y,ref z)}");
        }
    }
}