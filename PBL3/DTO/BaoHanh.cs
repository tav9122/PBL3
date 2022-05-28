using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3
{
    [Table("Bảo hành")]
    public class BaoHanh
    {
        [Column("Số seri")]
        [Key]
        [Required]
        public string SoSeri { get; set; }

        [Column("Trạng thái")]
        public bool TrangThai { get; set; }

        [Column("Ghi chú")]
        public string GhiChu { get; set; }

        [Column("Thời gian tạo phiếu bảo hành")]
        public DateTime ThoiGianTaoPhieuBaoHanh { get; set; }
        
        [Column("Chủ sở hữu")]
        public string MaKhachHang { get; set; }

        [ForeignKey("SoSeri")]
        public virtual VatPham VatPham { get; set; }
        
        [ForeignKey("MaKhachHang")]
        public virtual KhachHang KhachHang { get; set; } 

        [DefaultValue("false")]
        [Column("Đã xoá")]
        public bool DaXoa { get; set; }
    }
}
