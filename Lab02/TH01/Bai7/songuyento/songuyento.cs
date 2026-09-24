using System;
namespace songuyento
{
    public class kiemtrasonguyento
    {
        public static bool songuyento(int x)
        {
            int d = 0;
            for (int i = 1; i <= x; i++)
            {   
                if (x%i == 0)
                {
                    d++;
                }   
            }
            if (d ==2) return true;
            else return false;
        }
    }
}