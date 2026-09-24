using System;
using System.Collections.Generic;

namespace Bai17;

public class function
{
    public int[,] SinhNgauNhien(int n, int m)
    {
        if (n <= 0 || m <= 0)
        {
            throw new ArgumentException("So dong va so cot phai lon hon 0.");
        }

        int[,] maTran = new int[n, m];
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                maTran[i, j] = random.Next(10, 101);
            }
        }

        return maTran;
    }

    public void InMaTran(int[,] maTran)
    {
        int soDong = maTran.GetLength(0);
        int soCot = maTran.GetLength(1);

        for (int i = 0; i < soDong; i++)
        {
            for (int j = 0; j < soCot; j++)
            {
                Console.Write($"{maTran[i, j],4}");
            }

            Console.WriteLine();
        }
    }

    public (int[] soChan, int[] soLe) TachChanLe(int[,] maTran)
    {
        List<int> soChan = new List<int>();
        List<int> soLe = new List<int>();

        foreach (int giaTri in maTran)
        {
            if (giaTri % 2 == 0)
            {
                soChan.Add(giaTri);
            }
            else
            {
                soLe.Add(giaTri);
            }
        }

        return (soChan.ToArray(), soLe.ToArray());
    }
}