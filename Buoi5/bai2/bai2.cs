using System;
namespace bieuthuc
{
    class giatribieuthuc
    {
        static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Moi ban nhap so nguyen n: ");
            n = int.Parse(Console.ReadLine());
            double s1 = 0;
            double s2 = 1/n;
            for (int i = 1; i <= n; i++)
            {
                s1 = s1+(1.0/i);
            }
            for (int i = 0; i < n; i++)
            {
                if(i % 2 == 0)
                {
                    s2 = s2 + (1.0/(n-i));
                }
                else
                {
                    s2 = s2 - (1.0/(n-i));
                }
                
            }
            Console.WriteLine($"S1(n=?n) = {s1}");
            Console.WriteLine($"S2(n=?n) = {s2}");
        }
    }
}