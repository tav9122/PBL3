using System.ComponentModel;

namespace PBL3
{
    public class ViewSanPham_QuanTriVien
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

        [DisplayName("Giá mua")]
        public double GiaMua { get; set; }

        [DisplayName("Giá bán")]
        public double GiaBan { get; set; }

        [DisplayName("Số lượng nhập")]
        public int SoLuongNhap { get; set; }

        [DisplayName("Số lượng hiện tại")]
        public int SoLuongHienTai { get; set; }
    }
}
