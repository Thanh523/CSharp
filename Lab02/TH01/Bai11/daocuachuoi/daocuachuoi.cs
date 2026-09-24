using System;
using System.Security.Cryptography.X509Certificates;
namespace daocuachuoi
{
    public class daochuoi
    {
        public static string Daochuoi(string s)
        {
            string kq = "";
            for (int i = s.Length-1; i >= 0; i--)
            {
                kq += s[i];
            }
            return kq;
        }
    }
}