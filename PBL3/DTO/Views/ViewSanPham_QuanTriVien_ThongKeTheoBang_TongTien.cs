using System.ComponentModel;

namespace PBL3
{
    internal class ViewSanPham_QuanTriVien_ThongKeTheoBang_TongTien
    {
        [DisplayName("Mã sản phẩm")]
        public string MaSanPham { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string TenSanPham { get; set; }

        [DisplayName("Tên hãng")]
        public string TenHang { get; set; }

        [DisplayName("Loại sản phẩm")]
        public string LoaiSanPham { get; set; }

        [DisplayName("Tổng tiền nhập hàng")]
        public double TongTienNhap { get; set; }

        [DisplayName("Tổng doanh thu")]
        public double TongDoanhThu { get; set; }
    }
}
