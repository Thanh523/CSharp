using System;

namespace phantichthuasonguyento
{
    class phantich
    {
        static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            int nGoc = n;
            int i = 2;

            Console.Write(nGoc + " = ");

            while (n > 1)
            {
                if (SNT(i) == 0 && n % i == 0)
                {
                    Console.Write(i + "x");
                    n = n / i;
                }
                else
                {
                    i++;
                }
            }
        }

        // Trả về 0 nếu k là số nguyên tố
        static int SNT(int k)
        {
            if (k < 2)
                return 1;

            for (int i = 2; i * i <= k; i++)
            {
                if (k % i == 0)
                    return 1; // không phải SNT
            }

            return 0; // là SNT
        }
    }
}