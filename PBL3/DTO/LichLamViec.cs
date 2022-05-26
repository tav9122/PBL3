using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3
{
    [Table("Lịch làm việc")]
    public class LichLamViec
    {
        [Column("Mã lịch làm việc")]
        [Key]
        [Required]
        public string MaLichLamViec { get; set; }

        [Column("Thời gian bắt đầu")]
        public string ThoiGianBatDau { get; set; }

        [Column("Thời gian kết thúc")]
        public string ThoiGianKetThuc { get; set; }

        [Column("Ngày làm việc")]
        public string NgayLamViec { get; set; }

        public virtual ICollection<NhanVienLichLamViec> NhanVienLichLamViecs { get; set; }
    }
}