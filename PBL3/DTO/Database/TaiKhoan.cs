using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3
{
    [Table("Tài khoản")]
    public class TaiKhoan
    {
        [Column("Tên đăng nhập")]
        [Key]
        [Required]
        public string TenDangNhap { get; set; }

        [Column("Mật khẩu")]
        [Required]
        public string MatKhau { get; set; }

        [Column("Mã nhân viên")]
        public string MaNhanVien { get; set; }

        [ForeignKey("MaNhanVien")]
        public virtual NhanVien NhanVien { get; set; }

    }
}
