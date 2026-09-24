using System;
namespace kiemtrasohoanhao
{
    class sohoanhao
    {
        static void Main(string[] args)
        {
            int n;
            int result = 0;
            Console.WriteLine("Moi ban nhap n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i%2 == 0)
                {
                    result += i;
                }
            }
            if (n == result)
            {
                Console.Write($"{n} la so hoan hao");
            }
            else
            {
                Console.WriteLine($"{n} khong la so hoan hao");
            }
        }
    }
}