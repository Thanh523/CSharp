using System;
namespace tongphanso
{
    class tongphanso
    {
        static void Main(String[] args)
        {
            double a;
            double E;
            Console.WriteLine("Moi ban nhap so a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap so epsilon (<= 0.1): ");
            E = double.Parse(Console.ReadLine());
            double result = 0;
            if (E > 0.1)
            {
                Console.Write("nhap sai so epsilon");
            }
            else
            {
                int n = 0;
                double sohang = 1.0 / (a + n);
                while (sohang >= E)
                {
                    result += sohang;
                    n++;
                    sohang = 1.0/(a+n);
                }
                
            Console.WriteLine($"Gia tri cua bieu thuc S(a= {a}a,epsilon = {E} epsilon) = {result}");
            };
            
        }
    }
}