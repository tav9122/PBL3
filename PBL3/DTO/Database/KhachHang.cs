﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3
{
    [Table("Khách hàng")]
    public class KhachHang
    {
        [Key]
        [Required]
        [Column("Mã khách hàng")]
        public string MaKhachHang { get; set; }

        [Column("Tên khách hàng")]
        public string TenKhachHang { get; set; }

        [Column("Địa chỉ")]
        public string DiaChi { get; set; }

        [Column("Số điện thoại")]
        public string SoDienThoai { get; set; }

        [Column("Ghi chú")]
        public string GhiChu { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [DefaultValue("false")]
        [Column("Đã xoá")]
        public bool DaXoa { get; set; }
    }
}
