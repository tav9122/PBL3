using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    [Table("Tài khoản")]
    public class TaiKhoan
    {
        [Column("Tên tài khoản")]
        [Key]
        [Required]
        public string TenTaiKhoan { get; set; }

        [Column("Mật khẩu")]
        [Required]        
        public string MatKhau { get; set; }
        
        [Column("Mã nhân viên")]
        public string MaNhanVien { get; set; }
        
        [ForeignKey("MaNhanVien")]
        public virtual NhanVien NhanVien { get; set; }

    }
}
