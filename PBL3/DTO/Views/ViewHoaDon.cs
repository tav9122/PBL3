using System;
using System.ComponentModel;

namespace PBL3
{
    internal class ViewHoaDon
    {
        [DisplayName("Mã hoá đơn")]
        public string MaHoaDon { get; set; }

        [DisplayName("Mã nhân viên")]
        public string MaNhanVien { get; set; }

        [DisplayName("Mã khách hàng")]
        public string MaKhachHang { get; set; }

        [DisplayName("Số điện thoại khách hàng")]
        public string SoDienThoai { get; set; }

        [DisplayName("Thời gian giao dịch")]
        public DateTime ThoiGianGiaoDich { get; set; }

        [DisplayName("Thành tiền")]
        public Double ThanhTien { get; set; }
    }
}
