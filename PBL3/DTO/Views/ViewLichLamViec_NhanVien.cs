using System.ComponentModel;

namespace PBL3
{
    internal class ViewLichLamViec_NhanVien
    {
        [DisplayName("Mã lịch làm việc")]
        public string MaLichLamViec { get; set; }

        [DisplayName("Thời gian bắt đầu")]
        public string ThoiGianBatDau { get; set; }

        [DisplayName("Thời gian kết thúc")]
        public string ThoiGianKetThuc { get; set; }

        [DisplayName("Ngày làm việc")]
        public string NgayLamViec { get; set; }
    }
}
