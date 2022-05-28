using System.ComponentModel;

namespace PBL3
{
    internal class ViewVatPham
    {
        [DisplayName("Số Seri")]
        public int SoSeri { get; set; }

        [DisplayName("Mã sản phẩm")]
        public string MaSanPham { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string TenSanPham { get; set; }
        
        [DisplayName("Đơn giá")]
        public double GiaBan { get; set; }

        [DisplayName("Mã hoá đơn")]
        public string MaHoaDon { get; set; }
    }
}
