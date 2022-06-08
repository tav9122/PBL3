using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3
{
    [Table("Vật phẩm")]
    public class VatPham
    {
        [Key]
        [Column("Số seri")]
        public string SoSeri { get; set; }
        [Column("Mã sản phẩm")]
        public string MaSanPham { get; set; }

        [ForeignKey("MaSanPham")]
        public virtual SanPham SanPham { get; set; }

        [Column("Giá mua")]
        public double GiaMua { get; set; }

        [Column("Giá bán")]
        public double GiaBan { get; set; }

        [Column("Mã hóa đơn")]
        public string MaHoaDon { get; set; }
        [ForeignKey("MaHoaDon")]
        public virtual HoaDon HoaDon { get; set; }

        [Column("Mã lô hàng")]
        public string MaLoHang { get; set; }
        [ForeignKey("MaLoHang")]
        public virtual LoHang LoHang { get; set; }

        [DefaultValue("false")]
        [Column("Đã xoá")]
        public bool DaXoa { get; set; }
    }
}
