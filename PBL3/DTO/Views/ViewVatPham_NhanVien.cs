using System.ComponentModel;

namespace PBL3
{
    internal class ViewVatPham_NhanVien
    {
        [DisplayName("Số Seri")]
        public string SoSeri { get; set; }

        [DisplayName("Mã sản phẩm")]
        public string MaSanPham { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string TenSanPham { get; set; }

        [DisplayName("Đơn giá")]
        public double GiaBan { get; set; }
    }
}
