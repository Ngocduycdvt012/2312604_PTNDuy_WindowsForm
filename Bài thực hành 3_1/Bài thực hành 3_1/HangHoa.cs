﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_thực_hành_3_1
{
    internal class HangHoa
    {
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string DVT { get; set; }
        public int SoLuong { get; set; }
        
        public int DonGia { get; set; }

        public HangHoa()
        {
            
        }

        public string HienThi()
        {
            return string.Format("{0},{1},{2},{3},{4}", MaHH, TenHH, DVT, SoLuong, DonGia);
        }



    }
}
