using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    [Table("Nhân viên")]
    public class NhanVien
    {
        [Key]
        [Required]
        [Column("Mã nhân viên")]
        public string MaNhanVien { get; set; }
        
        [Column("Họ và tên")]
        public string HoVaTen { get; set; }
        
        [Column("Số điện thoại")]
        public string SoDienThoai { get; set; }

        [Column("Địa chỉ")]
        public string DiaChi { get; set; }

        [Column("Ngày sinh")]
        public DateTime NgaySinh { get; set; }

        [Column("Giới tính")]
        public bool GioiTinh { get; set; }

        [Column("Mức lương")]
        public double MucLuong { get; set; }

        public virtual ICollection<NhanVienLichLamViec> NhanVienLichLamViecs { get; set; }
    }
}
