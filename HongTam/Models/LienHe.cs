using System;
using System.Collections.Generic;

#nullable disable

namespace HongTam.Models
{
    public partial class LienHe
    {
        public int MaLienHe { get; set; }
        public string TenKhachHang { get; set; }
        public int? SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string LoiNhan { get; set; }
        public string Email { get; set; }
    }
}
