using System;
using System.Collections.Generic;

#nullable disable

namespace HongTam.Models
{
    public partial class Post
    {
        public int Id { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public string TenKhach { get; set; }
        public string DiaChi { get; set; }
        public int? MaDanhMuc { get; set; }
        public string DienTich { get; set; }
        public string HinhAnh { get; set; }
    }
}
