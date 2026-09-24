using System;
namespace chucnang
{
    public delegate int SoSanh<T>(T a, T b);

    public class chucnang
    {
        public void SapXep<T>(T[] mang, SoSanh<T> soSanh)
        {
            for (int i = 0; i < mang.Length - 1; i++)
            {
                for (int j = i + 1; j < mang.Length; j++)
                {
                    if (soSanh(mang[i], mang[j]) > 0)
                    {
                        (mang[i], mang[j]) = (mang[j], mang[i]);
                    }
                }
            }
        }
    }
}