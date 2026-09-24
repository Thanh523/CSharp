using SinhVienLib;

class Program
{
    static void Main()
    {
        SinhVien sv = new SinhVien();

        Console.WriteLine("Nhap thong tin sinh vien:");
        sv.Nhap();

        Console.WriteLine("\nThong tin sinh vien:");
        sv.Xuat();
    }
}