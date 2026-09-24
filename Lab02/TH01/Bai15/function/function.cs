using System;
using songuyento;
using System.Collections;

namespace function
{
    public class chucnang
    {
        public int n { get; set; }
        public ArrayList a { get; set; } = new ArrayList();

        public void input()
        {
            Console.WriteLine("Nhap vao so phan tu muon nhap: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao cac phan tu: ");
            for (int i = 0; i < n; i++)
            {
                a.Add(double.Parse(Console.ReadLine()));
            }
        }

        public void output()
        {
            Console.WriteLine("Mang co cac phan tu: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }

        public void lonInhoI()
        {
            double max = double.NegativeInfinity;
            double min = double.PositiveInfinity;

            for (int i = 0; i < n; i++)
            {
                double x = (double)a[i];
                if (x > max)
                {
                    max = x;
                }
                if (x < min)
                {
                    min = x;
                }
            }

            Console.WriteLine($"Gia tri lon nhat trong mang la: {max}");
            Console.WriteLine($"Gia tri be nhat trong mang la: {min}");
        }

        public void phantulasonguyento()
        {
            ArrayList kq = new ArrayList();

            for (int i = 0; i < n; i++)
            {
                double x = (double)a[i];
                int value = (int)x;

                if (Songuyento.LaSoNguyenTo(value) && value == x)
                {
                    kq.Add(x);
                }
            }

            Console.WriteLine("Cac phan tu la so nguyen to: ");
            foreach (var item in kq)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}