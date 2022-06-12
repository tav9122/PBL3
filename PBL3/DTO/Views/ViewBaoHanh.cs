using System;
using System.ComponentModel;

namespace PBL3
{
    internal class ViewBaoHanh
    {
        [DisplayName("Mã bảo hành")]
        public string MaBaoHanh { get; set; }

        [DisplayName("Số seri")]
        public string SoSeri { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string TenSanPham { get; set; }

        [DisplayName("Trạng thái")]
        public bool TrangThai { get; set; }

        [DisplayName("Ghi chú")]
        public string GhiChu { get; set; }

        [DisplayName("Thời gian tạo phiếu bảo hành")]
        public DateTime ThoiGianTaoPhieuBaoHanh { get; set; }

        [DisplayName("Tên khách hàng")]
        public string TenKhachHang { get; set; }

        [DisplayName("Số điện thoại khách hàng")]
        public string SoDienThoai { get; set; }
    }
}
