using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3
{
    [Table("Tài khoản")]
    public class TaiKhoan
    {
        [Key]
        [Required]
        [Column("Mã tài khoản")]
        public string MaTaiKhoan { get; set; }

        [Column("Tên đăng nhập")]
        public string TenDangNhap { get; set; }

        [Column("Mật khẩu")]
        public string MatKhau { get; set; }

        [Column("Đã đổi tên đăng nhập")]
        [DefaultValue(false)]
        public bool DaDoiTenDangNhap { get; set; }

        [Column("Mã nhân viên")]
        public string MaNhanVien { get; set; }

        [ForeignKey("MaNhanVien")]
        public virtual NhanVien NhanVien { get; set; }

    }
}
