using System;
namespace giatrilonnhat
{
    public static class lonnhat
    {
        public static double lonI(ref int x,ref int y,ref int z)
        {
            double max = x;

            if (y > max)
                max = y;

            if (z > max)
                max = z;

            return max;
        }
    }
}