using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3
{
    [Table("Bảo hành")]
    public class BaoHanh
    {
        [Column("Mã bảo hành")]
        [Key]
        [Required]
        public string MaBaoHanh { get; set; }

        [Column("Số seri")]
        public string SoSeri { get; set; }

        [Column("Trạng thái")]
        public bool TrangThai { get; set; }

        [Column("Ghi chú")]
        public string GhiChu { get; set; }

        [Column("Thời gian tạo phiếu bảo hành")]
        public DateTime ThoiGianTaoPhieuBaoHanh { get; set; }

        [ForeignKey("SoSeri")]
        public virtual VatPham VatPham { get; set; }

        [DefaultValue("false")]
        [Column("Đã xoá")]
        public bool DaXoa { get; set; }
    }
}
