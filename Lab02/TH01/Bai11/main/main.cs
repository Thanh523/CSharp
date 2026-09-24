using daocuachuoi;
namespace main
{
    public class Menu
    {
        public static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Nhap vao mot chuoi: ");
            s = Console.ReadLine();
            Console.WriteLine($"{daochuoi.Daochuoi(s)}");
        }
    }
}