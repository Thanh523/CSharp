using System;
using System.Collections;
namespace sapxep
{
    public class sapxep
    {
        public static void sort(ArrayList a)
        {
            a.Sort(StringComparer.Create(new System.Globalization.CultureInfo("vi-VN"), true));

        }
    }
}