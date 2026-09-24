using System;
using bai12;
namespace kytu
{
    public class KyTu
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot chuoi gom nhieu tu:");
            string chuoi = Console.ReadLine() ?? string.Empty;

            Console.WriteLine($"Chuoi thuong: {XuLyChuoi.ChuThuong(chuoi)}");
            Console.WriteLine($"Chuoi hoa: {XuLyChuoi.ChuHoa(chuoi)}");
            Console.WriteLine($"So tu trong chuoi: {XuLyChuoi.DemSoTu(chuoi)}");
        }
    }
}

