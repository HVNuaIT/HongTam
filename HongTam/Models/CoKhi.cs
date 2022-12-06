using System;
using System.Collections.Generic;

#nullable disable

namespace HongTam.Models
{
    public partial class CoKhi
    {
        public int MaSp { get; set; }
        public string TenSanPham { get; set; }
        public string ThongTin { get; set; }
        public string HinhAnh { get; set; }
        public int? MaDanhMuc { get; set; }
    }
}
