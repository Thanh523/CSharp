using lonnhonhat;
namespace main
{
    public class main
    {
        static void Main(String[] args)
        {
            float a,b,c;
            Console.WriteLine("Nhap vao ba so thuc: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            Console.WriteLine($"{lonInhoI.lonnhat(a,b,c)}");
            Console.WriteLine($"{lonInhoI.nhonhat(a,b,c)}");
        }
    }
}