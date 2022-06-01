using System.ComponentModel;

namespace PBL3
{
    public class ViewLichLamViec
    {
        [DisplayName("Mã lịch làm việc")]
        public string MaLichLamViec { get; set; }

        [DisplayName("Thời gian bắt đầu")]
        public string ThoiGianBatDau { get; set; }

        [DisplayName("Thời gian kết thúc")]
        public string ThoiGianKetThuc { get; set; }

        [DisplayName("Ngày làm việc")]
        public string NgayLamViec { get; set; }

        [DisplayName("Nhân viên trong lịch")]
        public string NhanViens { get; set; }
    }
}
