using System;
using System.Collections;
using sapxep;
namespace function
{
    public class chucnang
    {
        int n;
        ArrayList user = new ArrayList();
        public void input()
        {
            Console.WriteLine("Nhap vao so nguoi dung muon nhap vao: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten tung nguoi dung: ");
            for (int i = 0;i < n; i++)
            {
                user.Add(Console.ReadLine());
            }
        }
        public void output()
        {
            sapxep.sapxep.sort(user);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{user[i]}");
            }
        }
    }
}