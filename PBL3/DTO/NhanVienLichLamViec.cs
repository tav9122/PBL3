using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    [Table("Nhân viên - lịch làm việc")]
    public class NhanVienLichLamViec
    {
        [Key]
        [Required]
        [Column("Mã nhân viên- lịch làm việc")]
        public int MaNhanVien_LichLamViec { get; set; }

        [Column("Mã nhân viên")]
        public string MaNhanVien { get; set; }

        
        [ForeignKey("MaNhanVien")]
        public virtual NhanVien NhanVien { get; set; }

        [Column("Mã lịch làm việc")]
        public string MaLichLamViec { get; set; }
        [ForeignKey("MaLichLamViec")]
        public virtual LichLamViec LichLamViec { get; set;  }

    }
}
