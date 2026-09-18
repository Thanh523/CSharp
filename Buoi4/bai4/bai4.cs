using System;
namespace phanloaitamgiac
{
    class tamgiac
    {
        static void Main(string[] args)
        {
            double a,b,c;
            Console.WriteLine("Moi ban nhap ba so thuc a,b,c: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            String kq = " ";
            if (a == b && b == c)
            {
                kq += "deu";
            }
            else if ((a*a == b*b + c*c || b*b == a*a + c*c || c*c == a*a + b * b) && (a == b || b == c || c == a))
            {
                kq += "vuong can";
            }
            else if (a*a == b*b + c*c || b*b == a*a + c*c || c*c == a*a + b * b)
            {
                kq += "vuong";
            }
            else if (a == b || b == c || c == a)
            {
                kq += "can";
            }
            else
            {
                kq += "thuong";
            }
            Console.WriteLine($"Tam giac tao thanh la tam giac{kq}");
        }
    }
}