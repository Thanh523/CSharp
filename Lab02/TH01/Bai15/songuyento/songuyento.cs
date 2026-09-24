using System;

namespace songuyento
{
    public class Songuyento
    {
        public static bool LaSoNguyenTo(int x)
        {
            if (x < 2)
                return false;

            int d = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                    d++;
            }

            return d == 2;
        }
    }
}