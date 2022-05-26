using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3
{
    [Table("Hoá đơn")]
    public class HoaDon
    {
        [Key]
        [Required]
        [Column("Mã hóa đơn")]
        public string MaHoaDon { get; set; }

        [Column("Mã nhân viên")]
        public string MaNhanVien { get; set; }

        [Column("Mã khách hàng")]
        public string MaKhachHang { get; set; }

        [Column("Thời gian giao dịch")]
        public DateTime ThoiGianGiaoDich { get; set; }


        [ForeignKey("MaNhanVien")]
        public virtual NhanVien NhanVien { get; set; }
        public virtual ICollection<VatPham> VatPhams { get; set; }

        [ForeignKey("MaKhachHang")]
        public virtual KhachHang KhachHang { get; set; }

        [DefaultValue("false")]
        [Column("Đã xoá")]
        public bool DaXoa { get; set; }
    }
}
