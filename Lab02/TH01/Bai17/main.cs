using System;

namespace Bai17;

public class main
{
    public static void Main()
    {
        Console.Write("Nhap so dong n: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Nhap so cot m: ");
        int m = int.Parse(Console.ReadLine()!);

        function xuLy = new function();
        int[,] maTran = xuLy.SinhNgauNhien(n, m);
        (int[] soChan, int[] soLe) = xuLy.TachChanLe(maTran);

        Console.WriteLine("\nMa tran A:");
        xuLy.InMaTran(maTran);

        Console.WriteLine($"\nMang cac so chan: {string.Join(" ", soChan)}");
        Console.WriteLine($"Mang cac so le: {string.Join(" ", soLe)}");
    }
}