using System;
using System.ComponentModel;

namespace PBL3
{
    public class ViewNhanVien
    {
        [DisplayName("Mã nhân viên")]
        public string MaNhanVien { get; set; }

        [DisplayName("Họ và tên")]
        public string HoVaTen { get; set; }

        [DisplayName("Số điện thoại")]
        public string SoDienThoai { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; }

        [DisplayName("Ngày sinh")]
        public DateTime NgaySinh { get; set; }

        [DisplayName("Giới tính")]
        public bool GioiTinh { get; set; }

        [DisplayName("Ngày bắt đầu làm việc")]
        public DateTime NgayBatDauLamViec { get; set; }

        [DisplayName("Mức lương")]
        public double MucLuong { get; set; }

        [DisplayName("Tên đăng nhập")]
        public string TenDangNhap { get; set; }

        [DisplayName("Lịch làm việc")]
        public string LichLamViecs { get; set; }

    }
}
