using System;
namespace doixung
{
    public class doixung
    {
        public static int kiemtradoixung(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}