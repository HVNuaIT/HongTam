using System;
using System.Collections.Generic;

#nullable disable

namespace HongTam.Models
{
    public partial class TaiKhoan
    {
        public int Id { get; set; }
        public string TaiKhoan1 { get; set; }
        public string MatKhau { get; set; }
        public string TenAdmin { get; set; }
        public string Email { get; set; }
        public string ActiveCode { get; set; }
        public string TrangThai { get; set; }
        public int? SoDienThoai { get; set; }
    }
}
