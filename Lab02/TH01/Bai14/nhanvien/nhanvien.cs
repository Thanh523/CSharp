using System;
namespace nhanvien
{
    public class nhanvien
    {
        public string hoten = string.Empty;
        public int mucluong;
        public int songayvang;
        public void nhap()
        {
            Console.WriteLine("Nhap vao ten nhan vien: ");
            hoten = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Nhap vao muc luong: ");
            mucluong = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("nhap vao so ngay vang: ");
            songayvang = int.Parse(Console.ReadLine() ?? "0");
        }
        public void xuat()
        {
            Console.WriteLine($"ho ten nhan vien: {hoten} ");
            Console.WriteLine($"luong {mucluong*30-songayvang*100000}");
        }
    }
}