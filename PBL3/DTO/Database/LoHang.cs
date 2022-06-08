using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3
{
    public class LoHang
    {
        [Key]
        [Required]
        [Column("Mã lô hàng")]
        public string MaLoHang { get; set; }

        [Column("Thời gian nhập hàng")]
        public DateTime ThoiGianNhapHang { get; set; }

        [Column("Tổng tiền")]
        public double TongTien { get; set; }

        public virtual ICollection<VatPham> VatPhams { get; set; }

        [Column("Đã xoá")]
        public bool DaXoa { get; set; }
    }
}
