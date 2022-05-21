using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    [Table("Vật phẩm")]
    public class VatPham
    {
        [Key]
        [Column("Số seri")]
        public int SoSeri { get; set; }
        [Column("Mã sản phẩm")]
        public string MaSanPham { get; set; }
        
        [ForeignKey("MaSanPham")]
        public virtual SanPham SanPham { get; set; }

        [Column("Mã hóa đơn")]
        public string MaHoaDon { get; set; }
        [ForeignKey("MaHoaDon")]
        public virtual HoaDon HoaDon { get; set; }
    }
}
