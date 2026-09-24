using MyLib1;
namespace Buoi01Prj;
public class GiaiPTBac21
{
    public static void Main(string[] args)
    {
        double x1 = 0, x2=0;
        int sn = LibBaiTap.GiaiPTBac2(1,-3, 2, ref x1, ref x2);
        Console.WriteLine($"So nghiem: {sn}");
        Console.WriteLine($"x1 = {x1}");
        Console.WriteLine($"x2 = {x2}");
        int sn1 = LibBaiTap.GiaiPTBac2(1,-2, 1, ref x1, ref x2);
        Console.WriteLine($"So nghiem: {sn1}");
        Console.WriteLine($"x1 = {x1}");
        Console.WriteLine($"x2 = {x2}");
        int sn2 = LibBaiTap.GiaiPTBac2(1,2, 5, ref x1, ref x2);
        Console.WriteLine($"So nghiem: {sn2}");
        Console.WriteLine($"x1 = {x1}");
        Console.WriteLine($"x2 = {x2}");
        int sn3 = LibBaiTap.GiaiPTBac2(0,2, -4, ref x1, ref x2);
        Console.WriteLine($"So nghiem: {sn3}");
        Console.WriteLine($"x1 = {x1}");
        Console.WriteLine($"x2 = {x2}");
        int sn4 = LibBaiTap.GiaiPTBac2(1,0, -4, ref x1, ref x2);
        Console.WriteLine($"So nghiem: {sn4}");
        Console.WriteLine($"x1 = {x1}");
        Console.WriteLine($"x2 = {x2}");
        int sn5 = LibBaiTap.GiaiPTBac2(1,-3, 0, ref x1, ref x2);
        Console.WriteLine($"So nghiem: {sn5}");
        Console.WriteLine($"x1 = {x1}");
        Console.WriteLine($"x2 = {x2}");
        int sn6 = LibBaiTap.GiaiPTBac2(4,-8, 3, ref x1, ref x2);
        Console.WriteLine($"So nghiem: {sn6}");
        Console.WriteLine($"x1 = {x1}");
        Console.WriteLine($"x2 = {x2}");
      
    }
}