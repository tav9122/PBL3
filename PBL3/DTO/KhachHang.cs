using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    [Table("Khách hàng")]
    public class KhachHang
    {
        [Key]
        [Required]
        [Column("Mã khách hàng")]
        public string MaKhachHang { get; set; }
        
        [Column("Tên khách hàng")]
        public string TenKhachHang { get; set; }
        
        [Column("Địa chỉ")]
        public string DiaChi { get; set; }
        
        [Column("Số điện thoại")]
        public string SoDienThoai { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
