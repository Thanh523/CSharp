using hoanvisothuc;
namespace main
{
    public class main
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap so thuc thu nhat: ");
            float soThuNhat = float.Parse(Console.ReadLine()!);

            Console.Write("Nhap so thuc thu hai: ");
            float soThuHai = float.Parse(Console.ReadLine()!);

            hoanvi.HoanVi(ref soThuNhat, ref soThuHai);

            Console.WriteLine($"Sau khi hoan vi: so thu nhat = {soThuNhat}, so thu hai = {soThuHai}");

        }
    }
}
