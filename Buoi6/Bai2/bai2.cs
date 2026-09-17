using System;
namespace xulychuso
{
    class xulychuso
    {
        static void Main(String[] args)
        {
            int n;
            int k;
            Console.WriteLine("Moi ban nhap so nguyen n: ");
            n = int.Parse(Console.ReadLine());
            int dem = count(n);
            Console.WriteLine("Moi ban nhap vi tri k: ");
            k = int.Parse(Console.ReadLine());
            chusok(k,n,dem);
            tongle(k,n,dem);
            nhoIlonI(k,n,dem);
        }
        static int count(int n)
        {
            int count = 0;
            int x = n;
            while (x > 0)
            {
                x = x/10;
                count++;
            }
            return count;
        }
        static void chusok(int k, int n, int count)
        {
            int k1 = 0;
            int y = n;
            for (int i = 0; i <= count - k; i++)
            {
                
                k1 = y % 10;
                y = y/10;
            }
            Console.WriteLine($"Chu so o vi tri {k} (tinh tu trai) cua {n} la {k1}");
        }
        static void tongle(int k, int n,int dem)
        {
            int result = 0;
            int temp = n;
            for (int i = 0; i < dem; i++)
            {
                int a = n%10;
                if (a % 2 != 0)
                {
                    result += a;
                }
                n = n/10;
            }
            Console.WriteLine($"Tong cac chu so le cua {temp} la {result}");
        }
        static void nhoIlonI(int k, int n,int dem)
        {
            int temp1 = n;
            double lon = double.NegativeInfinity;
            double nho = double.PositiveInfinity;
            for (int i = 0; i < dem; i++)
            {
                int temp = n%10;
                if (temp % 2 != 0)
                {
                    if (temp < nho) nho = temp;
                    if (temp > lon) lon = temp;
                }
                n = n/10;
            }
            Console.WriteLine($"{temp1} co chu so le nho nhat la {nho} va lon nhat la {lon}");

        }
    }
}