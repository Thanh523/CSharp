using System;
namespace lonnhonhat
{
    public class lonInhoI
    {
        public static float lonnhat(float a, float b, float c)
        {
            
            float lonnhat = float.NegativeInfinity;
            if (a > lonnhat)
            {
                lonnhat = a;
                if (b > lonnhat) lonnhat = b;
                if (c > lonnhat) lonnhat = c;
            }
            return lonnhat;
        }
        public static float nhonhat(float a, float b,float c)
        {
            float nhonhat = float.PositiveInfinity;
            if (a < nhonhat)
            {
                nhonhat = a;
                if (b < nhonhat) nhonhat = b;
                if (c < nhonhat) nhonhat = c;
            }
            return nhonhat;
        }
    }
}