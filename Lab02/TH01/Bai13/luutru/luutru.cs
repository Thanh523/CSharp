namespace SinhVienLib
{
    public class SinhVien
    {
        public string MaSV = string.Empty;
        public string HoTen = string.Empty;
        public string DiaChi = string.Empty;
        public int NamThu;

        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Console.ReadLine() ?? string.Empty;

            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine() ?? string.Empty;

            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine() ?? string.Empty;

            Console.Write("Nhap sinh vien nam thu may: ");
            NamThu = int.Parse(Console.ReadLine() ?? "0");
        }

        public void Xuat()
        {
            Console.WriteLine($"Ma SV: {MaSV}");
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Dia chi: {DiaChi}");
            Console.WriteLine($"Sinh vien nam thu: {NamThu}");
        }
    }
}