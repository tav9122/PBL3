using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3
{
    [Table("Sản phẩm")]
    public class SanPham
    {
        [Key]
        [Required]
        [Column("Mã sản phẩm")]
        public string MaSanPham { get; set; }

        [Column("Tên sản phẩm")]
        public string TenSanPham { get; set; }

        [Column("Tên hãng")]
        public string TenHang { get; set; }

        [Column("Giá mua")]
        public double GiaMua { get; set; }

        [Column("Loại sản phẩm")]
        public string LoaiSanPham { get; set; }

        [Column("Giá bán")]
        public double GiaBan { get; set; }

        [Column("Số lượng nhập")]
        public int SoLuongNhap { get; set; }

        [Column("Số lượng hiện tại")]
        public int SoLuongHienTai { get; set; }

        [Column("Thời gian bảo hành")]
        public string ThoiGianBaoHanh { get; set; }

        public virtual ICollection<VatPham> VatPhams { get; set; }

        [DefaultValue("false")]
        [Column("Đã xoá")]
        public bool DaXoa { get; set; }
    }
}
