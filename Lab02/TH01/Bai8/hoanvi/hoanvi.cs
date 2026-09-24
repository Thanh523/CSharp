using System;
namespace hoanvisothuc
{
    public class hoanvi
    {
        public static void HoanVi(ref float soThuNhat, ref float soThuHai)
        {
            float tam = soThuNhat;
            soThuNhat = soThuHai;
            soThuHai = tam;
        }
    }

}

