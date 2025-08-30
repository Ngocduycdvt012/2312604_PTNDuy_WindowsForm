using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_thực_hành_3_2
{
    internal class Cau3
    {
        public static void NoiChuoi(string ho, string ten, ref string s)
        {
            s = ho + ten;
        }
        public static long GiaiThua(int n)
        {
            int ketQua = 1;
            for (int i = n; i >= 1; i--)
            {
                ketQua *= i;
            }
            return ketQua;
        }
    }
}
