using doixung;
namespace main
{
    public class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao chuoi: ");
            string s = Console.ReadLine()!;
            if (doixung.doixung.kiemtradoixung(s) == 0)
            {
                Console.WriteLine("n doi xung");
            }
            else
            {
                Console.WriteLine("n khong doi xung ");
            }
        }
    }
}