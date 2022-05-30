using System.ComponentModel;

namespace PBL3
{
    internal class ViewSanPham_NhanVien
    {
        [DisplayName("Mã sản phẩm")]
        public string MaSanPham { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string TenSanPham { get; set; }

        [DisplayName("Tên hãng")]
        public string TenHang { get; set; }

        [DisplayName("Loại sản phẩm")]
        public string LoaiSanPham { get; set; }

        [DisplayName("Thời gian bảo hành")]
        public string ThoiGianBaoHanh { get; set; }

        [DisplayName("Giá bán")]
        public double GiaBan { get; set; }

        [DisplayName("Số lượng hiện tại")]
        public int SoLuongHienTai { get; set; }

        [DisplayName("Số lượng trong túi hàng")]
        public int SoLuongTrongTuiHang { get; set; }
    }
}
