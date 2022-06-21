using System.ComponentModel;

namespace PBL3
{
    internal class ViewSanPham_QuanTriVien_ThongKeTheoBang_SoLuong
    {
        [DisplayName("Mã sản phẩm")]
        public string MaSanPham { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string TenSanPham { get; set; }

        [DisplayName("Tên hãng")]
        public string TenHang { get; set; }

        [DisplayName("Loại sản phẩm")]
        public string LoaiSanPham { get; set; }

        [DisplayName("Số lượng nhập")]
        public int SoLuongNhap { get; set; }

        [DisplayName("Số lượng bán")]
        public int SoLuongBan { get; set; }
    }
}
