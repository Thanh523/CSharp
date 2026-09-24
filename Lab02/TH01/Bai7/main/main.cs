using songuyento;
using System;
namespace main
{
    public class songuyento
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Nhap vao 1 so: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine($"{kiemtrasonguyento.songuyento(x)}");    
        }
        
    }
}