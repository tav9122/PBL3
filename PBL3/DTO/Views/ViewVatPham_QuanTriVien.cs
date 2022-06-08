using System.ComponentModel;

namespace PBL3
{
    internal class ViewVatPham_QuanTriVien
    {
        [DisplayName("Số Seri")]
        public string SoSeri { get; set; }

        [DisplayName("Mã sản phẩm")]
        public string MaSanPham { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string TenSanPham { get; set; }

        [DisplayName("Tên hãng")]
        public string TenHang { get; set; }

        [DisplayName("Loại sản phẩm")]
        public string LoaiSanPham { get; set; }

        [DisplayName("Giá mua")]
        public double GiaMua { get; set; }
    }
}
